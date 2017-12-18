using Connective.Abstract.Interface;
using Connective.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace Connective.XMLGateway
{
   public class HardwareXMLGateway<T> : HardwareGatewayInterface<T>
         where T: Hardware
    {
        private static HardwareXMLGateway<Hardware> instance;
        private HardwareXMLGateway() { }

        public static HardwareXMLGateway<Hardware> Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HardwareXMLGateway<Hardware>();
                }
                return instance;
            }
        }

        public XElement Insert(Hardware Hardware)
        {
            XElement result = new XElement("Hardwares",
                new XAttribute("Id", Hardware.RecordId),
                new XAttribute("Name", Hardware.Name),
                new XAttribute("Descripe", Hardware.Descripe),
                new XAttribute("IpAddress", Hardware.IpAddress),
                new XAttribute("WorkGroup", Hardware.WorkGroup)
      );

            return result;
        }

        Collection<T> Gateway<T>.Select()
        {
            XDocument xDoc = XDocument.Load(Paths.FilePath);
            Collection<T> Hardwares = new Collection<T>();

            List<XElement> elements = xDoc.Descendants("Hardware").Descendants("Hardwares").ToList();
            foreach (var element in elements)
            {
                var res = 0;
                Hardware hardware = new Hardware()
                {
                  
                    RecordId = int.TryParse(element.Attribute("Id").Value, out res) == true ? res : 0,
                    Name = element.Attribute("Name").Value,
                    Descripe = element.Attribute("Descripe").Value,
                    IpAddress = element.Attribute("IpAddress").Value,
                    WorkGroup = int.TryParse(element.Attribute("WorkGroup").Value, out res) == true ? res : 0,
                };
                Hardwares.Add((T)hardware);
                
            }

            return Hardwares;
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

        public Collection<T> Select()
        {
            throw new NotImplementedException();
        }
    }




}
