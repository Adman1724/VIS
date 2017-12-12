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
    class PracoviskoFactory
    {
        public PracoviskoGatewayInterface<Pracovisko> GetPracovisko()
        {
            if (Configure.PRACOVISKOREAD == 0)
            {
                return PracoviskoGateway<Pracovisko>.Instance;
            }
            /* else
             {
                 return ZamestnanecXMLGateway<Zamestnanec>.instance;
             }*/
            return PracoviskoGateway<Pracovisko>.Instance;

        }
    }
}
