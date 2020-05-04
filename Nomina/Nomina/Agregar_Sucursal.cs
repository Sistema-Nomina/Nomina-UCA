using System;
using System.Collections.Generic;
using Gtk;
using Nomina.Datos;

namespace Nomina
{
    public partial class Agregar_Sucursal : Gtk.Window
    {
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
    }
}
