using Connective.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connective.Tables
{
    public class Zamestnanec : DBRecord
    {
        public override int RecordId { get; set; }
        public String Name { get; set; }
        public String LastName { get; set; }
        public int PerIdNum { get; set; }
        [System.ComponentModel.DefaultValue(null)]
        public String Adress { get; set; }
        [System.ComponentModel.DefaultValue(null)]
        public String Sex { get; set; }
        public int WorkGroup { get; set; }
        public int Group { get; set; }
        [System.ComponentModel.DefaultValue(null)]
        public Decimal IdProject { get; set; }
        public String heslo { get; set; }
    }
}
