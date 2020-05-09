using System;
using System.Collections.Generic;
using Gtk;
using Nomina.Datos;

namespace Nomina
{
    public partial class Visualizar_Plantilla : Gtk.Window
    {
        public Visualizar_Plantilla() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            llenarTreeview();
        }

        ListStore ls = new ListStore(typeof(String), typeof(String));

        //Método para llenar treeview
        public void llenarTreeview()
        {
            DTPlantilla dta = new DTPlantilla();
            List<Nomina.Entidades.Planilla> lista = new List<Nomina.Entidades.Planilla>();
            lista = dta.ListarPlanilla();

            foreach (Nomina.Entidades.Planilla a in lista)
            {
                ls.AppendValues(a.IdPlanilla.ToString(), a.Tipo_planilla.ToString());
            }

            //Crear el modelo de datos
            trvPlantillas.Model = ls;

            trvPlantillas.AppendColumn("ID", new CellRendererText(), "text", 0);
            trvPlantillas.AppendColumn("Nombre", new CellRendererText(), "text", 1);
       
        }
    }
}
