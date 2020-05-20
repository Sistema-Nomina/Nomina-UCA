using System;
using System.Collections.Generic;
using Gtk;
using Nomina.Datos;
using Nomina.Utilidades;

namespace Nomina
{
    public partial class Agregar_Extras : Gtk.Window
    {
        Mensaje _msj = new Mensaje();
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

        public void recargarTreeView()
        {
            TreeViewColumn[] listColumns;
            listColumns = trvExtras.Columns;
            foreach (TreeViewColumn tvc in listColumns)
            {
                trvExtras.RemoveColumn(tvc);
            }
            ls.Clear();
        }

        protected void OnBtnGuardarClicked(object sender, EventArgs e)
        {
            int guardado = 0;
            String msj = "";
            Entidades.Extras act = new Entidades.Extras();
            DTExtras dT = new DTExtras();

            act.Nombre = this.txtNombre.Text;
            act.Descripcion = this.txtDescripcion.Text;
            guardado = dT.guardarExtras(act);

            if (guardado > 0)
            {
                msj = "Extra guardada con éxito!";
                _msj.ShowMessage(null, "Éxito", msj);
                recargarTreeView();
                llenarTreeview();
            }
            else
            {
                msj = "Error al Guardar";
                _msj.ShowMessage(null, "Error", msj);
            }
        }
    }
}
