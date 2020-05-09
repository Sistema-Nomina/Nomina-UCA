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
            llenarTreeview();
            llenarCombobox();
            llenarComboboxSucursal();
        }

        ListStore ls = new ListStore(typeof(String), typeof(String), typeof(String), typeof(String), typeof(String), typeof(String), typeof(String), typeof(String));
        ListStore lsSucursal = new ListStore(typeof(String));
        ListStore lsEmpresa = new ListStore(typeof(String));

        //Método para llenar treeview
        public void llenarTreeview()
        {
            double salario = 0, deduccion=0;
            DTEmpleado dta = new DTEmpleado();
            List<Nomina.Entidades.Empleado> lista = new List<Nomina.Entidades.Empleado>();
            lista = dta.ListarEmpleado();

            foreach (Nomina.Entidades.Empleado a in lista)
            {
                salario = 0;
                deduccion = 0;
                deduccion = a.SalarioEmpleado * 0.0625;
                salario = a.SalarioEmpleado - deduccion;
                ls.AppendValues(a.IdEmpleado.ToString(), a.Nombre.ToString(), a.Apellidos.ToString(), a.Cedula.ToString(), a.SalarioEmpleado.ToString(), salario.ToString(),a.Fecha_contratacion.ToString(), a.Direccion.ToString());
            }

            //Crear el modelo de datos
            trvEmpleado.Model = ls;

            trvEmpleado.AppendColumn("ID", new CellRendererText(), "text", 0);
            trvEmpleado.AppendColumn("Nombre", new CellRendererText(), "text", 1);
            trvEmpleado.AppendColumn("Apellido", new CellRendererText(), "text", 2);
            trvEmpleado.AppendColumn("Cedula", new CellRendererText(), "text", 3);
            trvEmpleado.AppendColumn("Salario C$", new CellRendererText(), "text", 4);
            trvEmpleado.AppendColumn("Salario INSS C$", new CellRendererText(), "text", 5);
            trvEmpleado.AppendColumn("Fecha Contratacion", new CellRendererText(), "text", 6);
            trvEmpleado.AppendColumn("Direccion", new CellRendererText(), "text", 7);
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

        public void llenarComboboxSucursal()
        {
            DTSucursal dta = new DTSucursal();
            List<Nomina.Entidades.Sucursal> lista = new List<Nomina.Entidades.Sucursal>();
            lista = dta.ListarSucursal();

            foreach (Nomina.Entidades.Sucursal a in lista)
            {
                lsSucursal.AppendValues(a.Nombre.ToString());
            }

            //Crear el modelo de datos
            cmbSucursal.Model = lsSucursal;
        }


        //Método para llenar combobox
        public void llenarCombobox()
        {
            DTEmpresa dta = new DTEmpresa();
            List<Nomina.Entidades.Empresa> lista = new List<Nomina.Entidades.Empresa>();
            lista = dta.ListarEmpresa();

            foreach (Nomina.Entidades.Empresa a in lista)
            {
                lsEmpresa.AppendValues(a.Nombre.ToString());
            }

            //Crear el modelo de datos
            cmbEmpresa.Model = lsEmpresa;
        }
    }
}
