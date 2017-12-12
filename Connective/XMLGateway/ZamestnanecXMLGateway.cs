using Connective.Abstract.Interface;
using Connective.Tables;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Connective.XMLGateway
{
    class ZamestnanecXMLGateway<T> : ZamestnanecGatewayInterface<T>
        where T: Zamestnanec
    {
        private static ZamestnanecXMLGateway<Zamestnanec> instance;
        private ZamestnanecXMLGateway() { }

        public static ZamestnanecXMLGateway<Zamestnanec> Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ZamestnanecXMLGateway<Zamestnanec>();
                }
                return instance;
            }
        }

        public XElement Insert(Zamestnanec zamestnanec)
        {
            XElement result = new XElement("Zamestnanec",
                new XAttribute("Id", zamestnanec.RecordId),
            new XAttribute("meno", zamestnanec.Name),
            new XAttribute("priezvisko", zamestnanec.LastName),
            new XAttribute("rodne_cislo", zamestnanec.PerIdNum),
            new XAttribute("bydlisko", zamestnanec.Adress),
            new XAttribute("pohlavie", zamestnanec.Sex),
            new XAttribute("id_skupiny", zamestnanec.Group),
            new XAttribute("id_pracoviska", zamestnanec.WorkGroup),
            new XAttribute("id_projektu", zamestnanec.IdProject),
            new XAttribute("heslo", zamestnanec.heslo));

            return result;
        }

        Collection<T> Gateway<T>.Select()
        {
            XDocument xDoc = XDocument.Load(Paths.FilePath);
            Collection<T> clients = new Collection<T>();

            List<XElement> elements = xDoc.Descendants("Zamestnanci").Descendants("Zamestnanec").ToList();
            foreach (var element in elements)
            {
                var res = 0;
                Zamestnanec zamestnanec = new Zamestnanec()
                {
                    Name = element.Attribute("Name").Value,
                    LastName = element.Attribute("Surname").Value,
                    PerIdNum = element.Attribute("").Value,
                    Adress = element.Attribute("Gender").Value,
                    Sex = int.TryParse(element.Attribute("CardId").Value, out res),
                    WorkGroup = int.TryParse(element.Attribute("CardId").Value, out res) == true ? res : 0
                    Group= int.TryParse(element.Attribute("CardId").Value, out res) == true ? res : 0
                    IdProject=int.TryParse(element.Attribute("CardId").Value, out res) == true ? res : 0
                    heslo = int.TryParse(element.Attribute("CardId").Value, out res) == true ? res : 0


                };
                if (client.CardId == 0)
                    client.CardId = null;
                clients.Add((T)client);
            }

            return clients;
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(T t)
        {
            throw new NotImplementedException();
        }

        public int Update(T t)
        {
            throw new NotImplementedException();
        }
    }
}
