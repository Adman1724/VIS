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
    public class NeschopenkaGateway<T> : NeschopenkaGatewayInterface<T>
        where T : Neschopenka
    {

        private static NeschopenkaGateway<Neschopenka> instance;
        private NeschopenkaGateway() { }

        public static NeschopenkaGateway<Neschopenka> Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NeschopenkaGateway<Neschopenka>();
                }
                return instance;
            }
        }

        public String TABLE_NAME = "Neschopenka";
        public String SQL_SELECT = "SELECT * FROM Neschopenka";
        public String SQL_UPDATE = "UPDATE Neschopenka SET text=@text WHERE id_neschopenka=@id_neschopenka";
        public String SQL_INSERT = "INSERT INTO Neschopenka ( datum, Nepritomnost_id_nepritomnost, text)VALUES(@datum,@nepritomnost, @text )";
        public String SQL_DELETE = "DELETE FROM Neschopenka WHERE id_neschopenka=@id_neschopenka";

        public int Insert(T t)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_INSERT);
            PrepareCommand(command,(Neschopenka)t);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }
        public int Update(T t)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_UPDATE);
            PrepareCommand(command, (Neschopenka)t);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }
        public Collection<T> Select()
        {
            Database db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_SELECT);
            SqlDataReader reader = db.Select(command);

            Collection<T> Neschopenkas = Read(reader, true);
            reader.Close();
            db.Close();
            return Neschopenkas;
        }

        private Collection<T> Read(SqlDataReader reader, bool withItemsCount = false)
        {
            Collection<T> neschopenkas = new Collection<T>();

            while (reader.Read())
            {
                Neschopenka neschopenka = new Neschopenka();
                int i = -1;
                neschopenka.RecordId = reader.GetInt32(++i);
                neschopenka.Datum= reader.GetDateTime(++i);
                neschopenka.Text = reader.GetString(++i);
                neschopenka.Nepritomnost = reader.GetInt32(++i);




                neschopenkas.Add((T)neschopenka);
            }
            return neschopenkas;
        }

        public int Delete(int id)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_DELETE);

            command.Parameters.AddWithValue("@id_neschopenka", id);
            int ret = db.ExecuteNonQuery(command);

            db.Close();
            return ret;
        }



        private void PrepareCommand(SqlCommand command, Neschopenka neschopenka)
        {
            command.Parameters.AddWithValue("@id_neschopenka", neschopenka.RecordId);
            command.Parameters.AddWithValue("@text", neschopenka.Text);
            command.Parameters.AddWithValue("@datum", neschopenka.Datum);
            command.Parameters.AddWithValue("@nepritomnost", neschopenka.Nepritomnost);
           

        }

    }
}
