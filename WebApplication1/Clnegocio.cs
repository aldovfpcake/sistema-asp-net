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
            Obprov.resum = "Pinturas El ";
            Obprov.rsocial = " EL PINTURAS S.A.C.";
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
            var listado = queryAllprovee.ToList();

            foreach (var tulist in listado){
                lista.Add(tulist.cuit);

            }


            

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


    }
}