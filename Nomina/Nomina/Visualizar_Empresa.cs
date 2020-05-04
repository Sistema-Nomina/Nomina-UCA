using System;
using System.Collections.Generic;
using Gtk;
using Nomina.Datos;

namespace Nomina
{
    public partial class Visualizar_Empresa : Gtk.Window
    {
        public Visualizar_Empresa() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            llenarTreeview();
        }
        ListStore ls = new ListStore(typeof(String), typeof(String), typeof(String), typeof(String));

        //Método para llenar treeview
        public void llenarTreeview()
        {
            DTEmpresa dta = new DTEmpresa();
            List<Nomina.Entidades.Empresa> lista = new List<Nomina.Entidades.Empresa>();
            lista = dta.ListarEmpresa();

            foreach (Nomina.Entidades.Empresa a in lista)
            {
                ls.AppendValues(a.NumeroRuc.ToString(), a.Nombre.ToString(), a.Telefono.ToString(), a.Direccion.ToString());
            }

            //Crear el modelo de datos
            trvEmpresa.Model = ls;

            trvEmpresa.AppendColumn("NumeroRUC", new CellRendererText(), "text", 0);
            trvEmpresa.AppendColumn("Nombre", new CellRendererText(), "text", 1);
            trvEmpresa.AppendColumn("Telefono", new CellRendererText(), "text", 2);
            trvEmpresa.AppendColumn("Direccion", new CellRendererText(), "text", 3);

        }
    }
}
