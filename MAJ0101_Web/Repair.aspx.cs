using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Connective;
using Connective.Factory;
using Connective.Tables;
using Connective.TablesGateway;
using System.Collections.ObjectModel;

namespace MAJ0101_Web
{
    public partial class Repair : System.Web.UI.Page
    {
        Porucha p = new Porucha();
        Collection<Hardware> hc = new Collection<Hardware>();


        protected void Page_Load(object sender, EventArgs e)
        {
            HardwareFactory hardwareFactory = new HardwareFactory();


            hc = hardwareFactory.GetHardware().Select();
            Collection<string> hardwareStrings = new Collection<string>();
            foreach (Hardware h in hc)
            {
                hardwareStrings.Add(h.Name);
            }

            if (!IsPostBack)
            {
               hardwareElement.DataSource = hardwareStrings;
                hardwareElement.DataBind();
            }

        }
        protected void uploadButton_Click1(object sender, EventArgs e) {
            
            foreach(Hardware h in hc)
            {

                if (h.Name == hardwareElement.SelectedItem.ToString())
                {
                    p.IdHardware = h.RecordId;

                }

            }
            p.Text = textReport.Text.ToString();
            DateTime d = DateTime.Now;
            p.Date = d;
            p.repair = false;
            PoruchaFactory poruchaFactory = new PoruchaFactory();
            PoruchaGateway<Porucha> pg = (PoruchaGateway<Porucha>)poruchaFactory.GetPorucha();
            pg.Insert(p);
            Response.Redirect("~/Home.aspx");

        }
    }
}