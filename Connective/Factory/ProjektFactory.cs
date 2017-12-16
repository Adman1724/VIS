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
    public class ProjektFactory
    {
        public ProjektGatewayInterface<Projekt> GetProjekt()
        {
            if (Configure.PROJEKTREAD == 0)
            {
                return ProjektGateway<Projekt>.Instance;
            }
            /* else
             {
                 return ZamestnanecXMLGateway<Zamestnanec>.instance;
             }*/
            return ProjektGateway<Projekt>.Instance;

        }
    }
}
