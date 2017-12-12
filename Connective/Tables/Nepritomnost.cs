using Connective.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connective.Tables
{
    public class Nepritomnost : DBRecord
    {
        public override int RecordId { get; set; }
        public int Zamestnanec { get; set; }
        public DateTime Datum { get; set; }
    } 
}
