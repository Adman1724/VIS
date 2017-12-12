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
    public class SkupinaGateway<T> : SkupinaGatewayInterface<T>
        where T : Skupina

    {
        private static SkupinaGateway<Skupina> instance;
        private SkupinaGateway() { }

        public static SkupinaGateway<Skupina> Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SkupinaGateway<Skupina>();
                }
                return instance;
            }
        }

        public String TABLE_NAME = "Skupina";
        public String SQL_SELECT = "SELECT * FROM Skupina";
        public String SQL_UPDATE = "UPDATE Skupina SET nazov_skupiny=@nazov WHERE id_skupiny=@id_skupiny";
        public String SQL_INSERT = "INSERT INTO Skupina (nazov_skupiny)VALUES(@nazov)";
        public String SQL_DELETE = "DELETE FROM Skupina WHERE id_skupiny=@id_skupiny";

        public int Insert(T t)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_INSERT);
            PrepareCommand(command, (Skupina)t);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }
        public int Update(T t)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_UPDATE);
            PrepareCommand(command, (Skupina)t);
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

            Collection<T> Skupinas = Read(reader, true);
            reader.Close();
            db.Close();
            return Skupinas;
        }

        private Collection<T> Read(SqlDataReader reader, bool withItemsCount = false)
        {
            Collection<T> skupinas = new Collection<T>();

            while (reader.Read())
            {
                Skupina skupina = new Skupina();
                int i = -1;
                skupina.RecordId = reader.GetInt32(++i);
                skupina.Name = reader.GetString(++i);

                skupinas.Add((T)skupina);
            }
            return skupinas;
        }

        public int Delete(int id)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_DELETE);

            command.Parameters.AddWithValue("@id_skupiny", id);
            int ret = db.ExecuteNonQuery(command);

            db.Close();
            return ret;
        }



        private void PrepareCommand(SqlCommand command, Skupina skupina)
        {
            command.Parameters.AddWithValue("@id_skupiny", skupina.RecordId);
            command.Parameters.AddWithValue("@nazov", skupina.Name);

        }


    }
}
