using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MAJ0101_Web
{
    public class Active
    {
        public DateTime Date { get; set; }
        public String Text { get; set; }
        public Active (DateTime d,String t)
        {
            this.Date = d;
            this.Text = t;

        }
    }
}