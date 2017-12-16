using MAJ0101.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAJ0101
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
