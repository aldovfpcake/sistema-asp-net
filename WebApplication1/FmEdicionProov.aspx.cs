using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class FmEdicionProov : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {
            if (!IsPostBack)
            {
                string v = Request.QueryString["id"];
                if (v != null)
                {

                    Clnegocio neg = new Clnegocio();
                    neg.buscar(v);
                    Response.Write(neg.Provee.resum);
                    TextResum.Text = neg.Provee.resum;
                    TextRsocial.Text = neg.Provee.rsocial;
                    TextLocalidad.Text = neg.Provee.localidad;
                    TextCodPostal.Text = neg.Provee.codpostal;
                    List<Clnegocio.lprovincias> provi = neg.ltapv();
                    //ddl.DataTextField = "Name";
                    // ddl.DataValueField = "Id";
                    //ddl.DataSource = people;
                    // ddl.DataBind();

                    // ProvinciasL.DataTextField = lis.;
                    // foreach (List li in lis.Count)
                    //{
                    //   li.Selected = false;
                    //                  }
                    // ProvinciasL.DataTextField = provi[0].id.ToString();
                    // ProvinciasL.DataValueField ="xxxxxx" ;
                    // ProvinciasL.DataSource =provi;
                    ProvinciasL.Text = "dsdsdws";
                  //  ProvinciasL.SelectedValue = "xxxxxx";
                    
                    foreach (Clnegocio.lprovincias p in provi)
                    {
                        ListItem item = new ListItem(p.provincia,p.id.ToString());
                        // item.Selected = p.Selected;
                       
                      //  ProvinciasL.SelectedValue = neg.Provee.provin;
                        ProvinciasL.Items.Add(item);
                        
                    }




                  //  ProvinciasL.DataBind();


                }



            }

        }




        protected void prueba(object sender, EventArgs e)
        {
            Response.Write("Prueba de Evento");
            Clnegocio nuevo = new Clnegocio();
            nuevo.Provee.resum = TextResum.Text;
            nuevo.Provee.rsocial = TextRsocial.Text;

            nuevo.NuevoProv(nuevo.Provee);
        }




    }


    }

    


