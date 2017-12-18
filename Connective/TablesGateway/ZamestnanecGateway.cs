using Connective.Abstract.Interface;
using Connective.Conn;
using Connective.Tables;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connective.TablesGateway
{
   public class ZamestnanecGateway <T> : ZamestnanecGatewayInterface<T>
        where T : Zamestnanec
    {
        private static ZamestnanecGateway<Zamestnanec> instance;
        private ZamestnanecGateway() { }

        public static ZamestnanecGateway<Zamestnanec> Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ZamestnanecGateway<Zamestnanec>();
                }
                return instance;
            }
        }
        public String TABLE_NAME = "Zamestnanec";
        public String SQL_SELECT = "SELECT * FROM Zamestnanec";
        public String SQL_SELECT_ID = "SELECT * FROM Zamestnanec WHERE id_zamestnanca=@id_zamestnanca";
        public String SQL_SELECT_NAME = "SELECT * FROM Zamestnanec WHERE meno=@meno AND priezvysko=@priezvysko ";
        public String SQL_UPDATE = "UPDATE Zamestnanec SET meno=@meno, priezvysko=@priezvisko, rodne_cislo=@rodne_cislo, bydlisko=@bydlisko, pohlavie=@pohlavie, skupina_id_skupiny=@id_skupiny, pracovisko_id_prcoviska=@id_pracoviska, Projekt_id_projekt=@id_projektu, heslo=@heslo, mail=@mail, Vypis=@vypis WHERE id_zamestnanca=@id_zamestnanca";
        public String SQL_INSERT = "INSERT INTO Zamestnanec VALUES(@meno, @priezvisko, @rodne_cislo, @bydlisko, @pohlavie, @id_skupiny, @id_pracoviska, @id_projektu , @heslo, @mail, @vypis)";
        public String SQL_DELETE = "DELETE FROM Zamestnanec WHERE id_zamestnanca=@id_zamestnanca";
        public String SQL_CHECK_LOGIN = "SELECT * FROM Zamestnanec WHERE mail=@mail AND heslo=@heslo";

        public T Select_id(int t)

        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_SELECT_ID);

            command.Parameters.AddWithValue("@id_zamestnanca", t);
            SqlDataReader reader = db.Select(command);

            Collection<T> purchases = Read(reader);
            Zamestnanec purchase = null;
            if (purchases.Count == 1)
            {
                purchase = purchases[0];
            }
            reader.Close();
            db.Close();
            return (T)purchase;
        }
        public T Select_name(String name, String lastname)

        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_SELECT_NAME);
            
            command.Parameters.AddWithValue("@meno", name);
            command.Parameters.AddWithValue("@priezvysko", lastname);
            SqlDataReader reader = db.Select(command);

            Collection<T> purchases = Read(reader);
            Zamestnanec purchase = null;
            if (purchases.Count == 1)
            {
                purchase = purchases[0];
            }
            reader.Close();
            db.Close();
            return (T)purchase;
        }


        public int Insert(T t)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_INSERT);
            PrepareCommand(command, (Zamestnanec)t);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }
        public int Update(T t)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_UPDATE);
            PrepareCommand(command, (Zamestnanec)t);
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

            Collection<T> Zamestnanecs = Read(reader, true);
            reader.Close();
            db.Close();
            return Zamestnanecs;
        }

        private Collection<T> Read(SqlDataReader reader, bool withItemsCount = false)
        {
            Collection<T> zamestnanecs = new Collection<T>();

            while (reader.Read())
            {
                Zamestnanec zamestnanec = new Zamestnanec();
                int i = -1;
                zamestnanec.RecordId = reader.GetInt32(++i);
                zamestnanec.Name = reader.GetString(++i);
                zamestnanec.LastName = reader.GetString(++i);
                zamestnanec.PerIdNum = reader.GetInt32(++i);
                if (!reader.IsDBNull(++i))
                {
                    zamestnanec.Adress = reader.GetString(i);
                }
                if (!reader.IsDBNull(++i))
                {
                    zamestnanec.Sex = reader.GetString(i);
                }
                zamestnanec.Group = reader.GetInt32(++i);
                if (!reader.IsDBNull(++i))
                {
                    zamestnanec.WorkGroup = reader.GetInt32(i);
                }

                if (!reader.IsDBNull(++i))
                {
                    zamestnanec.IdProject = reader.GetDecimal(i);
                }
                if (!reader.IsDBNull(++i))
                {
                    zamestnanec.Heslo = reader.GetString(i);
                }
                if (!reader.IsDBNull(++i))
                {
                    zamestnanec.Mail = reader.GetString(i);
                }
                if (!reader.IsDBNull(++i))
                {
                    zamestnanec.Vypis = reader.GetInt32(i);
                }


                zamestnanecs.Add((T)zamestnanec);
            }
            return zamestnanecs;
        }

        public int Delete(int id)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_DELETE);

            command.Parameters.AddWithValue("@id_zamestnanca", id);
            int ret = db.ExecuteNonQuery(command);

            db.Close();
            return ret;
        }



        private static void PrepareCommand(SqlCommand command, Zamestnanec zamestnanec)
        {
            command.Parameters.AddWithValue("@id_zamestnanca", zamestnanec.RecordId);
            command.Parameters.AddWithValue("@meno", zamestnanec.Name);
            command.Parameters.AddWithValue("@priezvisko", zamestnanec.LastName);
            command.Parameters.AddWithValue("@rodne_cislo", zamestnanec.PerIdNum);
            command.Parameters.AddWithValue("@bydlisko", zamestnanec.Adress);
            command.Parameters.AddWithValue("@pohlavie", zamestnanec.Sex);
            command.Parameters.AddWithValue("@id_skupiny", zamestnanec.Group);
            command.Parameters.AddWithValue("@id_pracoviska", zamestnanec.WorkGroup);
            command.Parameters.AddWithValue("@id_projektu", zamestnanec.IdProject);
            command.Parameters.AddWithValue("@heslo", zamestnanec.Heslo);
            command.Parameters.AddWithValue("@mail", zamestnanec.Mail);
            command.Parameters.AddWithValue("@vypis", zamestnanec.Vypis);

        }
        public string CheckEmp(int idUser, DateTime start, DateTime end, Database pDb)
        {
            Database db;
            if (pDb == null)
            {
                db = new Database();
                db.Connect();
            }
            else
            {
                db = (Database)pDb;
            }


            SqlCommand command = db.CreateCommand("Vypisdochadzky");

            command.CommandType = CommandType.StoredProcedure;

            SqlParameter input = new SqlParameter();
            command.Parameters.Add("@id_uzivatela", SqlDbType.Int).Value = idUser;
            command.Parameters.Add("@start_datum", SqlDbType.DateTime).Value = start;
            command.Parameters.Add("@end_datum", SqlDbType.DateTime).Value = end;



            var returnParameter = command.Parameters.Add("@result", SqlDbType.VarChar, 8000);
            returnParameter.Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();



            if (pDb == null)
            {
                db.Close();
            }
            var value = returnParameter.Value.ToString();
            return value;
        }

        public string AktualnePritomny(int idPrac, Database pDb)
        {
            Database db;
            if (pDb == null)
            {
                db = new Database();
                db.Connect();
            }
            else
            {
                db = (Database)pDb;
            }

            SqlCommand command = db.CreateCommand("Aktualnepritomny");


            command.CommandType = CommandType.StoredProcedure;

            SqlParameter input = new SqlParameter();
            command.Parameters.Add("@id_pracoviska", SqlDbType.Int).Value = idPrac;

            var returnParameter = command.Parameters.Add("@result", SqlDbType.VarChar, 8000);
            returnParameter.Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();


            if (pDb == null)
            {
                db.Close();
            }
            var value = returnParameter.Value.ToString();
            return value;
        }
        public  string Vykon(Database pDb)
        {
            Database db;
            if (pDb == null)
            {
                db = new Database();
                db.Connect();
            }
            else
            {
                db = (Database)pDb;
            }

            SqlCommand command = db.CreateCommand("vykon");

            command.CommandType = CommandType.StoredProcedure;





            var returnParameter = command.Parameters.Add("@result", SqlDbType.VarChar, 8000);
            returnParameter.Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();


            if (pDb == null)
            {
                db.Close();
            }
            var value = returnParameter.Value.ToString();
            return value;
        }

        public string Navsteva(int idZam, Database pDb)
        {
            Database db;
            if (pDb == null)
            {
                db = new Database();
                db.Connect();
            }
            else
            {
                db = (Database)pDb;
            }


            SqlCommand command = db.CreateCommand("Navsteva");

            command.CommandType = CommandType.StoredProcedure;

            SqlParameter input = new SqlParameter();
            command.Parameters.Add("@id_zamestnanca", SqlDbType.Int).Value = idZam;



            var returnParameter = command.Parameters.Add("@result", SqlDbType.VarChar, 8000);
            returnParameter.Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();


            if (pDb == null)
            {
                db.Close();
            }
            var value = returnParameter.Value.ToString();
            return value;
        }
        public void Create(string text, string delic, string delic2, Database pDb)
        {
            Database db;
            if (pDb == null)
            {
                db = new Database();
                db.Connect();
            }
            else
            {
                db = (Database)pDb;
            }

            SqlCommand command = db.CreateCommand("Vkladanie");


            command.CommandType = CommandType.StoredProcedure;


            SqlParameter input = new SqlParameter();
            command.Parameters.Add("@STR", SqlDbType.VarChar).Value = text;
            command.Parameters.Add("@DELIM1", SqlDbType.VarChar).Value = delic;
            command.Parameters.Add("@DELIM2", SqlDbType.VarChar).Value = delic2;

            command.ExecuteNonQuery();



            if (pDb == null)
            {
                db.Close();
            }

        }
        public Zamestnanec CheckPassword(Zamestnanec zamestnanec)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_CHECK_LOGIN);
            command.Parameters.AddWithValue("@mail", zamestnanec.Mail == null ? DBNull.Value : (object)zamestnanec.Mail);
            command.Parameters.AddWithValue("@heslo", zamestnanec.Heslo);

            SqlDataReader reader = db.Select(command);

            Collection<T> clients = Read(reader);
            db.Close();

            if (clients.Count > 0)
            {
                return clients[0];
            }
            return null;
        }


    }
}

