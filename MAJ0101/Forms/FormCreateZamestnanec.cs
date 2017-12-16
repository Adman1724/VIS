
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
    public partial class FormCreateZamestnanec : Form
    {
        Zamestnanec z = new Zamestnanec();
        Collection<Skupina> s;
        Collection<Pracovisko> w;
        Collection<Projekt> p;
        public FormCreateZamestnanec()
        {
            SkupinaFactory skupinaFactory = new SkupinaFactory();
            SkupinaGateway<Skupina> sg = (SkupinaGateway<Skupina>)skupinaFactory.GetSkupina();
            s=sg.Select();
            PracoviskoFactory pracoviskoFactory = new PracoviskoFactory();
            PracoviskoGateway<Pracovisko> pg = (PracoviskoGateway<Pracovisko>)pracoviskoFactory.GetPracovisko();
            w = pg.Select();
            ProjektFactory projektFactory = new ProjektFactory();
            ProjektGateway<Projekt> prg = (ProjektGateway<Projekt>)projektFactory.GetProjekt();
            p = prg.Select();
            InitializeComponent();
            
            z.Name = "";
                z.LastName = "";
                z.Adress = "";
            z.PerIdNum = 0;
            groupC();
            workC();
            projectC();
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {
            z.Name = textName.Text;
        }

        private void textLast_TextChanged(object sender, EventArgs e)
        {
            z.LastName = textLast.Text;
        }

        private void textAddress_TextChanged(object sender, EventArgs e)
        {
            z.Adress = textAddress.Text;
        }

        private void textPerId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                z.PerIdNum = Convert.ToInt32(textPerId.Text);
            }
            catch (Exception h)
            {
                MessageBox.Show("Prosim píste len cisla");
            }

        }
        private void groupC()
        {
            foreach (var i in s)
            {
                comboGroup.Items.Add(i.Name);
            }
        }
        private void workC()
        {
            foreach (var i in w)
            {
                comboWork.Items.Add(i.Name);
            }
        }
        private void projectC()
        {
            foreach (var i in p)
            {
                comboProject.Items.Add(i.Name);
            }
        }
        private void comboSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            z.Sex = comboSex.Text;
        }

        private void comboGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           

        }

        private void comboWork_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboProject_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var i in w)
            {
                if (i.Name.Equals(comboWork.Text, StringComparison.Ordinal))
                {
                    z.WorkGroup= i.RecordId;
                    
                }
            }
            foreach (var i in p)
            {
                if (i.Name.Equals(comboProject.Text, StringComparison.Ordinal))
                {
                    z.IdProject = i.RecordId;

                }
            }
            foreach (var i in s)
            {
                if (i.Name.Equals(comboGroup.Text, StringComparison.Ordinal))
                {
                    z.Group = i.RecordId;

                }
            }
            bool vall = true;
            string a = "";
            if(z.Name.Equals(a))
            {
                meno.Text="Prosim zadajte meno";
                vall = false;
            }
            else meno.Text = "";
            if (z.LastName.Equals(a))
            {
               prie.Text="Prosim zadajte priezvisko";
                vall = false;
            }
            else prie.Text = "";
            if (z.Adress.Equals(a))
            {
                adre.Text="Prosim zadajte adresu";
                vall = false;
            }
            else adre.Text = "";
            if (z.PerIdNum == 0)
            {
                rodn.Text="Prosim zadajte rodne cislo";
                vall = false;
            }
            else rodn.Text = "";
            if (a.Equals(comboWork.Text))
            {
                work.Text="Prosim vyberte pracovisko";
                vall = false;
            }
            else work.Text = "";
            if (a.Equals(comboGroup.Text))
            {
                gru.Text="Prosim vyberte skupinu";
                vall = false;
            }
            else gru.Text = "";
            if (a.Equals(comboProject.Text))

            {
                ptoj.Text="Prosim vyberte projekt";
                vall = false;
            }
            else ptoj.Text = "";
            if (a.Equals(comboSex.Text))
            {
                pohl.Text = "Prosim vyberte pohlavie";
                vall = false;
            }
            else pohl.Text = "";
           z.Sex = comboSex.Text;
            if (vall)
            {
                ZamestnanecFactory zamestnanecFactory = new ZamestnanecFactory();
                ZamestnanecGateway<Zamestnanec> zg = (ZamestnanecGateway<Zamestnanec>)zamestnanecFactory.GetZamestnanec();
               
                zg.Insert(z);

                Close();
            }

        }

        private void FormCreateZamestnanec_Load(object sender, EventArgs e)
        {

        }
    }
}
