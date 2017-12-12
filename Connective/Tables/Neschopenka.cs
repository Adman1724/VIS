using Connective.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connective.Tables
{
    public class Neschopenka : DBRecord
    {
        public override int RecordId { get; set; }
        public DateTime Datum{ get; set; }
        public int Nepritomnost { get; set; }
        public String Text { get; set; }

    }
}
