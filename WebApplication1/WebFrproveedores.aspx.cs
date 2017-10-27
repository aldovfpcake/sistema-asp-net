using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebFrproveedores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Clnegocio nego = new Clnegocio();
            List<Proveedor> listado = new List<Proveedor>();
            listado = nego.lg();

            GridView1.DataSource = listado;
            GridView1.DataBind();




        }
    }
}