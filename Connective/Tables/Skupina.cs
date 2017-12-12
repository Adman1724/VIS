using Connective.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connective.Tables
{
    public class Skupina : DBRecord
    {
        public override int RecordId { get; set; }
        [System.ComponentModel.DefaultValue(null)]
        public String Name { get; set; }

    }
}
