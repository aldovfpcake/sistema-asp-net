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

            string v = Request.QueryString["id"];
            if (v != null)
            {
                Response.Write("param is ");
                Response.Write(v);
                Clnegocio neg = new Clnegocio();
                neg.buscar(v);
                Response.Write(neg.Provee.resum);
                TextResum.Text = neg.Provee.resum;

            }

            if (IsPostBack)
            {
                Response.Write("Operacion Costosa");

            } else { Response.Write("Operacion nomral");}

        }


        protected void prueba(object sender, EventArgs e)
        {
            Response.Write("Prueba de Evento");

        }




    }

    


}