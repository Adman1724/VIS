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
    public partial class List : System.Web.UI.Page
    {
        Neschopenka nesch= new Neschopenka();
        public DateTime selectedDate;
        protected void Page_Load(object sender, EventArgs e)
        {
            ZamestnanecFactory zamestnanecFactory = new ZamestnanecFactory();
            ZamestnanecGateway<Zamestnanec> zg = (ZamestnanecGateway<Zamestnanec>)zamestnanecFactory.GetZamestnanec();
             
             Zamestnanec zamestnanec = zg.Select_id(int.Parse((Session["ID"].ToString())));
           
            NepritomnostFactory nepritomnostFactory = new NepritomnostFactory();
            NepritomnostGateway<Nepritomnost> ng = (NepritomnostGateway<Nepritomnost>)nepritomnostFactory.GetNepritomnost();
            Collection<Nepritomnost> nepritomnost = ng.Select_id_zam(zamestnanec.RecordId);
            Collection<DateTime> datesick1 = new Collection<DateTime>();
            
            Collection<Active> datasick = new Collection<Active>();
            NeschopenkaFactory neschopenkaFactory = new NeschopenkaFactory();
            NeschopenkaGateway<Neschopenka> ne = (NeschopenkaGateway<Neschopenka>)neschopenkaFactory.GetNeschopenka();
            Collection<Neschopenka> za = ne.Select();
            foreach (var i in nepritomnost)
            {
               
                foreach(var a in za)
                {
                    if (a.Nepritomnost == i.RecordId)
                    {
                        datasick.Add(new Active(i.Datum, "Send"));

                    }
                    else { datasick.Add(new Active(i.Datum, "Nothing"));
                        datesick1.Add(i.Datum);
                    }

                }


            }
            if (!IsPostBack)
            {
              
               
                    GridView1.DataSource = datasick;
                    GridView1.DataBind();
                DropDownList1.DataSource = datesick1;
                DropDownList1.DataBind();

            }
          

        }
        protected void uploadButton_Click1(object sender, EventArgs e)
        {
            ZamestnanecFactory zamestnanecFactory = new ZamestnanecFactory();
            ZamestnanecGateway<Zamestnanec> zg = (ZamestnanecGateway<Zamestnanec>)zamestnanecFactory.GetZamestnanec();
            Zamestnanec zamestnanec = zg.Select_id(int.Parse((Session["ID"].ToString())));
            NepritomnostFactory nepritomnostFactory = new NepritomnostFactory();
            NepritomnostGateway<Nepritomnost> ng = (NepritomnostGateway<Nepritomnost>)nepritomnostFactory.GetNepritomnost();
            Collection<Nepritomnost> nepritomnost = ng.Select_id_zam(zamestnanec.RecordId);
            foreach (Nepritomnost h in nepritomnost)
            {

                if (h.Datum.ToString()== DropDownList1.SelectedItem.ToString())
                {
                    nesch.Nepritomnost = h.RecordId;

                }

            }
            NeschopenkaFactory neschopenkaFactory = new NeschopenkaFactory();
            NeschopenkaGateway<Neschopenka> ne = (NeschopenkaGateway<Neschopenka>)neschopenkaFactory.GetNeschopenka();
            Collection<Neschopenka> za = ne.Select();

            int id = 0;
            foreach (var nep in za)
            {
                if (nep.RecordId > id)
                {
                    id = nep.RecordId;

                }
            }
            id++;

            nesch.Text = TextBox1.Text.ToString();
            nesch.Datum = DateTime.Now;
            ne.Insert(nesch);


        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                
                e.Row.Cells[0].Text = "Date";
                e.Row.Cells[1].Text = "Status";

            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gr = GridView1.SelectedRow;
            Console.WriteLine(gr.Cells[1].Text);
            
            
            
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            
            
                

            
        }
    }
}