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
    public class ProjektGateway<T> : ProjektGatewayInterface<T>
        where T : Projekt
    {
        private static ProjektGateway<Projekt> instance;
        private ProjektGateway() { }

        public static ProjektGateway<Projekt> Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProjektGateway<Projekt>();
                }
                return instance;
            }
        }
        public String TABLE_NAME = "Projekt";
        public String SQL_SELECT = "SELECT * FROM Projekt";
        public String SQL_SELECT_ID = "SELECT * FROM Projekt WHERE id_projekt=@id_projekt";
        public String SQL_UPDATE = "UPDATE Projekt SET nazov=@nazov, Hotovy=@hotovy, Zamestnanec_id_zamestnanca=@id_zamestnanca,ukoncenie=@ukoncenie WHERE id_projekt=@id_projekt";
        public String SQL_INSERT = "INSERT INTO Projekt ( nazov, Hotovy, Zamestnanec_id_zamestnanca, vytvorenie)VALUES(@nazov, @hotovy, @id_zamestnanca, @vytvorenie )";
        public String SQL_DELETE = "DELETE FROM Projekt WHERE id_projekt=@id_projekt";

        public Projekt Select(T t)

        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_SELECT_ID);

            command.Parameters.AddWithValue("@id_projekt", t);
            SqlDataReader reader = db.Select(command);

            Collection<T> purchases = Read(reader);
            Projekt purchase = null;
            if (purchases.Count == 1)
            {
                purchase = purchases[0];
            }
            reader.Close();
            db.Close();
            return purchase;
        }


        public int Insert(T t)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_INSERT);
            PrepareCommand(command, (Projekt)t);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }
        public int Update(T t)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_UPDATE);
            PrepareCommand(command,(Projekt)t);
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

            Collection<T> Projekts = Read(reader, true);
            reader.Close();
            db.Close();
            return Projekts;
        }

        private static Collection<T> Read(SqlDataReader reader, bool withItemsCount = false)
        {
            Collection<T> projekts = new Collection<T>();

            while (reader.Read())
            {
                Projekt projekt = new Projekt();
                int i = -1;

                projekt.RecordId = reader.GetInt32(++i);
                if (!reader.IsDBNull(++i))
                {
                    projekt.Name = reader.GetString(i);
                }
                projekt.Finish = reader.GetBoolean(++i);
                projekt.IdManagEmp = reader.GetInt32(++i);
                projekt.Start = reader.GetDateTime(++i);

                if (!reader.IsDBNull(++i))
                {
                    projekt.End = reader.GetDateTime(i);
                }

                projekts.Add((T)projekt);
            }
            return projekts;
        }

        public int Delete(int id)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_DELETE);

            command.Parameters.AddWithValue("@id_projekt", id);
            int ret = db.ExecuteNonQuery(command);

            db.Close();
            return ret;
        }



        private static void PrepareCommand(SqlCommand command, Projekt projekt)
        {
            command.Parameters.AddWithValue("@id_projekt", projekt.RecordId);
            command.Parameters.AddWithValue("@nazov", projekt.Name);
            command.Parameters.AddWithValue("@hotovy", projekt.Finish);
            command.Parameters.AddWithValue("@vytvorenie", projekt.Start);
            command.Parameters.AddWithValue("@id_zamestnanca", projekt.IdManagEmp);
            command.Parameters.AddWithValue("@ukonceny", projekt.End == null ? DBNull.Value : (object)projekt.End);
        }

    }
}
