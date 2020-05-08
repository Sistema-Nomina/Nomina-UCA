using System;
using System.Collections.Generic;
using Gtk;
using Nomina.Datos;

namespace Nomina
{
    public partial class Agregar_Empleado : Gtk.Window
    {
        public Agregar_Empleado() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            llenarComboboxSucursal();
            llenarComboboxEstado();
            llenarComboboxCargo();
            llenarComboboxTipoContrato();
            llenarComboboxTurno();
            llenarComboboxPlanilla();
            llenarComboboxArea();
        }

        ListStore lsSucursal = new ListStore(typeof(String));
        ListStore lsEstado = new ListStore(typeof(String));
        ListStore lsCargo = new ListStore(typeof(String));
        ListStore lsTipoContrato = new ListStore(typeof(String));
        ListStore lsTurno = new ListStore(typeof(String));
        ListStore lsPlanilla = new ListStore(typeof(String));
        ListStore lsArea = new ListStore(typeof(String));

        //Método para llenar combobox
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

        public void llenarComboboxEstado()
        {
            DTEstado dta = new DTEstado();
            List<Nomina.Entidades.Estado> lista = new List<Nomina.Entidades.Estado>();
            lista = dta.ListarEsado();

            foreach (Nomina.Entidades.Estado a in lista)
            {
                lsEstado.AppendValues(a.Nombre.ToString());
            }

            //Crear el modelo de datos
            cmbEstado.Model = lsEstado;
        }

        public void llenarComboboxCargo()
        {
            DTCargo dta = new DTCargo();
            List<Nomina.Entidades.Cargo> lista = new List<Nomina.Entidades.Cargo>();
            lista = dta.ListarCargo();

            foreach (Nomina.Entidades.Cargo a in lista)
            {
                lsCargo.AppendValues(a.Nombre.ToString());
            }

            //Crear el modelo de datos
            cmbCargo.Model = lsCargo;
        }

        public void llenarComboboxTipoContrato()
        {
            DTTipoContrato dta = new DTTipoContrato();
            List<Nomina.Entidades.Tipo_Contrato> lista = new List<Nomina.Entidades.Tipo_Contrato>();
            lista = dta.ListarTipoContrato();

            foreach (Nomina.Entidades.Tipo_Contrato a in lista)
            {
                lsTipoContrato.AppendValues(a.Descripcion.ToString());
            }

            //Crear el modelo de datos
            cmbTipoContrato.Model = lsTipoContrato;
        }

        public void llenarComboboxTurno()
        {
            DTTurno dta = new DTTurno();
            List<Nomina.Entidades.Turno> lista = new List<Nomina.Entidades.Turno>();
            lista = dta.ListarCargo();

            foreach (Nomina.Entidades.Turno a in lista)
            {
                lsTurno.AppendValues(a.Nombre.ToString());
            }

            //Crear el modelo de datos
            cmbTurno.Model = lsTurno;
        }

        public void llenarComboboxPlanilla()
        {
            DTPlantilla dta = new DTPlantilla();
            List<Nomina.Entidades.Planilla> lista = new List<Nomina.Entidades.Planilla>();
            lista = dta.ListarPlanilla();

            foreach (Nomina.Entidades.Planilla a in lista)
            {
                lsPlanilla.AppendValues(a.Tipo_planilla.ToString());
            }

            //Crear el modelo de datos
            cmbPlantilla.Model = lsPlanilla;
        }

        public void llenarComboboxArea()
        {
            DTArea dta = new DTArea();
            List<Nomina.Entidades.Area> lista = new List<Nomina.Entidades.Area>();
            lista = dta.ListarArea();

            foreach (Nomina.Entidades.Area a in lista)
            {
                lsArea.AppendValues(a.Nombre.ToString());
            }

            //Crear el modelo de datos
            cmbArea.Model = lsArea;
        }

    }
}
