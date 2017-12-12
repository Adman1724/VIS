using Connective.Abstract.Interface;
using Connective.Conn;
using Connective.Tables;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connective.TablesGateway
{
    public class NepritomnostGateway<T> : NepritomnostGatewayInterface<T>
        where T : Nepritomnost
    {

        private static NepritomnostGateway<Nepritomnost> instance;
        private NepritomnostGateway() { }

        public static NepritomnostGateway<Nepritomnost> Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NepritomnostGateway<Nepritomnost>();
                }
                return instance;
            }
        }

        public String TABLE_NAME = "Nepritomnost";
        public String SQL_SELECT = "SELECT * FROM Nepritomnost";
        
        public String SQL_INSERT = "INSERT INTO Nepritomnost ( Zamestnanec_id_zamestnanca, datum)VALUES(@zamestnanec,@datum )";
        public String SQL_DELETE = "DELETE FROM Nepritomnost WHERE id_nepritomnost=@id_nepritomnost";

        public int Insert(T t)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_INSERT);
            PrepareCommand(command, (Nepritomnost)t);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }
        public int Update(T t)
        {
            
            return 0;
        }
        public Collection<T> Select()
        {
            Database db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_SELECT);
            SqlDataReader reader = db.Select(command);

            Collection<T> Nepritomnosts = Read(reader, true);
            reader.Close();
            db.Close();
            return Nepritomnosts;
        }

        private Collection<T> Read(SqlDataReader reader, bool withItemsCount = false)
        {
            Collection<T> nepritomnosts = new Collection<T>();

            while (reader.Read())
            {
                Nepritomnost nepritomnost = new Nepritomnost();
                int i = -1;
                nepritomnost.RecordId = reader.GetInt32(++i);
                nepritomnost.Datum= reader.GetDateTime(++i);
                nepritomnost.Zamestnanec = reader.GetInt32(++i);





                nepritomnosts.Add((T)nepritomnost);
            }
            return nepritomnosts;
        }

        public int Delete(int id)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_DELETE);

            command.Parameters.AddWithValue("@id_nepritomnost", id);
            int ret = db.ExecuteNonQuery(command);

            db.Close();
            return ret;
        }



        private void PrepareCommand(SqlCommand command, Nepritomnost nepritomnost)
        {
            command.Parameters.AddWithValue("@id_nepritomnost", nepritomnost.RecordId);
            command.Parameters.AddWithValue("@datum", nepritomnost.Datum);
            command.Parameters.AddWithValue("@zamestnanec", nepritomnost.Zamestnanec);
           


        }

    }
}
