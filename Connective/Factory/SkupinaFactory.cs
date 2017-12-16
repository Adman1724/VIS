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
    public class SkupinaFactory
    {
        public SkupinaGatewayInterface<Skupina> GetSkupina()
        {
            if (Configure.SKUPINAREAD == 0)
            {
                return SkupinaGateway<Skupina>.Instance;
            }
            /* else
             {
                 return ZamestnanecXMLGateway<Zamestnanec>.instance;
             }*/
            return SkupinaGateway<Skupina>.Instance;

        }
    }
}
