using Connective.Factory;
using Connective.Tables;
using Connective.TablesGateway;
using Connective.XMLGateway;
using MAJ0101.Forms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MAJ0101
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Forms.Login form = new Forms.Login();
            form.ShowDialog();
        }

        private void upravaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAktualny_stav a = new FormAktualny_stav();
            a.MdiParent = this;
            a.Show();
        }

        private void dochadzkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAttendance a = new FormAttendance();
            a.MdiParent = this;
            a.Show();
        }

        private void upravaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormEmpList a = new FormEmpList();
            a.MdiParent = this;
            a.Show();
        }

        private void pridanieToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCreateZamestnanec a = new FormCreateZamestnanec();
            a.Show();
        }

        private void pridanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateProject a = new FormCreateProject();
            
            a.Show();
        }

        private void backupHardwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XDocument xDoc = new XDocument();
            XElement xRoot = new XElement("Database");

            HardwareFactory hardwareFactory = new HardwareFactory();
            HardwareGateway<Hardware> hg = (HardwareGateway<Hardware>)hardwareFactory.GetHardware();

            Collection<Hardware> hardwares = hg.Select();
            XElement xHardwares = new XElement("Hardware");

            foreach (var hardware in hardwares)
            {
                xHardwares.Add(HardwareXMLGateway<Hardware>.Instance.Insert(hardware));
            }
            
            xRoot.Add(xHardwares);


           xDoc.Add(xRoot);
            if (!Directory.Exists(Connective.XMLGateway.Paths.FolderPath))
            {
                Directory.CreateDirectory(Connective.XMLGateway.Paths.FolderPath);
            }

            using (StreamWriter sw = new StreamWriter(Connective.XMLGateway.Paths.FilePath))
            {
                sw.Write(xDoc.ToString());
            }

            MessageBox.Show("Backed up!");
        }

    }
}
