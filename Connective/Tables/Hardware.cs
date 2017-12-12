using Connective.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connective.Tables
{
    public class Hardware : DBRecord
    {
        public override int RecordId { get; set; }
        public String Name { get; set; }
        public String Descripe { get; set; }
        public String IpAddress { get; set; }
        public int WorkGroup { get; set; }
    }
}
