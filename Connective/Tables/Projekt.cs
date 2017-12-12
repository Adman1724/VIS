using Connective.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connective.Tables
{
    public class Projekt : DBRecord
    {
        public override int RecordId { get; set; }
        [System.ComponentModel.DefaultValue(null)]
        public String Name { get; set; }
        public Boolean Finish { get; set; }
        public int IdManagEmp { get; set; }
        public DateTime Start { get; set; }
        [System.ComponentModel.DefaultValue(null)]
        public DateTime? End { get; set; }
    }
}
