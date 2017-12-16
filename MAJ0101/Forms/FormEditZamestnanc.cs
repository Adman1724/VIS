
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
    public partial class FormEditZamestnanc : Form
    {
        private Zamestnanec zamestnanec;
        private bool newRecord;
        
        public FormEditZamestnanc()
        {
            InitializeComponent();
            
        }

        private void FormUpravaZamestnanca_Load(object sender, EventArgs e)
        {

        }
       


        public  bool OpenRecord(object primaryKey)
        {
            if (primaryKey != null)
            {
                int idZamestnanca = (int)primaryKey;
                ZamestnanecFactory zamestnanecFactory = new ZamestnanecFactory();
                ZamestnanecGateway<Zamestnanec> zg = (ZamestnanecGateway<Zamestnanec>)zamestnanecFactory.GetZamestnanec();
                zamestnanec = zg.Select_id(idZamestnanca);
              
                newRecord = false;
            }
            else
            {
                zamestnanec = new Zamestnanec();
                newRecord = true;
            }
            BindData();
            return true;
        }

        private void BindData()
        {
            tmeno.Text = zamestnanec.Name;
            tpriezvisko.Text = zamestnanec.LastName;
            tadresa.Text = zamestnanec.Adress;
            trodnecislo.Text = zamestnanec.PerIdNum.ToString();
            tpohlavie.Text = zamestnanec.Sex;

        }

        private bool GetData()
        {
            zamestnanec.Name = tmeno.Text;
            zamestnanec.LastName = tpriezvisko.Text;
            zamestnanec.Adress = tadresa.Text;
            zamestnanec.PerIdNum = Int32.Parse( trodnecislo.Text);
             zamestnanec.Sex= tpohlavie.Text;
            return true;
        }

        protected  bool SaveRecord()
        {
            if (GetData())
            {
                if (newRecord)
                {
                    ZamestnanecFactory zamestnanecFactory = new ZamestnanecFactory();
                    ZamestnanecGateway<Zamestnanec> zg = (ZamestnanecGateway<Zamestnanec>)zamestnanecFactory.GetZamestnanec();
                    zg.Insert(zamestnanec);
                }
                else
                {
                    ZamestnanecFactory zamestnanecFactory = new ZamestnanecFactory();
                    ZamestnanecGateway<Zamestnanec> zg = (ZamestnanecGateway<Zamestnanec>)zamestnanecFactory.GetZamestnanec();
                   zg.Update(zamestnanec);
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SaveRecord())
            {
               Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAddProject a = new FormAddProject();
            a.OpenRecord(zamestnanec.RecordId);
            a.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
