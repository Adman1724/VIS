using System;
using System.Windows.Forms;
using Connective;
using Connective.Tables;
using Connective.TablesGateway;
using Connective.Factory;

namespace MAJ0101.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }


        private void acceptButton_Click(object sender, EventArgs e)
        {
            Zamestnanec zamestnanec = new Zamestnanec(0, mailInput.Text, passwordInput.Text);
            ZamestnanecFactory zamestnanecFactory = new ZamestnanecFactory();
            ZamestnanecGateway<Zamestnanec> zg = (ZamestnanecGateway<Zamestnanec>)zamestnanecFactory.GetZamestnanec();
            Zamestnanec zam;
            if (Functions.IsValidEmail(mailInput.Text))
            {
                if (passwordInput.Text.Length > 5)
                {
                    zam = zg.CheckPassword(zamestnanec);
                    if (zg.CheckPassword(zamestnanec)!=null)
                    {
                        if (zam.Group == 12) { this.Dispose(); }
                        else
                        {
                            MessageBox.Show("You have not  permission!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("You enetered wrong credentials, try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Password is too short!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("You entered invalid mail address!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit application?", "Login",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
