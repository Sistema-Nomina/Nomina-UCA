using System;
using System.Collections.Generic;
using Gtk;
using Nomina.Datos;
using Nomina.Utilidades;

namespace Nomina
{
    public partial class Agregar_Sucursal : Gtk.Window
    {
        Mensaje _msj = new Mensaje();
        public Agregar_Sucursal() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            llenarCombobox();
        }

        ListStore ls = new ListStore(typeof(String));

        //Método para llenar combobox
        public void llenarCombobox()
        {
            DTEmpresa dta = new DTEmpresa();
            List<Nomina.Entidades.Empresa> lista = new List<Nomina.Entidades.Empresa>();
            lista = dta.ListarEmpresa();

            foreach (Nomina.Entidades.Empresa a in lista)
            {
                ls.AppendValues(a.Nombre.ToString());
            }

            //Crear el modelo de datos
            cmbEmpresa.Model = ls;
        }

        protected void OnBtnAgregarClicked(object sender, EventArgs e)
        {
            int idEmpresa = 0;
            string nombreEmpresa = cmbEmpresa.ActiveText; 

            DTEmpresa dta = new DTEmpresa();
            List<Nomina.Entidades.Empresa> lista = new List<Nomina.Entidades.Empresa>();
            lista = dta.ListarEmpresa();

            foreach (Nomina.Entidades.Empresa a in lista)
            {
                if (a.Nombre == nombreEmpresa)
                {
                    idEmpresa = a.NumeroRuc;
                }
            }

            int guardado = 0;
            String msj = "";
            Entidades.Sucursal act = new Entidades.Sucursal();
            DTSucursal dT = new DTSucursal();

            act.Nombre = this.txtNombre.Text;
            act.Extension = this.txtExtension.Text;
            act.NumeroRuc = idEmpresa;
            guardado = dT.guardarSucursal(act);

            if (guardado > 0)
            {
                msj = "Sucursal guardada con éxito!";
                _msj.ShowMessage(null, "Éxito", msj);
            }
            else
            {
                msj = "Error al Guardar";
                _msj.ShowMessage(null, "Error", msj);
            }

        }

        protected void OnBtnListarClicked(object sender, EventArgs e)
        {

        }
    }
}
