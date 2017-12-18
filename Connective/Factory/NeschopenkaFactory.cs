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
    public class NeschopenkaFactory
    {
        public NeschopenkaGatewayInterface<Neschopenka> GetNeschopenka()
        {
            if (Configure.NESCHOPENKAREAD == 0)
            {
                return NeschopenkaGateway<Neschopenka>.Instance;
            }
            /* else
             {
                 return ZamestnanecXMLGateway<Zamestnanec>.instance;
             }*/
            return NeschopenkaGateway<Neschopenka>.Instance;

        }
    }
}
