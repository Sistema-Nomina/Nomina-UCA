using System;
using System.Collections.Generic;
using Gtk;
using Nomina.Datos;

namespace Nomina
{
    public partial class Detalle_Empleado : Gtk.Window
    {
        public Detalle_Empleado() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            //llenarTreeviewPago(Convert.ToInt32(txtNombre.Text));
        }

        ListStore lsPago = new ListStore(typeof(String), typeof(String), typeof(String), typeof(String));

        public void llenarTreeviewPago(Int32 idPago)
        {
            DTPago dta = new DTPago();
            List<Nomina.Entidades.Pago> lista = new List<Nomina.Entidades.Pago>();
            lista = dta.ListarPago();

            foreach (Nomina.Entidades.Pago a in lista)
            {
                if (idPago == a.IdEmpleado)
                {
                    lsPago.AppendValues(a.IdPago.ToString(), a.IdEmpleado.ToString(), a.IdMoneda.ToString(), a.Fecha_pago.ToString());

                }

            }

            //Crear el modelo de datos
            trvPagos.Model = lsPago;


            trvPagos.AppendColumn("Id Pago", new CellRendererText(), "text", 0);
            trvPagos.AppendColumn("Id Empleado", new CellRendererText(), "text", 1);
            trvPagos.AppendColumn("Id Moneda", new CellRendererText(), "text", 2);
            trvPagos.AppendColumn("Fecha Pago", new CellRendererText(), "text", 3);



        }
    }
}
