using System;
using System.Collections.Generic;
using Gtk;
using Nomina.Datos;

namespace Nomina
{
    public partial class Agregar_Deducciones : Gtk.Window
    {
        public Agregar_Deducciones() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            llenarTreeview();
        }

        ListStore ls = new ListStore(typeof(String), typeof(String), typeof(String));

        //Método para llenar treeview
        public void llenarTreeview()
        {
            DTDeducciones dta = new DTDeducciones();
            List<Nomina.Entidades.Deducciones> lista = new List<Nomina.Entidades.Deducciones>();
            lista = dta.ListarDeducciones();

            foreach (Nomina.Entidades.Deducciones a in lista)
            {
                ls.AppendValues(a.IdDeduccion.ToString(), a.Nombre.ToString(), a.Descripcion.ToString());
            }

            //Crear el modelo de datos
            trvDeduccion.Model = ls;

            trvDeduccion.AppendColumn("IdExtra", new CellRendererText(), "text", 0);
            trvDeduccion.AppendColumn("Nombre", new CellRendererText(), "text", 1);
            trvDeduccion.AppendColumn("Descripcion", new CellRendererText(), "text", 2);

        }
    }
}
