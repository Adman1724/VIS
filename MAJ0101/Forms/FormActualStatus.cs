
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
    public partial class FormAktualny_stav : Form
    {

        Collection<Zamestnanec> zamestananec;

        Collection<Pracovisko> pracovisko;
        public FormAktualny_stav()
        {
            ZamestnanecFactory zamestnanecFactory = new ZamestnanecFactory();
            ZamestnanecGateway<Zamestnanec> zg = (ZamestnanecGateway<Zamestnanec>)zamestnanecFactory.GetZamestnanec();
            zamestananec = zg.Select();
            
            InitializeComponent();
            pracoviskoCombo_Load();
        
        }
        public void show()
        {
            string a;



            Collection<Active> active = new Collection<Active>();
            foreach (var i in pracovisko)
            {
                if (i.Name.Equals(pracoviskoCombo.Text, StringComparison.Ordinal))
                {
                    ZamestnanecFactory zamestnanecFactory = new ZamestnanecFactory();
                    ZamestnanecGateway<Zamestnanec> zg = (ZamestnanecGateway<Zamestnanec>)zamestnanecFactory.GetZamestnanec();
                    a = zg.AktualnePritomny(i.RecordId, null);


                    string[] words = a.Split(';');
                    foreach (var word in words)
                    {
                        string[] words2 = word.Split(',');
                        int counter = 0;
                        bool b = false;
                        Active t = new Active();
                        foreach (var word1 in words2)
                        {
                            if (counter == 0)
                            {
                                t.Name = word1;
                            }
                            if (counter == 1)
                            {
                                t.Surname = word1;
                            }
                            if (counter == 2)
                            {
                                t.State = word1;
                                b = true;
                            }

                            counter++;
                        }
                        if (b) active.Add(t);
                    }

                }


            }
            BindingList<Active> Bactive = new BindingList<Active>(active);
            gridAktivita.AutoGenerateColumns = false;
            gridAktivita.DataSource = Bactive;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Active t = GetSelectedData();
            if (t != null)
            {
                FormEditZamestnanc c = new FormEditZamestnanc();



                foreach (var i in zamestananec)
                {

                    if (t.Name.Equals(i.Name, StringComparison.Ordinal) && t.Surname.Equals(i.LastName, StringComparison.Ordinal))
                    {

                        if (c.OpenRecord(i.RecordId))
                        {
                            c.Show();

                        }
                        break;
                    }



                }
            }
            else MessageBox.Show("Choose dates!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void pracoviskoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {



        }
        private void pracoviskoCombo_Load()
        {

            PracoviskoFactory pracoviskoFactory = new PracoviskoFactory();
            PracoviskoGateway<Pracovisko> pg = (PracoviskoGateway<Pracovisko>)pracoviskoFactory.GetPracovisko();
            pracovisko = pg.Select();
            foreach (var i in pracovisko)
            {
                pracoviskoCombo.Items.Add(i.Name);
                

            }
           
        }

        private void stav_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gridAktivita_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Active t = GetSelectedData();
            foreach (var i in zamestananec)
            {
                if (t.Name.Equals(i.Name, StringComparison.Ordinal) && t.Surname.Equals(i.LastName, StringComparison.Ordinal))
                {
                    info.Text = "Meno: " + i.Name + "\n" + "Prievisko: " + i.LastName + "\n" + "Rodne cislo: " + i.PerIdNum + "\n" + "Bydlisko: " + i.Adress + "\n" + "Pohlavie: " + i.Sex;
                }

            }


        }
        private Active GetSelectedData()
        {
            if (gridAktivita.SelectedRows.Count == 1)
            {
                Active t = gridAktivita.SelectedRows[0].DataBoundItem as Active;
                return t;
            }
            else
            {
                return null;
            }
        }

        private void gridAktivita_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ZamestnanecFactory zamestnanecFactory = new ZamestnanecFactory();
            ZamestnanecGateway<Zamestnanec> zg = (ZamestnanecGateway<Zamestnanec>)zamestnanecFactory.GetZamestnanec();
            zamestananec = zg.Select();
            Active t = GetSelectedData();
            foreach (var i in zamestananec)
            {
                if (t.Name.Equals(i.Name, StringComparison.Ordinal) && t.Surname.Equals(i.LastName, StringComparison.Ordinal))
                {
                    info.Text = "Meno: " + i.Name + "\n" + "Prievisko: " + i.LastName + "\n" + "Rodne cislo: " + i.PerIdNum + "\n" + "Bydlisko: " + i.Adress + "\n" + "Pohlavie: " + i.Sex;
                }

            }

        }

        private void vytvorit_Click(object sender, EventArgs e)
        {
            FormCreateZamestnanec a = new FormCreateZamestnanec();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormCreateProject a = new FormCreateProject();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pracoviskoCombo.Text != null) { 
            FormReportError a = new FormReportError();
            foreach (var i in pracovisko)
            {
                if (i.Name.Equals(pracoviskoCombo.Text, StringComparison.Ordinal))
                {
                    a.loadHardware(i.RecordId);
                    break;
                }
            }
            a.Show();
        }
        else MessageBox.Show("Choose dates!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void gridAktivita_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridAktivita.Columns[e.ColumnIndex].Name == "Pritomny")
            {
                ZamestnanecFactory zamestnanecFactory = new ZamestnanecFactory();
                ZamestnanecGateway<Zamestnanec> zg = (ZamestnanecGateway<Zamestnanec>)zamestnanecFactory.GetZamestnanec();
                zamestananec = zg.Select();
                Active t = GetSelectedData();
                DateTime date1= DateTime.Now;

                foreach (var i in zamestananec)
                {   
                    if (t.Name.Equals(i.Name, StringComparison.Ordinal) && t.Surname.Equals(i.LastName, StringComparison.Ordinal))
                    {
                        Historia_pristupuFactory historia_pristupuFactory = new Historia_pristupuFactory();
                        Historia_pristupuGateway<Historia_pristupu> hg = (Historia_pristupuGateway<Historia_pristupu>)historia_pristupuFactory.GetHistoria_pristupu();
                        Historia_pristupu h = new Historia_pristupu(date1, i.RecordId, 37);
                        hg.Insert(h);
                        show();

                    }

                }

            }

        }

        private void FormAktualny_stav_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string a;



            Collection<Active> active = new Collection<Active>();
            foreach (var i in pracovisko)
            {
                if (i.Name.Equals(pracoviskoCombo.Text, StringComparison.Ordinal))
                {
                    ZamestnanecFactory zamestnanecFactory = new ZamestnanecFactory();
                    ZamestnanecGateway<Zamestnanec> zg = (ZamestnanecGateway<Zamestnanec>)zamestnanecFactory.GetZamestnanec();
                    a = zg.AktualnePritomny(i.RecordId, null);


                    string[] words = a.Split(';');
                    foreach (var word in words)
                    {
                        string[] words2 = word.Split(',');
                        int counter = 0;
                        bool b = false;
                        Active t = new Active();
                        foreach (var word1 in words2)
                        {
                            if (counter == 0)
                            {
                                t.Name = word1;
                            }
                            if (counter == 1)
                            {
                                t.Surname = word1;
                            }
                            if (counter == 2)
                            {
                                t.State = word1;
                                if (t.State == "Nepritomny")
                                {
                                    NepritomnostFactory nepritomnostFactory = new NepritomnostFactory();
                                    NepritomnostGateway<Nepritomnost> ng = (NepritomnostGateway<Nepritomnost>)nepritomnostFactory.GetNepritomnost();
                                    Zamestnanec z=zg.Select_name(t.Name, t.Surname);
                                    Collection<Nepritomnost> za = ng.Select();
                                    
                                    int id = 0;
                                    foreach(var nep in za)
                                    {
                                        if (nep.RecordId > id)
                                        {
                                            id = nep.RecordId;

                                        }
                                    }
                                    id++;
                                    Nepritomnost n = new Nepritomnost(id,z.RecordId, DateTime.Now);
                                    ng.Insert(n);
                                }
                                b = true;
                            }

                            counter++;
                        }
                        if (b) active.Add(t);
                    }

                }


            }
           

        }
    }
}
