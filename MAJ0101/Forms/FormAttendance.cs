
using Connective.Factory;
using Connective.Tables;
using Connective.TablesGateway;
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
    public partial class FormAttendance : Form
    {
        Collection<Pracovisko> p;
        Collection<Zamestnanec> z;
        Collection<Step> step = new Collection<Step>();
        DateTime s = new DateTime();
        DateTime k = new DateTime();
        bool refresh = false;
        public FormAttendance()
        {
            ZamestnanecFactory zamestnanecFactory = new ZamestnanecFactory();
            ZamestnanecGateway<Zamestnanec> zg = (ZamestnanecGateway<Zamestnanec>)zamestnanecFactory.GetZamestnanec();
            z = zg.Select();
            PracoviskoFactory pracoviskoFactory = new PracoviskoFactory();
            PracoviskoGateway<Pracovisko> pg = (PracoviskoGateway<Pracovisko>)pracoviskoFactory.GetPracovisko();
            p = pg.Select();
            InitializeComponent();
            loadWork();
        }
        private void loadWork()
        {
            foreach(var i in p)
            {
                comboWork.Items.Add(i.Name);
            }
            
            
            loadEmp();
        }

        private void loadEmp()
        {
            if (refresh)
            {
                foreach (var i in p)
                {
                    if (i.Name.Equals(comboWork.Text, StringComparison.Ordinal))
                    {
                        foreach (var j in z)
                        {
                            if (i.RecordId == j.WorkGroup)
                            {
                                string a = j.Name + " " + j.LastName;
                                comboZam.Items.Add(a);
                            }
                        }
                    }
                }
            }
            else
            {
                foreach (var j in z)
                {
                    string a = j.Name + " " + j.LastName;
                    comboZam.Items.Add(a);
                }
            }


        }

        private void zaciatokD_ValueChanged(object sender, EventArgs e)
        {
            s = zaciatokD.Value;
        }

        private void koniecD_ValueChanged(object sender, EventArgs e)
        {
            k = koniecD.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            step = new Collection<Step>();
            string a= comboZam.Text;
            string result="1";
            string[] word = a.Split(' ');
            foreach (var i in z)
            {
                if(word[0].Equals(i.Name, StringComparison.Ordinal)&& word[1].Equals(i.LastName, StringComparison.Ordinal))
                {
                    ZamestnanecFactory zamestnanecFactory = new ZamestnanecFactory();
                    ZamestnanecGateway<Zamestnanec> zg = (ZamestnanecGateway<Zamestnanec>)zamestnanecFactory.GetZamestnanec();

                    result = zg.CheckEmp(i.RecordId, s, k,null);
                }
            }
            
            string[] word1= result.Split(';');
            foreach(var j in word1)
            {
                string[] word2 = j.Split(',');
                int counter = 0;
                Step steps = new Step();
                foreach (var k in word2)
                {
                    if (counter == 0)
                    {
                        steps.Date = k;
                    }
                    if (counter == 1)
                    {
                        steps.Status = k;
                    }
                    counter++;
                }
                step.Add(steps);
            }
            BindingList<Step> Bactive = new BindingList<Step>(step);
            gridStep.AutoGenerateColumns = false;
            gridStep.DataSource = Bactive;
        }

        private void comboWork_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh = true;
            loadEmp();
        }

        private void gridStep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
