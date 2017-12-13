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
    public class PoruchaFactory
    {
        public PoruchaGatewayInterface<Porucha> GetPorucha()
        {
            if (Configure.PORUCHAREAD == 0)
            {
                return PoruchaGateway<Porucha>.Instance;
            }
            /* else
             {
                 return ZamestnanecXMLGateway<Zamestnanec>.instance;
             }*/
            return PoruchaGateway<Porucha>.Instance;

        }
    }
}
