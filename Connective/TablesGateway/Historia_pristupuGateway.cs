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
   public class Historia_pristupuGateway<T> : Historia_pristupuGatewayInterface<T>
        where T : Historia_pristupu
    {
        private static Historia_pristupuGateway<Historia_pristupu> instance;
        private Historia_pristupuGateway() { }

        public static Historia_pristupuGateway<Historia_pristupu> Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Historia_pristupuGateway<Historia_pristupu>();
                }
                return instance;
            }
        }

        public static String TABLE_NAME = "historia_pristupu";
        public static String SQL_SELECT = "SELECT * FROM historia_pristupu";
        public static String SQL_UPDATE = "UPDATE historia_pristupu SET datum=@datum, Zamestnanec_id_zamestnanca=@id_zamestnanca, hardware_id_hardware=@id_hardware WHERE id_historia=@id_historia";
        public static String SQL_INSERT = "INSERT INTO historia_pristupu ( datum, Zamestnanec_id_zamestnanca, hardware_id_hardware)VALUES(@datum, @id_zamestnanca, @id_hardware )";
        public static String SQL_DELETE = "DELETE FROM historia_pristupu WHERE id_historia=@id_historia";

        public int Insert(T t)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_INSERT);
            PrepareCommand(command, (Historia_pristupu)t);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }
        public int Update(T t)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_UPDATE);
            PrepareCommand(command, (Historia_pristupu)t);
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

            Collection<T> Historia_pristupus = Read(reader, true);
            reader.Close();
            db.Close();
            return Historia_pristupus;
        }

        private Collection<T> Read(SqlDataReader reader, bool withItemsCount = false)
        {
            Collection<T> historia_pristupus = new Collection<T>();

            while (reader.Read())
            {
                Historia_pristupu historia_pristupu = new Historia_pristupu();
                int i = -1;
                historia_pristupu.RecordId = reader.GetInt32(++i);
                historia_pristupu.Date = reader.GetDateTime(++i);
                historia_pristupu.IdEmp = reader.GetInt32(++i);
                historia_pristupu.IdHardware = reader.GetInt32(++i);



                historia_pristupus.Add((T)historia_pristupu);
            }
            return historia_pristupus;
        }

        public int Delete(int id)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_DELETE);

            command.Parameters.AddWithValue("@id_historia", id);
            int ret = db.ExecuteNonQuery(command);

            db.Close();
            return ret;
        }



        private static void PrepareCommand(SqlCommand command, Historia_pristupu historia_pristupu)
        {
            command.Parameters.AddWithValue("@id_historia", historia_pristupu.RecordId);
            command.Parameters.AddWithValue("@datum", historia_pristupu.Date);
            command.Parameters.AddWithValue("@id_hardware", historia_pristupu.IdHardware);
            command.Parameters.AddWithValue("@id_zamestnanca", historia_pristupu.IdEmp);

        }


    }
}
