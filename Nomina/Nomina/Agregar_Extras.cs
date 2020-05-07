using System;
using System.Collections.Generic;
using Gtk;
using Nomina.Datos;

namespace Nomina
{
    public partial class Agregar_Extras : Gtk.Window
    {
        public Agregar_Extras() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            llenarTreeview();
        }

        ListStore ls = new ListStore(typeof(String), typeof(String), typeof(String));

        //Método para llenar treeview
        public void llenarTreeview()
        {
            DTExtras dta = new DTExtras();
            List<Nomina.Entidades.Extras> lista = new List<Nomina.Entidades.Extras>();
            lista = dta.ListarExtras();

            foreach (Nomina.Entidades.Extras a in lista)
            {
                ls.AppendValues(a.IdExtra.ToString(), a.Nombre.ToString(), a.Descripcion.ToString());
            }

            //Crear el modelo de datos
            trvExtras.Model = ls;

            trvExtras.AppendColumn("IdExtra", new CellRendererText(), "text", 0);
            trvExtras.AppendColumn("Nombre", new CellRendererText(), "text", 1);
            trvExtras.AppendColumn("Descripcion", new CellRendererText(), "text", 2);

        }

    }
}
