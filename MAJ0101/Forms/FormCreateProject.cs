
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
    public partial class FormCreateProject : Form
    {
        Projekt p = new Projekt();
        Collection<Zamestnanec> z;
        public FormCreateProject()
        {
            ZamestnanecFactory zamestnanecFactory = new ZamestnanecFactory();
            ZamestnanecGateway<Zamestnanec> zg = (ZamestnanecGateway<Zamestnanec>)zamestnanecFactory.GetZamestnanec();
            z = zg.Select();
            InitializeComponent();
            empLoad();
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {
            p.Name = textName.Text;
        }
        private void empLoad()
        {
            foreach(var i in z)
            {
                string a = i.Name + " " + i.LastName;
                comboZamestanec.Items.Add(a);
            }
        }

        private void zaciatok_DateChanged(object sender, DateRangeEventArgs e)
        {
            p.Start = zaciatok.SelectionRange.Start;
        }

        private void koniec_DateChanged(object sender, DateRangeEventArgs e)
        {
            p.End= koniec.SelectionRange.Start;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = comboZamestanec.Text;
            string[] word = a.Split(' ');
            foreach (var i in z)
            {
                if (i.Name.Equals(word[0]) && i.LastName.Equals(word[1]))
                {
                    p.IdManagEmp = i.RecordId;
                }

            }
            if (p.Start <= p.End)

         {
                ProjektFactory projektFactory = new ProjektFactory();
                ProjektGateway<Projekt> prg = (ProjektGateway<Projekt>)projektFactory.GetProjekt();
                prg.Insert(p);
                Close();
            }
            else MessageBox.Show("Zvolte iny datum");
            
        }
    }
}
