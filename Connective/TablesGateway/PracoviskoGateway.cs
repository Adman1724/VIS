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
    public class PracoviskoGateway<T> : PracoviskoGatewayInterface<T>
        where T : Pracovisko
    {

        private static PracoviskoGateway<Pracovisko> instance;
        private PracoviskoGateway() { }

        public static PracoviskoGateway<Pracovisko> Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PracoviskoGateway<Pracovisko>();
                }
                return instance;
            }
        }
        public String TABLE_NAME = "Pracovisko";
        public String SQL_SELECT = "SELECT * FROM Pracovisko";
        public String SQL_UPDATE = "UPDATE Pracovisko SET nazov_pracoviska=@nazov, poschodie=@poschodie,ip_rozsah=@ip, Zamestnanec_id_zamestnanca=@id_zamestnanca WHERE id_prcoviska=@id_pracoviska";
        public String SQL_INSERT = "INSERT INTO Pracovisko ( nazov_pracoviska, poschodie, ip_rozsah, Zamestnanec_id_zamestnanca )VALUES(@nazov, @poschodie, @ip, @id_zamestnanca)";
        public String SQL_DELETE = "DELETE FROM Pracovisko WHERE id_prcoviska=@id_pracoviska";

        public int Insert(T t)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_INSERT);
            PrepareCommand(command,(Pracovisko)t);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }
        public int Update(T t)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_UPDATE);
            PrepareCommand(command, (Pracovisko)t);
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

            Collection<T> Pracoviskos = Read(reader, true);
            reader.Close();
            db.Close();
            return Pracoviskos;
        }

        private Collection<T> Read(SqlDataReader reader, bool withItemsCount = false)
        {
            Collection<T> pracoviskos = new Collection<T>();

            while (reader.Read())
            {
                Pracovisko pracovisko = new Pracovisko();
                int i = -1;
                pracovisko.RecordId = reader.GetInt32(++i);
                pracovisko.Name = reader.GetString(++i);
                if (!reader.IsDBNull(++i))
                {
                    pracovisko.Floor = reader.GetInt32(i);
                }
                pracovisko.IpRange = reader.GetString(++i);
                pracovisko.IdEmp = reader.GetInt32(++i);

                pracoviskos.Add((T)pracovisko);
            }
            return pracoviskos;
        }

        public int Delete(int id)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_DELETE);

            command.Parameters.AddWithValue("@id_pracoviska", id);
            int ret = db.ExecuteNonQuery(command);

            db.Close();
            return ret;
        }



        private static void PrepareCommand(SqlCommand command, Pracovisko pracovisko)
        {
            command.Parameters.AddWithValue("@id_pracoviska", pracovisko.RecordId);
            command.Parameters.AddWithValue("@nazov", pracovisko.Name);
            command.Parameters.AddWithValue("@ip", pracovisko.IpRange);
            command.Parameters.AddWithValue("@poschodie", pracovisko.Floor);
            command.Parameters.AddWithValue("@id_zamestnanca", pracovisko.IdEmp);

        }

    }
}
