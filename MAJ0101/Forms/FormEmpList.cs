
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
    public partial class FormEmpList : Form
    {
        Collection<Zamestnanec> z;
        
        public FormEmpList()
        {
            ZamestnanecFactory zamestnanecFactory = new ZamestnanecFactory();
            ZamestnanecGateway<Zamestnanec> zg = (ZamestnanecGateway<Zamestnanec>)zamestnanecFactory.GetZamestnanec();
            z = zg.Select();
            InitializeComponent();
            loadList();
        }

        private void loadList()
        {
            BindingList<Zamestnanec> Bactive = new BindingList<Zamestnanec>(z);
            gridZamestnanec.AutoGenerateColumns = false;
            gridZamestnanec.DataSource = Bactive;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private Zamestnanec GetSelectedData()
        {
            if (gridZamestnanec.SelectedRows.Count == 1)
            {
                Zamestnanec t = gridZamestnanec.SelectedRows[0].DataBoundItem as Zamestnanec;
                return t;
            }
            else
            {
                return null;
            }
        }


        private void gridZamestnanec_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FormEditZamestnanc c = new FormEditZamestnanc();

            Zamestnanec t = GetSelectedData();
            foreach (var i in z)
            {
                if (t.Name.Equals(i.Name, StringComparison.Ordinal) && t.LastName.Equals(i.LastName, StringComparison.Ordinal))
                {

                    if (c.OpenRecord(i.RecordId))
                    {
                        c.Show();

                    }
                    break;
                }

            }

        }
    }
}
