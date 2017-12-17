using Connective.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connective.Tables
{
   public class Historia_pristupu : DBRecord
    {
        public override int RecordId { get; set; }
        public DateTime Date { get; set; }
        public int IdEmp { get; set; }
        public int IdHardware { get; set; }
       public Historia_pristupu() { }
        public Historia_pristupu(DateTime date,int idz,int idh ) {
            this.Date = date;
            this.IdEmp = idz;
            this.IdHardware = idh;


        }
    }
}
