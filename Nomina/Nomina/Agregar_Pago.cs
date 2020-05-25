using System;
using System.Collections.Generic;
using Gtk;
using Nomina.Datos;
using Nomina.Utilidades;

namespace Nomina
{
    public partial class Agregar_Pago : Gtk.Window
    {
        Mensaje _msj = new Mensaje();

        public Agregar_Pago() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            llenarTreeview();
            llenarCmbExtras();
            llenarCmbDeduccion();
            llenarCmbMoneda();
        }

        ListStore ls = new ListStore(typeof(String), typeof(String), typeof(String), typeof(String), typeof(String), typeof(String), typeof(String));
        ListStore lsExtra = new ListStore(typeof(String));
        ListStore lsDeduccion = new ListStore(typeof(String));
        ListStore lsMoneda = new ListStore(typeof(String));


        //Método para llenar treeview
        public void llenarTreeview()
        {
            DTEmpleado dta = new DTEmpleado();
            List<Nomina.Entidades.Empleado> lista = new List<Nomina.Entidades.Empleado>();
            lista = dta.ListarEmpleado();

            foreach (Nomina.Entidades.Empleado a in lista)
            {
                ls.AppendValues(a.IdEmpleado.ToString(), a.Nombre.ToString(), a.Apellidos.ToString(), a.Cedula.ToString(), a.SalarioEmpleado.ToString(), a.Fecha_contratacion.ToString(), a.Direccion.ToString());
            }

            //Crear el modelo de datos
            trvEmpleado.Model = ls;

            trvEmpleado.AppendColumn("ID", new CellRendererText(), "text", 0);
            trvEmpleado.AppendColumn("Nombre", new CellRendererText(), "text", 1);
            trvEmpleado.AppendColumn("Apellido", new CellRendererText(), "text", 2);
            trvEmpleado.AppendColumn("Cedula", new CellRendererText(), "text", 3);
            trvEmpleado.AppendColumn("Salario C$", new CellRendererText(), "text", 4);
            trvEmpleado.AppendColumn("Fecha Contratacion", new CellRendererText(), "text", 5);
            trvEmpleado.AppendColumn("Direccion", new CellRendererText(), "text", 6);
        }

        //Método para recargar TreeView
        public void recargarTreeView()
        {
            TreeViewColumn[] listColumns;
            listColumns = trvEmpleado.Columns;
            foreach (TreeViewColumn tvc in listColumns)
            {
                trvEmpleado.RemoveColumn(tvc);
            }
            ls.Clear();
        }

        //Metodo llenar TreeView por busqueda
        public void llenarTreePorBusqueda(Int32 busqueda)
        {
            int existe = 0;
            recargarTreeView();

            DTEmpleado dta = new DTEmpleado();
            List<Nomina.Entidades.Empleado> lista = new List<Nomina.Entidades.Empleado>();
            lista = dta.ListarEmpleado();

            foreach (Nomina.Entidades.Empleado a in lista)
            {
                if (busqueda == a.IdEmpleado)
                {
                    ls.AppendValues(a.IdEmpleado.ToString(), a.Nombre.ToString(), a.Apellidos.ToString(), a.Cedula.ToString(), a.SalarioEmpleado.ToString(), a.Fecha_contratacion.ToString(), a.Direccion.ToString());
                    existe = 1;
                }
            }

            if (existe == 0)
            {
                foreach (Nomina.Entidades.Empleado a in lista)
                {
                    ls.AppendValues(a.IdEmpleado.ToString(), a.Nombre.ToString(), a.Apellidos.ToString(), a.Cedula.ToString(), a.SalarioEmpleado.ToString(), a.Fecha_contratacion.ToString("dd-MM-yyyy"), a.Direccion.ToString());
                }
            }

            //Crear el modelo de datos
            trvEmpleado.Model = ls;

            trvEmpleado.AppendColumn("ID", new CellRendererText(), "text", 0);
            trvEmpleado.AppendColumn("Nombre", new CellRendererText(), "text", 1);
            trvEmpleado.AppendColumn("Apellido", new CellRendererText(), "text", 2);
            trvEmpleado.AppendColumn("Cedula", new CellRendererText(), "text", 3);
            trvEmpleado.AppendColumn("Salario C$", new CellRendererText(), "text", 4);
            trvEmpleado.AppendColumn("Fecha Contratacion", new CellRendererText(), "text", 5);
            trvEmpleado.AppendColumn("Direccion", new CellRendererText(), "text", 6);
        }

        public void llenarCmbExtras()
        {
            DTExtras dta = new DTExtras();
            List<Nomina.Entidades.Extras> lista = new List<Nomina.Entidades.Extras>();
            lista = dta.ListarExtras();

            foreach (Nomina.Entidades.Extras a in lista)
            {
                lsExtra.AppendValues(a.Nombre.ToString());
            }

            //Crear el modelo de datos
            cmbExtra.Model = lsExtra;

        }

        public void llenarCmbDeduccion()
        {
            DTDeducciones dta = new DTDeducciones();
            List<Nomina.Entidades.Deducciones> lista = new List<Nomina.Entidades.Deducciones>();
            lista = dta.ListarDeducciones();

            foreach (Nomina.Entidades.Deducciones a in lista)
            {
                lsDeduccion.AppendValues(a.Nombre.ToString());
            }

            //Crear el modelo de datos
            cmbDeduccion.Model = lsDeduccion;
        }

