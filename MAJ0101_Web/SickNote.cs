using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MAJ0101_Web
{
    public class SickNote
    {
      public  DateTime Date { get; set; }
       public DateTime Date2 { get; set; }
       public  String Text { get; set; }
        public SickNote(DateTime d,DateTime d1,String t)
        {
            this.Date = d;
            this.Date2 = d1;
            this.Text = t;

        }
    }
}