using Connective.Factory;
using Connective.Tables;
using Connective.TablesGateway;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MAJ0101_Web
{
    public partial class Sick : System.Web.UI.Page
    {
        Collection<SickNote> datasick;
        protected void Page_Load(object sender, EventArgs e)
        {
              ZamestnanecFactory zamestnanecFactory = new ZamestnanecFactory();
            ZamestnanecGateway<Zamestnanec> zg = (ZamestnanecGateway<Zamestnanec>)zamestnanecFactory.GetZamestnanec();
             
             Zamestnanec zamestnanec = zg.Select_id(int.Parse((Session["ID"].ToString())));
           
            NepritomnostFactory nepritomnostFactory = new NepritomnostFactory();
            NepritomnostGateway<Nepritomnost> ng = (NepritomnostGateway<Nepritomnost>)nepritomnostFactory.GetNepritomnost();
            Collection<Nepritomnost> nepritomnost = ng.Select_id_zam(zamestnanec.RecordId);


            datasick = new Collection<SickNote>();
            NeschopenkaFactory neschopenkaFactory = new NeschopenkaFactory();
            NeschopenkaGateway<Neschopenka> ne = (NeschopenkaGateway<Neschopenka>)neschopenkaFactory.GetNeschopenka();
            Collection<Neschopenka> za = ne.Select();
            foreach (var i in nepritomnost)
            {
                
                
                    foreach (var a in za)
                    {
                        if (a.Nepritomnost == i.RecordId)
                        {
                            datasick.Add(new SickNote(i.Datum,a.Datum,a.Text));

                        }
                       

                    
                }


            }
            if (!IsPostBack)
            {
              
               
                    GridView2.DataSource = datasick;
                    GridView2.DataBind();
               

            }
        }
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            
        }

        protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {

                e.Row.Cells[0].Text = "Date sick";
                e.Row.Cells[1].Text = "Date send";
                e.Row.Cells[2].Text = "Text";

            }
        }
    }
}