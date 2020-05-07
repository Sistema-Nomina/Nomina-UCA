using System;
using System.Collections.Generic;
using Gtk;
using Nomina.Datos;

namespace Nomina
{
    public partial class Agregar_Usuario : Gtk.Window
    {
        public Agregar_Usuario() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            llenarCombobox();
        }

        ListStore lscmb = new ListStore(typeof(String));

        //Método para llenar combobox
        public void llenarCombobox()
        {
            DTRol dta = new DTRol();
            List<Nomina.Entidades.Rol> lista = new List<Nomina.Entidades.Rol>();
            lista = dta.ListarRol();

            foreach (Nomina.Entidades.Rol a in lista)
            {
                lscmb.AppendValues(a.Nombre.ToString());
            }

            //Crear el modelo de datos
            cmbRol.Model = lscmb;
        }

        protected void OnBtnGuardarClicked(object sender, EventArgs e)
        {

        }
    }
}
