using System;
using System.Collections.Generic;
using Gtk;
using Nomina.Datos;

namespace Nomina
{
    public partial class Visualizar_Pago : Gtk.Window
    {
        public Visualizar_Pago() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            llenarTreeviewEmpleado();
        }

        ListStore lsEmpleado = new ListStore(typeof(String), typeof(String), typeof(String), typeof(String), typeof(String), typeof(String), typeof(String));
        ListStore lsPago = new ListStore(typeof(String), typeof(String), typeof(String), typeof(String));

        //Método para llenar treeview
        public void llenarTreeviewEmpleado()
        {
            DTEmpleado dta = new DTEmpleado();
            List<Nomina.Entidades.Empleado> lista = new List<Nomina.Entidades.Empleado>();
            lista = dta.ListarEmpleado();

            foreach (Nomina.Entidades.Empleado a in lista)
            {
                lsEmpleado.AppendValues(a.IdEmpleado.ToString(), a.Nombre.ToString(), a.Apellidos.ToString(), a.Cedula.ToString(), a.SalarioEmpleado.ToString(), a.Fecha_contratacion.ToString(), a.Direccion.ToString());
            }

            //Crear el modelo de datos
            trvEmpleado.Model = lsEmpleado;

            trvEmpleado.AppendColumn("ID", new CellRendererText(), "text", 0);
            trvEmpleado.AppendColumn("Nombre", new CellRendererText(), "text", 1);
            trvEmpleado.AppendColumn("Apellido", new CellRendererText(), "text", 2);
            trvEmpleado.AppendColumn("Cedula", new CellRendererText(), "text", 3);
            trvEmpleado.AppendColumn("Salario C$", new CellRendererText(), "text", 4);
            trvEmpleado.AppendColumn("Fecha Contratacion", new CellRendererText(), "text", 5);
            trvEmpleado.AppendColumn("Direccion", new CellRendererText(), "text", 6);
        }

        //Metodo para llenar TreeView Pago
        public void llenarTreeviewPago(Int32 idPago)
        {
            int existe = 0;
            DTPago dta = new DTPago();
            List<Nomina.Entidades.Pago> lista = new List<Nomina.Entidades.Pago>();
            lista = dta.ListarPago();

            foreach (Nomina.Entidades.Pago a in lista)
            {
                if(idPago == a.IdEmpleado)
                {
                    lsPago.AppendValues(a.IdPago.ToString(), a.IdEmpleado.ToString(), a.IdMoneda.ToString(), a.Fecha_pago.ToString());
                    existe = 1;
                }

            }

            //Crear el modelo de datos
            trvPagos.Model = lsPago;


            trvPagos.AppendColumn("Id Pago", new CellRendererText(), "text", 0); 
            trvPagos.AppendColumn("Id Empleado", new CellRendererText(), "text", 1);
            trvPagos.AppendColumn("Id Moneda", new CellRendererText(), "text", 2);
            trvPagos.AppendColumn("Fecha Pago", new CellRendererText(), "text", 3);



        }

        //Método para recargar TreeView
        public void recargarTreeViewPago()
        {
            TreeViewColumn[] listColumns;
            listColumns = trvPagos.Columns;
            foreach (TreeViewColumn tvc in listColumns)
            {
                trvPagos.RemoveColumn(tvc);
            }
            lsPago.Clear();
        }

        protected void OnTrvEmpleadoRowActivated(object o, RowActivatedArgs args)
        {


            var model = trvEmpleado.Model;
            TreeIter iter;

            model.GetIter(out iter, args.Path);

            var id = model.GetValue(iter, 0);
            var nombre = model.GetValue(iter, 1);

            this.txtIDEmpleado.Text = Convert.ToString(id);
            this.txtNombre.Text = Convert.ToString(nombre);

            Int32 idempleado = Convert.ToInt32(txtIDEmpleado.Text);

            recargarTreeViewPago();
            llenarTreeviewPago(idempleado);


        }

    }
}
