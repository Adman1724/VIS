
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
    public partial class FormAddProject : Form
    {
        private Zamestnanec zamestnanec;
        Collection<Projekt> p;
        
        public FormAddProject()
        {
            ProjektFactory projektFactory = new ProjektFactory();
            ProjektGateway<Projekt> prg = (ProjektGateway<Projekt>)projektFactory.GetProjekt();
            p = prg.Select();
            InitializeComponent();
            loadProject();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                SaveRecord();
                Close();
            }
        }
        public void OpenRecord(object primaryKey)
        {
            if (primaryKey != null)
            {
                int idZamestnanca = (int)primaryKey;
                ZamestnanecFactory zamestnanecFactory = new ZamestnanecFactory();
                ZamestnanecGateway<Zamestnanec> zg = (ZamestnanecGateway<Zamestnanec>)zamestnanecFactory.GetZamestnanec();
                zamestnanec = zg.Select_id(idZamestnanca);
                
                
            }
            else
            {
                zamestnanec = new Zamestnanec();
                
            }
            
            
        }
        public void loadProject()
        {
            
            foreach (var i in p)
            {
                projektCombo.Items.Add(i.Name);


            }
        }
 

        protected void SaveRecord()
        {
            foreach(var i in p)
            {
                if(i.Name.Equals(projektCombo.Text, StringComparison.Ordinal))
                {
                    zamestnanec.IdProject = i.RecordId;
                    ZamestnanecFactory zamestnanecFactory = new ZamestnanecFactory();
                    ZamestnanecGateway<Zamestnanec> zg = (ZamestnanecGateway<Zamestnanec>)zamestnanecFactory.GetZamestnanec();
                    zg.Update(zamestnanec);
                }
            }
            
        }

       

        private void FormAddProject_Load(object sender, EventArgs e)
        {

        }
    }
}
