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
    public class HardwareGateway<T> : HardwareGatewayInterface<T>
        where T : Hardware
    {

        private static HardwareGateway<Hardware> instance;
        private HardwareGateway() { }

        public static HardwareGateway<Hardware> Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HardwareGateway<Hardware>();
                }
                return instance;
            }
        }

        public String TABLE_NAME = "hardware";
        public String SQL_SELECT_ID = "SELECT FROM hardware WHERE nazov=@nazov";
        public String SQL_SELECT = "SELECT * FROM hardware";
        public String SQL_UPDATE = "UPDATE hardware SET nazov=@nazov, popis=@popis,ip_adresa=@ip,  pracovisko_id_prcoviska=@id_pracoviska WHERE id_hardware=@id_hardware";
        public String SQL_INSERT = "INSERT INTO hardware ( nazov, popis, ip_adresa, pracovisko_id_prcoviska)VALUES(@nazov,@popis, @ip, @id_pracoviska )";
        public String SQL_DELETE = "DELETE FROM hardware WHERE id_hardware=@id_hardware";

        public int Insert(T t)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_INSERT);
            PrepareCommand(command, (Hardware)t);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }
        public int Update(T t)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_UPDATE);
            PrepareCommand(command, (Hardware)t);
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

            Collection<T> Hardwares = Read(reader, true);
            reader.Close();
            db.Close();
            return Hardwares;
        }

        private Collection<T> Read(SqlDataReader reader, bool withItemsCount = false)
        {
            Collection<T> hardwares = new Collection<T>();

            while (reader.Read())
            {
                Hardware hardware = new Hardware();
                int i = -1;
                hardware.RecordId = reader.GetInt32(++i);
                hardware.Name = reader.GetString(++i);
                hardware.IpAddress = reader.GetString(++i);
                hardware.Descripe = reader.GetString(++i);
                hardware.WorkGroup = reader.GetInt32(++i);



                hardwares.Add((T)hardware);
            }
            return hardwares;
        }

        public int Delete(int id)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_DELETE);

            command.Parameters.AddWithValue("@id_hardware", id);
            int ret = db.ExecuteNonQuery(command);

            db.Close();
            return ret;
        }



        private void PrepareCommand(SqlCommand command, Hardware hardware)
        {
            command.Parameters.AddWithValue("@id_hardware", hardware.RecordId);
            command.Parameters.AddWithValue("@nazov", hardware.Name);
            command.Parameters.AddWithValue("@popis", hardware.Descripe);
            command.Parameters.AddWithValue("@ip", hardware.IpAddress);
            command.Parameters.AddWithValue("@id_pracoviska", hardware.WorkGroup);

        }

    }
}
