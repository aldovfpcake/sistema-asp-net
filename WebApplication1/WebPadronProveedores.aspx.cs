using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebPadronProveedores : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Model2 dba = new Model2();
            var queryAllprovee = from provee in dba.Proveedor
                                 select provee;
            var listado = queryAllprovee.ToList();

            if (!this.IsPostBack)
            {
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[3] { new DataColumn("Id", typeof(int)),
                            new DataColumn("cuit", typeof(String)),
                            new DataColumn("resum",typeof(string)) });

                
                foreach (var tulist in listado)
                {
                    dt.Rows.Add(tulist.ID, tulist.cuit, tulist.resum);
                }

                GridView1.DataSource = dt;
                GridView1.DataBind();

            } 


            }

        protected void prueba(object sender, EventArgs e)
        {
            Clnegocio cl = new Clnegocio();
            cl.agregar();
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label3.Text = GridView1.SelectedRow.Cells[3].Text;
            

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
           

            if (e.CommandName == "AddToCart")
            {
                Int32 nRowIndex = Convert.ToInt32(e.CommandArgument.ToString());
                String txt = " ";
                txt = GridView1.SelectedValue.ToString();

                Label1.Text = "Command Name: " + e.CommandName;
                Label2.Text = "Row Index: " + nRowIndex;
                 
            }

           }

        protected void Select(object sender, EventArgs e)
        {
            string rowIndex = (sender as Button).CommandArgument;
            int fila = Int32.Parse(rowIndex);
             ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('Row Index: " + rowIndex + "');", true);
        }






    }
}