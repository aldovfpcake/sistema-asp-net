using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Clnegocio
    {
        public List<string> lista = new List<string>();
        public List<Proveedor> listpro  = new List<Proveedor>();
        public Proveedor Provee = new Proveedor();
        public TIPOIVA Tipoiv = new TIPOIVA();
        public List<lprovincias> lnvc  = new List<lprovincias>();
        public List<LCuentas> lcuentas = new List<LCuentas>();
        public TIPOIVA tipodeiva = new TIPOIVA();
        public List<TIPOIVA> tipoivalst = new List<TIPOIVA>();        
          
        public void agregar()
        {
            Model2 db = new Model2();
            Proveedor Obprov = new Proveedor();
            Obprov.localidad = "Capital Federal";
            Obprov.calle = "HIPOLITO YRIGOYEN";
            Obprov.codpostal = "9855";
            Obprov.contab = "511150200";
            Obprov.contab1 = "211010400";
            int cuenta = 1416;
            Obprov.cuenta = cuenta;
            Obprov.cuit = "20-25231118-9";
            Obprov.nro = cuenta;
            Obprov.provin = "Capital Federal";
            Obprov.resum = "TSANCHEZ ";
            Obprov.rsocial = " TRANSPORTES SANCHEZ S.A.C.I.";
            String idate = "23/10/2017";
            DateTime fec = Convert.ToDateTime(idate);
            Obprov.fechaingerso = fec;
            int tipoiva = 1;
            Obprov.tipoiva = tipoiva;
            db.Proveedor.Add(Obprov);
            db.SaveChanges();
            

        }

        public void listar()
        {

            Model2 dba = new Model2();
            var queryAllprovee = from provee in dba.Proveedor
                                    select provee;
              listpro = queryAllprovee.ToList();

            foreach (var tulist in listpro){
                lista.Add(tulist.cuit);

            }
                               
        }

        public List<TIPOIVA> tipoivalistar()
        {
            Model4 dba = new Model4();
            var queryAlltpiva = from TIPOIVA in dba.TIPOIVA
                                select TIPOIVA;
            tipoivalst = queryAlltpiva.ToList();
            return tipoivalst;


        }



        public void buscar(String id)
        {
            Int32 idnu = int.Parse(id);
            Model2 db2 = new Model2();
          
            //Pro = from p in db2.Proveedor where p.ID ==idnu
            //    select p;//

            var pro =( from pr in db2.Proveedor
                      where pr.ID == idnu select pr).First();

            Provee = pro;

              }


        public List<Proveedor> lg()
        {
            listar();
            return listpro;
        }

        public class lprovincias
        {
          public  int id;
          public  String provincia;
        }

        public class LCuentas
        {
            public String cuenta;
            public String Descrp;
        }



        public List<lprovincias> ltapv()
      {
            lprovincias Pv = new lprovincias();
            Pv.id = 1;
            Pv.provincia = "Buenos Aires";
            lnvc.Add(Pv);

            lprovincias Pv1 = new lprovincias();
            Pv1.id = 1;
            Pv1.provincia = "Cordoba";
            lnvc.Add(Pv1);

            lprovincias Pv2 = new lprovincias();
            Pv2.id = 1;
            Pv2.provincia = "Capital Federal";
            lnvc.Add(Pv2);
            return lnvc;



        }

        public void NuevoProv(Proveedor ob)
        {
            altaproveedor fm = new altaproveedor();
            Model2 Newpro = new Model2();
            String mesnj = " ";
            Int32 tipo = 0;
            Newpro.Proveedor.Add(ob);
            
            try
            {
                Newpro.SaveChanges();
                tipo = 1;
                mesnj = "Alta Satsifactoria";
                fm.mensaje(mesnj, tipo);
            }
            catch (Exception ex)
            {
                tipo = 2;
                fm.mensaje(ex.Message, tipo);   
                
            }





        }

        public List<LCuentas> ltacta()
        {
            LCuentas lcta = new LCuentas();
            lcta.cuenta = "211010400";
            lcta.Descrp = "PROVEEDORES";
            lcuentas.Add(lcta);
            LCuentas lcta1 = new LCuentas();
            lcta1.cuenta = "511150200 ";
            lcta1.Descrp = "LIQ.FLET TELEFONICA";
            lcuentas.Add(lcta1);
            return lcuentas;
        }


        public void AgegaTipoIva()
        {

            Model4 db = new Model4();
            TIPOIVA Obtipo = new TIPOIVA();
            Obtipo.tipoiva1 = 6;
            Obtipo.descrip = "IVA INSCRIP.21 %";
            Obtipo.abrevia = "INSC ";
            Obtipo.porcen1 = 21;
            Obtipo.porcen2 = 0;
            Obtipo.cuenta1 = "113040900 ";
            Obtipo.cuenta2 = "000";
            Obtipo.abc = "A";
            db.TIPOIVA.Add(Obtipo);
            db.SaveChanges();





        }








    }

    
}