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
        public Nepritomnost() { }
        public Nepritomnost(int id,int id_z, DateTime date)
        {
            this.RecordId = id;
            this.Datum = date;
            this.Zamestnanec = id_z;

        }
        

        }
    } 

