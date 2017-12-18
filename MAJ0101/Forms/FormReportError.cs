
using Connective.Factory;
using Connective.Tables;
using Connective.TablesGateway;
using Connective.XMLGateway;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAJ0101.Forms
{
    public partial class FormReportError : Form
    {
        Porucha p = new Porucha();
        Collection<Hardware> h;
        public FormReportError()
        {
            HardwareFactory hardwareFactory = new HardwareFactory();
           
            h = hardwareFactory.GetHardware().Select();
            InitializeComponent();

        }
        public void loadHardware(object idWorkGroup)
        {
            int a = (int)idWorkGroup;
            foreach(var i in h)
            {
                if (i.WorkGroup == a)
                {
                    comboBox1.Items.Add(i.Name);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            p.Text = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!= null&&comboBox1.SelectedIndex!=null) { 
                foreach (var i in h)
                {
                    if (i.Name.Equals(comboBox1.Text, StringComparison.Ordinal))
                    {
                        p.IdHardware = i.RecordId;
                    }
                }
            DateTime d = DateTime.Now;
            p.Date = d;
            p.repair = false;
            PoruchaFactory poruchaFactory = new PoruchaFactory();
            PoruchaGateway<Porucha> pg = (PoruchaGateway<Porucha>)poruchaFactory.GetPorucha();
            pg.Insert(p);
            Close(); }
            else MessageBox.Show("Choose dates!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
