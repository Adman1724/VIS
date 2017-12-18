using Connective.Abstract.Interface;
using Connective.Tables;
using Connective.TablesGateway;
using Connective.XMLGateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connective.Factory
{
    public  class HardwareFactory
    {
        public HardwareGatewayInterface<Hardware> GetHardware()
        {
            if (Configure.HARDWAREREAD == 0)
            {
                return HardwareGateway<Hardware>.Instance;
            }
             else
             {
                 return HardwareXMLGateway<Hardware>.Instance;
             }
            

        }
    }
}
