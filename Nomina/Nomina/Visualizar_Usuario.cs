using System;
using System.Collections.Generic;
using Gtk;
using Nomina.Datos;

namespace Nomina
{
    public partial class Visualizar_Usuario : Gtk.Window
    {
        public Visualizar_Usuario() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            llenarTreeview();
        }

        ListStore ls = new ListStore(typeof(String), typeof(String), typeof(String), typeof(String), typeof(String), typeof(String));

        //Método para llenar treeview
        public void llenarTreeview()
        {
            DTUsuario dta = new DTUsuario();
            List<Nomina.Entidades.Usuario> lista = new List<Nomina.Entidades.Usuario>();
            lista = dta.ListarUsuario();

            foreach (Nomina.Entidades.Usuario a in lista)
            {
                ls.AppendValues(a.IdUsuario.ToString(), a.IdEmpleado.ToString(), a.Usuarios.ToString(), a.Pwd.ToString(), a.Fecha_creacion.ToString(), a.Activo.ToString());
            }

            //Crear el modelo de datos
            trvUsuarios.Model = ls;

            trvUsuarios.AppendColumn("ID Usuario", new CellRendererText(), "text", 0);
            trvUsuarios.AppendColumn("ID Empleado", new CellRendererText(), "text", 1);
            trvUsuarios.AppendColumn("Usuario", new CellRendererText(), "text", 2);
            trvUsuarios.AppendColumn("Pwd", new CellRendererText(), "text", 3);
            trvUsuarios.AppendColumn("Fecha creacion", new CellRendererText(), "text", 4);
            trvUsuarios.AppendColumn("Activo", new CellRendererText(), "text", 5);
        }
    }
}
