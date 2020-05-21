using System;
using System.Collections.Generic;
using Gtk;
using Nomina.Datos;
using Nomina.Utilidades;

namespace Nomina
{
    public partial class Agregar_Empleado : Gtk.Window
    {
        Mensaje _msj = new Mensaje();
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

        protected void OnBtnGuardarClicked(object sender, EventArgs e)
        {
            //txtInss.Text = idEstado().ToString();
            guardarContrato();
        }


        //Conseguir id de los cmb

        private int idTipoContrato()
        {
            int idContrato = 0;
            string descripcion = cmbTipoContrato.ActiveText;

            DTTipoContrato dta = new DTTipoContrato();
            List<Nomina.Entidades.Tipo_Contrato> lista = new List<Nomina.Entidades.Tipo_Contrato>();
            lista = dta.ListarTipoContrato();

            foreach (Nomina.Entidades.Tipo_Contrato a in lista)
            {
                if (a.Descripcion == descripcion)
                {
                    idContrato = a.IdTipo_Contrato;
                }
            }

            return idContrato;
        }

        private int idTurno()
        {
            int idturno = 0;
            string nombre = cmbTurno.ActiveText;

            DTTurno dta = new DTTurno();
            List<Nomina.Entidades.Turno> lista = new List<Nomina.Entidades.Turno>();
            lista = dta.ListarCargo();

            foreach (Nomina.Entidades.Turno a in lista)
            {
                if (a.Nombre == nombre)
                {
                    idturno = a.IdTurno;
                }
            }

            return idturno;
        }


        private int idEstado()
        {
            int idstatus = 0;
            string nombre = cmbEstado.ActiveText;

            DTEstado dta = new DTEstado();
            List<Nomina.Entidades.Estado> lista = new List<Nomina.Entidades.Estado>();
            lista = dta.ListarEsado();

            foreach (Nomina.Entidades.Estado a in lista)
            {
                if (a.Nombre == nombre)
                {
                    idstatus = a.IdEstado;
                }
            }

            return idstatus;
        }

        private int cargo()
        {
            int idcargo = 0;
            string nombre = cmbCargo.ActiveText;

            DTCargo dta = new DTCargo();
            List<Nomina.Entidades.Cargo> lista = new List<Nomina.Entidades.Cargo>();
            lista = dta.ListarCargo();

            foreach (Nomina.Entidades.Cargo a in lista)
            {
                if (a.Nombre == nombre)
                {
                    idcargo = a.IdCargo;
                }
            }

            return idcargo;
        }

        private int plantilla()
        {
            int idPlanilla = 0;
            string nombre = cmbPlantilla.ActiveText;

            DTPlantilla dta = new DTPlantilla();
            List<Nomina.Entidades.Planilla> lista = new List<Nomina.Entidades.Planilla>();
            lista = dta.ListarPlanilla();

            foreach (Nomina.Entidades.Planilla a in lista)
            {
                if (a.Tipo_planilla == nombre)
                {
                    idPlanilla = a.IdPlanilla;
                }
            }

            return idPlanilla;
        }

        private int area()
        {
            int idArea = 0;
            string nombre = cmbArea.ActiveText;

            DTArea dta = new DTArea();
            List<Nomina.Entidades.Area> lista = new List<Nomina.Entidades.Area>();
            lista = dta.ListarArea();

            foreach (Nomina.Entidades.Area a in lista)
            {
                if (a.Nombre == nombre)
                {
                    idArea = a.IdArea;
                }
            }

            return idArea;
        }

        private int sucursal()
        {
            int idSucursal = 0;
            string nombre = cmbSucursal.ActiveText;

            DTSucursal dta = new DTSucursal();
            List<Nomina.Entidades.Sucursal> lista = new List<Nomina.Entidades.Sucursal>();
            lista = dta.ListarSucursal();

            foreach (Nomina.Entidades.Sucursal a in lista)
            {
                if (a.Nombre == nombre)
                {
                    idSucursal = a.IdSucursal;
                }
            }

            return idSucursal;
        }

        //MEtodo de guardado
        public void guardarContrato()
        {
            int idTipoC = idTipoContrato();
            int idturno = idTurno();
            string descripcioC = txtDescripcion.Text;

            int guardadoC = 0;
            String msj = "";
            Entidades.Contrato act = new Entidades.Contrato();
            DTContrato dT = new DTContrato();

            act.Descripcion = descripcioC;
            act.IdTurno = idturno;
            act.IdTipoContrato = idTipoC;
            guardadoC = dT.guardarContrato(act);

            if (guardadoC > 0)
            {
                msj = "Contrato guardada con éxito!";
                _msj.ShowMessage(null, "Éxito", msj);
                guardarEm(dT.idLastContrato());
            }
            else
            {
                msj = "Error al Guardar";
                _msj.ShowMessage(null, "Error", msj);
            }

        }

        public void guardarEm(int idcontrato)
        {
            int guardado = 0;
            String msj = "";
            Entidades.Empleado act = new Entidades.Empleado();
            DTEmpleado dT = new DTEmpleado();

            act.Nombre = txtNombre.Text;
            act.Apellidos = txtApellidos.Text;
            act.Cedula = txtCedula.Text;
            act.NivelEstudio = txtNivelEstudio.Text;
            act.Inss_Empleado = txtInss.Text;

            act.IdEstado = idEstado();
            act.Direccion = txtDireccion.Text;
            act.SalarioEmpleado = Convert.ToDouble(txtSalario.Text);
            act.IdPlanilla = plantilla();
            act.IdArea = area();
            act.IdContrato = idcontrato;
            act.IdSucursal = sucursal();
            act.IdCargo = cargo();

            guardado = dT.guardarEmpleado(act);

            if (guardado > 0)
            {
                msj = "Empleado guardado con éxito!";
                _msj.ShowMessage(null, "Éxito", msj);
            }
            else
            {
                msj = "Error al Guardar";
                _msj.ShowMessage(null, "Error", msj);
            }

        }
    }
}
