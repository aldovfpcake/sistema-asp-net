using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication1
{
    public partial class altaproveedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                Clnegocio neg = new Clnegocio();
                List<Clnegocio.lprovincias> provi = neg.ltapv();
                List<Clnegocio.LCuentas> cuentacontab = neg.ltacta();
                List<TIPOIVA> ListaTpvia = new List<TIPOIVA>();
                ListaTpvia = neg.tipoivalistar();
                
                foreach (var datos in ListaTpvia)
                {
                    ListItem item = new ListItem(datos.descrip,datos.porcen1.ToString());
                    ListaTipIva.Items.Add(item);
                      


                }



                 
                PROVIN.DataSource = provi;
                foreach (Clnegocio.lprovincias p in provi)
                {
                    ListItem item = new ListItem(p.provincia, p.id.ToString());
                    // item.Selected = p.Selected;

                    //  ProvinciasL.SelectedValue = neg.Provee.provin;
                    PROVIN.Items.Add(item);

                }
                CUIT.Text = "00-00000000-0";

                foreach (Clnegocio.LCuentas c in cuentacontab)
                {
                    ListItem item2 = new ListItem(c.cuenta, c.Descrp);

                    LISTACONTA.Items.Add(item2);
                    LISTACONTA2.Items.Add(item2);

                }

               


            }






        }

        protected void alta(object sender, EventArgs e)
        {
            Page.Validate();
                       
            Clnegocio nuevo = new Clnegocio();
            nuevo.Provee.resum = this.RESUM.Text;
            nuevo.Provee.cuenta = Int32.Parse(CUENTA.Text);
            nuevo.Provee.rsocial = RSOCIAL.Text;
            nuevo.Provee.localidad = LOCALIDAD.Text;
            nuevo.Provee.codpostal = CODPOSTAL.Text;
            nuevo.Provee.provin = PROVIN.Text;
            nuevo.Provee.cuit = CUIT.Text;
            int tpiva = Convert.ToInt32((ListaTipIva.SelectedValue.Substring(0,2)));
            nuevo.Provee.tipoiva = tpiva;
            nuevo.Provee.contab = Convert.ToString(LISTACONTA.SelectedItem);
            nuevo.Provee.contab1 =Convert.ToString( LISTACONTA2.SelectedItem);
            nuevo.Provee.calle = CALLE.Text;
            nuevo.Provee.nro = Int32.Parse(NRO.Text);
            nuevo.Provee.fechaingerso = DateTime.Parse(FECHAINGRESO.Text);
            nuevo.NuevoProv(nuevo.Provee);
            //nuevo.agregar();
            
        }


        protected void RSValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = (args.Value.Length >= 8);
        }

        protected void DescrpCuenta(object sender, EventArgs e)
        {
            
            Descta1.Text = LISTACONTA.SelectedValue;


        }
        protected void DescrpCuenta2(object sender, EventArgs e)
        {

            Descta2.Text = LISTACONTA2.SelectedValue;


        }

        protected void DescrpTipovia(object sender, EventArgs e)
        {
           


        }

        public void mensaje(String ms, Int32 tipo)
        {
     
           if (tipo == 1)
            {
                ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "alert", "alert('Registro Grabado');", true);
                mensajealta.Text = "Alta Existosa";
                mensajealta.Visible = true;

            } else
            {

               // mensajealta.Text = "Alta FALLIDA";
                //mensajealta.Visible = true;
                //  ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Insert is successfull')", true);

            }
        }


        protected void FECHAINGRESO_TextChanged(object sender, EventArgs e)
        {


        }
    }
}