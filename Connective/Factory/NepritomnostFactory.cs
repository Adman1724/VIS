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
    public class NepritomnostFactory
    {
        public NepritomnostGatewayInterface<Nepritomnost> GetNepritomnost()
        {
            if (Configure.NEPRITOMNOSTREAD == 0)
            {
                return NepritomnostGateway<Nepritomnost>.Instance;
            }
            /* else
             {
                 return ZamestnanecXMLGateway<Zamestnanec>.instance;
             }*/
            return NepritomnostGateway<Nepritomnost>.Instance;

        }
    }
}
