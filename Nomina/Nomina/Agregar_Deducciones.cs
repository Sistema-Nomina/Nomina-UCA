using System;
using System.Collections.Generic;
using Gtk;
using Nomina.Datos;
using Nomina.Utilidades;

namespace Nomina
{
    public partial class Agregar_Deducciones : Gtk.Window
    {
        Mensaje _msj = new Mensaje();
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

        public void recargarTreeView()
        {
            TreeViewColumn[] listColumns;
            listColumns = trvDeduccion.Columns;
            foreach (TreeViewColumn tvc in listColumns)
            {
                trvDeduccion.RemoveColumn(tvc);
            }
            ls.Clear();
        }

        protected void OnBtnGuardarClicked(object sender, EventArgs e)
        {
            int guardado = 0;
            String msj = "";
            Entidades.Deducciones act = new Entidades.Deducciones();
            DTDeducciones dT = new DTDeducciones();

            act.Nombre = this.txtNombre.Text;
            act.Descripcion = this.txtDescripcion.Text;
            guardado = dT.guardarDeduccion(act);

            if (guardado > 0)
            {
                msj = "Deduccion guardada con éxito!";
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
