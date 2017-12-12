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
    class Historia_pristupuFactory
    {
        public Historia_pristupuGatewayInterface<Historia_pristupu> GetNHistoria_pristupu()
        {
            if (Configure.HISTORIA_PRISTUPUREAD == 0)
            {
                return Historia_pristupuGateway<Historia_pristupu>.Instance;
            }
            /* else
             {
                 return ZamestnanecXMLGateway<Zamestnanec>.instance;
             }*/
            return Historia_pristupuGateway<Historia_pristupu>.Instance;

        }
    }
}
