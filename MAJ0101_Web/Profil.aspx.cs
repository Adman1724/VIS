using Connective;
using Connective.Factory;
using Connective.Tables;
using Connective.TablesGateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MAJ0101_Web
{
    public partial class Profil : System.Web.UI.Page
    {
        Zamestnanec zamestnanec;
        
        Zamestnanec newZamestnanec;

        protected void Page_Load(object sender, EventArgs e)
        {
            ZamestnanecFactory zamestnanecFactory = new ZamestnanecFactory();
            ZamestnanecGateway<Zamestnanec> zg = (ZamestnanecGateway<Zamestnanec>)zamestnanecFactory.GetZamestnanec();

            


            if (Session["ID"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }
            zamestnanec = zg.Select_id(int.Parse((Session["ID"].ToString())));
            newZamestnanec = zamestnanec;

            nameElement.Attributes.Add("placeholder", zamestnanec.Name);
            surnameElement.Attributes.Add("placeholder", zamestnanec.LastName);
            perIdNumElement.Attributes.Add("placeholder", zamestnanec.PerIdNum.ToString());
            adressElement.Attributes.Add("placeholder", zamestnanec.Adress);
            sexElement.Attributes.Add("placeholder", zamestnanec.Sex);
            workGroupElement.Attributes.Add("placeholder", zamestnanec.WorkGroup.ToString());
            projectElement.Attributes.Add("placeholder", zamestnanec.IdProject.ToString());
            positionElemnt.Attributes.Add("placeholder", zamestnanec.Group.ToString());
            mailElement.Attributes.Add("placeholder", zamestnanec.Mail);
            password1.Attributes.Add("placeholder", "********");
            password2.Attributes.Add("placeholder", "********");
            oldPasswordElement.Attributes.Add("placeholder", "********");

            

        }

        protected void profileConfirmButton_Click1(object sender, EventArgs e)
        {
            ZamestnanecFactory zamestnanecFactory = new ZamestnanecFactory();
            ZamestnanecGateway<Zamestnanec> zg = (ZamestnanecGateway<Zamestnanec>)zamestnanecFactory.GetZamestnanec();

            bool toInsert = true;
            string errorMessage = "";
            if (!string.IsNullOrWhiteSpace(nameElement.Text))
            {
                newZamestnanec.Name = nameElement.Text;
            }
            if (!string.IsNullOrWhiteSpace(surnameElement.Text))
            {
                newZamestnanec.LastName = surnameElement.Text;
            }
            if (!string.IsNullOrWhiteSpace(mailElement.Text))
            {
                if (Functions.IsValidEmail(mailElement.Text))
                {
                    newZamestnanec.Mail = mailElement.Text;
                }
                else
                {
                    toInsert = false;
                    errorMessage = "Entered Mail is invalid.";
                }
            }
            if (!string.IsNullOrWhiteSpace(password1.Text) && !string.IsNullOrWhiteSpace(password2.Text))
            {
                if (password1.Text == password2.Text && password1.Text.Length > 5 && oldPasswordElement.Text == zamestnanec.Heslo)
                {
                    newZamestnanec.Heslo = password1.Text;
                }
                else
                {
                    errorMessage = "An error occured, password is too short or does not match.";
                    toInsert = false;
                }
            }

            if (toInsert)
            {
                zg.Update(newZamestnanec);
                Response.Redirect("~/Profile.aspx");
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('" + errorMessage + "');window.location ='ChangeProfile.aspx';", true);
            }
        }

     
    }
}