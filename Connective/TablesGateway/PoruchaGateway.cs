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
    public class PoruchaGateway<T> : PoruchaGatewayInterface<T>
        where T : Porucha
    {
        private static PoruchaGateway<Porucha> instance;
        private PoruchaGateway() { }

        public static PoruchaGateway<Porucha> Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PoruchaGateway<Porucha>();
                }
                return instance;
            }
        }

        public String TABLE_NAME = "porucha";
        public String SQL_SELECT = "SELECT * FROM porucha";
        public String SQL_UPDATE = "UPDATE porucha SET datum=@datum, hardware_id_hardware=@id_hardware, opravena=@opravena, text=@text WHERE id_porucha=@id_porucha";
        public  String SQL_INSERT = "INSERT INTO porucha VALUES( @datum, @opravena, @id_hardware, @text )";
        public String SQL_DELETE = "DELETE FROM porucha WHERE id_porucha=@id_porucha";

        public int Insert(T t)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_INSERT);
            PrepareCommand(command, (Porucha)t);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }
        public int Update(T t)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_UPDATE);
            PrepareCommand(command, (Porucha)t);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }
        public  Collection<T> Select()
        {
            Database db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_SELECT);
            SqlDataReader reader = db.Select(command);

            Collection<T> Poruchas = Read(reader, true);
            reader.Close();
            db.Close();
            return Poruchas;
        }

        private static Collection<T> Read(SqlDataReader reader, bool withItemsCount = false)
        {
            Collection<T> poruchas = new Collection<T>();

            while (reader.Read())
            {
                Porucha porucha = new Porucha();
                int i = -1;
                porucha.RecordId = reader.GetInt32(++i);
                porucha.Date = reader.GetDateTime(++i);
                porucha.repair = reader.GetBoolean(++i);
                porucha.IdHardware = reader.GetInt32(++i);
                if (!reader.IsDBNull(++i))
                {
                    porucha.Text = reader.GetString(i);
                }




                poruchas.Add((T)porucha);
            }
            return poruchas;
        }

        public int Delete(int id)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_DELETE);

            command.Parameters.AddWithValue("@id_porucha", id);
            int ret = db.ExecuteNonQuery(command);

            db.Close();
            return ret;
        }



        private static void PrepareCommand(SqlCommand command, Porucha porucha)
        {
            command.Parameters.AddWithValue("@id_porucha", porucha.RecordId);
            command.Parameters.AddWithValue("@datum", porucha.Date);
            command.Parameters.AddWithValue("@id_hardware", porucha.IdHardware);
            command.Parameters.AddWithValue("@opravena", porucha.repair);
            command.Parameters.AddWithValue("@text", porucha.Text);
        }


    }
}
