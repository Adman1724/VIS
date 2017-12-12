using Connective.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connective.Tables
{
    public class Porucha : DBRecord
    {
        public override int RecordId { get; set; }
        public DateTime Date { get; set; }
        public Boolean repair { get; set; }
        public int IdHardware { get; set; }
        [System.ComponentModel.DefaultValue(null)]
        public String Text { get; set; }
    }
}