        public void llenarCmbMoneda()
        {
            DTMoneda dta = new DTMoneda();
            List<Nomina.Entidades.Moneda> lista = new List<Nomina.Entidades.Moneda>();
            lista = dta.ListarMoneda();

            foreach (Nomina.Entidades.Moneda a in lista)
            {
                lsMoneda.AppendValues(a.Nombre.ToString());
            }

            //Crear el modelo de datos
            cmbMoneda.Model = lsMoneda;
        }

        protected void OnBtnBuscarClicked(object sender, EventArgs e)
        {
            Int32 idBusqueda = Convert.ToInt32(txtBuscar.Text);
            llenarTreePorBusqueda(idBusqueda);

        }

        protected void OnTrvEmpleadoRowActivated(object o, RowActivatedArgs args)
        {
            var model = trvEmpleado.Model;
            TreeIter iter;

            model.GetIter(out iter, args.Path);

            var id = model.GetValue(iter, 0);
            var monto = model.GetValue(iter, 4);

            this.txtIDEmpleado.Text = Convert.ToString(id);
            this.txtMontoS.Text = Convert.ToString(monto);

        }

        protected void OnBtnGuardarPagoClicked(object sender, EventArgs e)
        {
            int guardadoC = 0;
            String msj = "";
            Entidades.Pago act = new Entidades.Pago();
            DTPago dT = new DTPago();

            act.IdEmpleado = Convert.ToInt32(txtIDEmpleado.Text);
            act.IdMoneda = idMoneda();
            act.Monto = Convert.ToDouble(txtMontoS.Text);
            guardadoC = dT.guardarPago(act);

            if (guardadoC > 0)
            {
                msj = "Pago guardado con éxito!";
                _msj.ShowMessage(null, "Éxito", msj);

                txtIdPago1.Text = "" + dT.idpago();
                txtPago2.Text = "" + dT.idpago();
            }
            else
            {
                msj = "Error al Guardar";
                _msj.ShowMessage(null, "Error", msj);
            }



        }


        private int idMoneda()
        {
            int IdMoneda = 0;
            string nombre = cmbMoneda.ActiveText;

            DTMoneda dta = new DTMoneda();
            List<Nomina.Entidades.Moneda> lista = new List<Nomina.Entidades.Moneda>();
            lista = dta.ListarMoneda();

            foreach (Nomina.Entidades.Moneda a in lista)
            {
                if (a.Nombre == nombre)
                {
                    IdMoneda = a.IdMoneda;
                }
            }

            return IdMoneda;
        }

        protected void OnBtnExtraClicked(object sender, EventArgs e)
        {
            int guardadoC = 0;
            String msj = "";
            Entidades.Pago_Extra act = new Entidades.Pago_Extra();
            DTPago_Extra dT = new DTPago_Extra();

            act.IdPago = Convert.ToInt32(txtIdPago1.Text);
            act.IdExtra = idPagosExtra();
            act.Monto = Convert.ToDouble(txtMontoE.Text);
            guardadoC = dT.guardarPagoExtra(act);

            if (guardadoC > 0)
            {
                msj = "Extra guardado con éxito!";
                _msj.ShowMessage(null, "Éxito", msj);
            }
            else
            {
                msj = "Error al Guardar";
                _msj.ShowMessage(null, "Error", msj);
            }
        }


        private int idPagosExtra()
        {
            int IdExtra = 0;
            string nombre = cmbExtra.ActiveText;

            DTExtras dta = new DTExtras();
            List<Nomina.Entidades.Extras> lista = new List<Nomina.Entidades.Extras>();
            lista = dta.ListarExtras();

            foreach (Nomina.Entidades.Extras a in lista)
            {
                if (a.Nombre == nombre)
                {
                    IdExtra = a.IdExtra;
                }
            }

            return IdExtra;
        }

        protected void OnBtnDeduccionClicked(object sender, EventArgs e)
        {
            int guardadoC = 0;
            String msj = "";
            Entidades.Pago_Deduccion act = new Entidades.Pago_Deduccion();
            DTPago_Deduccion dT = new DTPago_Deduccion();

            act.IdPago = Convert.ToInt32(txtPago2.Text);
            act.IdDeduccion = idPagosDeduccion();
            act.Monto = Convert.ToDouble(txtMontoD.Text);
            guardadoC = dT.guardarPagoDeduccion(act);

            if (guardadoC > 0)
            {
                msj = "Deduccion guardada con éxito!";
                _msj.ShowMessage(null, "Éxito", msj);
            }
            else
            {
                msj = "Error al Guardar";
                _msj.ShowMessage(null, "Error", msj);
            }
        }


        private int idPagosDeduccion()
        {
            int IdDeduccion = 0;
            string nombre = cmbDeduccion.ActiveText;

            DTDeducciones dta = new DTDeducciones();
            List<Nomina.Entidades.Deducciones> lista = new List<Nomina.Entidades.Deducciones>();
            lista = dta.ListarDeducciones();

            foreach (Nomina.Entidades.Deducciones a in lista)
            {
                if (a.Nombre == nombre)
                {
                    IdDeduccion = a.IdDeduccion;
                }
            }

            return IdDeduccion;
        }
    }
}
