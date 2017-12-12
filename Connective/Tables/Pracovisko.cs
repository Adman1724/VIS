using Connective.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connective.Tables
{
    public class Pracovisko : DBRecord
    {
        public override int RecordId { get; set; }
        public String Name { get; set; }
        [System.ComponentModel.DefaultValue(null)]
        public int? Floor { get; set; }
        public String IpRange { get; set; }
        public int IdEmp { get; set; }
    }
}
