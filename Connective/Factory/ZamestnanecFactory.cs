using Connective.Abstract.Interface;
using Connective.Tables;
using Connective.TablesGateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connective.Factory
{
    class ZamestnanecFactory
    {
        public ZamestnanecGatewayInterface<Zamestnanec> GetZamestnanec()
        {
            if (Configure.ZAMESTNANECREAD == 0)
            {
                return ZamestnanecGateway<Zamestnanec>.Instance;
            }
            /* else
             {
                 return ZamestnanecXMLGateway<Zamestnanec>.instance;
             }*/
            return ZamestnanecGateway<Zamestnanec>.Instance;

        }
    }
}

