using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Connective.Tables;
using Connective.TablesGateway;
using Connective.Factory;
using Connective;

namespace MAJ0101_Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["ID"] = null;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ZamestnanecFactory zamestnanecFactory = new ZamestnanecFactory();
            ZamestnanecGateway<Zamestnanec> zg = (ZamestnanecGateway<Zamestnanec>)zamestnanecFactory.GetZamestnanec();

            string login = String.Format("{0}", Request.Form["loginInput"]);
            string password = String.Format("{0}", Request.Form["passwordInput"]);

            Zamestnanec zamestnanec = new Zamestnanec();
            zamestnanec.Heslo = password;
            zamestnanec.Mail = login;
            if (string.IsNullOrWhiteSpace(login))
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('No mail was entered');window.location ='ChangeProfile.aspx';", true);
            }
            else if (!Functions.IsValidEmail(login))
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('You entered non-valid email address');window.location ='ChangeProfile.aspx';", true);
            }
            else if (string.IsNullOrWhiteSpace(password))
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('You entered non-valid password');window.location ='ChangeProfile.aspx';", true);
            }
            else
            {
                Zamestnanec za = zg.CheckPassword(zamestnanec);
                if (za != null)
                {
                    Session["ID"] = za.RecordId;
                    Session["login"] = za.Mail;
                    Response.Redirect("~/Home.aspx");
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Wrong credentials!');window.location ='ChangeProfile.aspx';", true);
                }
            }
        }
    }
}