using System;
using System.Collections.Generic;
using Gtk;
using Nomina.Datos;
using Nomina.Utilidades;

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
        ListStore lsPago = new ListStore(typeof(String), typeof(String), typeof(String), typeof(String), typeof(String));
        ListStore lsPago_Extras = new ListStore(typeof(String), typeof(String), typeof(String), typeof(String));
        ListStore lsPago_Deducciones = new ListStore(typeof(String), typeof(String), typeof(String), typeof(String));
        private double _extraMonto = 0;
        private double _deduccionMonto = 0;


        //Método para llenar treeview
        public void llenarTreeviewEmpleado()
        {
            DTEmpleado dta = new DTEmpleado();
            List<Nomina.Entidades.Empleado> lista = new List<Nomina.Entidades.Empleado>();
            lista = dta.ListarEmpleado();

            foreach (Nomina.Entidades.Empleado a in lista)
            {
                lsEmpleado.AppendValues(a.IdEmpleado.ToString(), a.Nombre.ToString(), a.Apellidos.ToString(), a.Cedula.ToString(), a.SalarioEmpleado.ToString(), a.Fecha_contratacion.ToString("dd-MM-yyyy"), a.Direccion.ToString());
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
            DTPago dta = new DTPago();
            List<Nomina.Entidades.Pago> lista = new List<Nomina.Entidades.Pago>();
            lista = dta.ListarPago();

            foreach (Nomina.Entidades.Pago a in lista)
            {
                if(idPago == a.IdEmpleado)
                {
                    lsPago.AppendValues(a.IdPago.ToString(), a.IdEmpleado.ToString(), a.Monto.ToString(),a.IdMoneda.ToString(), a.Fecha_pago.ToString());

                }

            }

            //Crear el modelo de datos
            trvPagos.Model = lsPago;


            trvPagos.AppendColumn("Id Pago", new CellRendererText(), "text", 0); 
            trvPagos.AppendColumn("Id Empleado", new CellRendererText(), "text", 1);
            trvPagos.AppendColumn("Monto", new CellRendererText(), "text", 2);
            trvPagos.AppendColumn("Id Moneda", new CellRendererText(), "text", 3);
            trvPagos.AppendColumn("Fecha Pago", new CellRendererText(), "text", 4);



        }

        //Metodo para llenar TreeView Pago Extra
        public void llenarTreeviewPago_Extra(Int32 idPago)
        {
            _extraMonto = 0;

            DTPago_Extra dta = new DTPago_Extra();
            List<Nomina.Entidades.Pago_Extra> lista = new List<Nomina.Entidades.Pago_Extra>();
            lista = dta.ListarPago_Extra();

            foreach (Nomina.Entidades.Pago_Extra a in lista)
            {
                if (idPago == a.IdPago)
                {
                    lsPago_Extras.AppendValues(a.IdEmpleado_Extra.ToString(), a.IdPago.ToString(), a.NombreExtra.ToString(), a.Monto.ToString());
                    _extraMonto += a.Monto;
                }

            }

            //Crear el modelo de datos
            trvExtras.Model = lsPago_Extras;


            //trvExtras.AppendColumn("Id extra del pago", new CellRendererText(), "text", 0);
            //trvExtras.AppendColumn("Id Pago", new CellRendererText(), "text", 1);
            trvExtras.AppendColumn("Nombre Extra", new CellRendererText(), "text", 2);
            trvExtras.AppendColumn("Monto", new CellRendererText(), "text", 3);

        }

        //Metodo para llenar TreeView Pago Deduccion
        public void llenarTreeviewPago_Deduccion(Int32 idPago)
        {
            _deduccionMonto = 0;
            DTPago_Deduccion dta = new DTPago_Deduccion();
            List<Nomina.Entidades.Pago_Deduccion> lista = new List<Nomina.Entidades.Pago_Deduccion>();
            lista = dta.ListarPago_Deduccion();

            foreach (Nomina.Entidades.Pago_Deduccion a in lista)
            {
                if (idPago == a.IdPago)
                {
                    lsPago_Deducciones.AppendValues(a.IdEmpleado_Deduccion.ToString(), a.IdPago.ToString(), a.NombreDeduccion.ToString(), a.Monto.ToString());
                    _deduccionMonto += a.Monto;
                }

            }

            //Crear el modelo de datos
            trvDeducciones.Model = lsPago_Deducciones;


            //trvDeducciones.AppendColumn("Id deduccion del pago", new CellRendererText(), "text", 0);
            //trvDeducciones.AppendColumn("Id Pago", new CellRendererText(), "text", 1);
            trvDeducciones.AppendColumn("Nombre Deduccion", new CellRendererText(), "text", 2);
            trvDeducciones.AppendColumn("Monto", new CellRendererText(), "text", 3);

        }

        //Método para recargar TreeView pago
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

        //Método para recargar TreeView Pago extras
        public void recargarTreeViewPago_Extra()
        {
            TreeViewColumn[] listColumns;
            listColumns = trvExtras.Columns;
            foreach (TreeViewColumn tvc in listColumns)
            {
                trvExtras.RemoveColumn(tvc);
            }
            lsPago_Extras.Clear();
        }

        //Método para recargar TreeView pago deducciones
        public void recargarTreeViewPago_Deducciones()
        {
            TreeViewColumn[] listColumns;
            listColumns = trvDeducciones.Columns;
            foreach (TreeViewColumn tvc in listColumns)
            {
                trvDeducciones.RemoveColumn(tvc);
            }
            lsPago_Deducciones.Clear();
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
            recargarTreeViewPago_Extra();
            recargarTreeViewPago_Deducciones();
            llenarTreeviewPago(idempleado);


        }

        protected void OnTrvPagosRowActivated(object o, RowActivatedArgs args)
        {
            var model = trvPagos.Model;
            TreeIter iter;

            model.GetIter(out iter, args.Path);

            var idPago = model.GetValue(iter, 0);
            var salario = model.GetValue(iter, 2);
            int idpagar = Convert.ToInt32(idPago);

            recargarTreeViewPago_Extra();
            recargarTreeViewPago_Deducciones();
            llenarTreeviewPago_Extra(idpagar);
            llenarTreeviewPago_Deduccion(idpagar);


            calcularDeduccion cd = new calcularDeduccion();

            double salarioA = Convert.ToDouble(salario);
            double salarioInss = salarioA - (salarioA* 0.0625);
            double salarioIr = salarioInss - cd.calcularIR(salarioA);
            double salarioCompleto = salarioIr + _extraMonto - _deduccionMonto;

            txtST.Text = salarioCompleto.ToString("N2");

        }

    }
}
