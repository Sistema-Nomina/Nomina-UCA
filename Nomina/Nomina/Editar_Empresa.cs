using System;
using System.Collections.Generic;
using Gtk;
using Nomina.Datos;
using Nomina.Utilidades;

namespace Nomina
{
    public partial class Editar_Empresa : Gtk.Window
    {
        Mensaje _msj = new Mensaje();
        public Editar_Empresa() :
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

        public void recargarTreeView()
        {
            TreeViewColumn[] listColumns;
            listColumns = trvEmpresa.Columns;
            foreach (TreeViewColumn tvc in listColumns)
            {
                trvEmpresa.RemoveColumn(tvc);
            }
            ls.Clear();
        }

        protected void OnTrvEmpresaRowActivated(object o, Gtk.RowActivatedArgs args)
        {
            var model = trvEmpresa.Model;
            TreeIter iter;

            model.GetIter(out iter, args.Path);

            var id = model.GetValue(iter, 0);
            var nombre = model.GetValue(iter, 1);
            var telefono = model.GetValue(iter, 2);
            var direccion = model.GetValue(iter, 3);


            txtTelefono.Text = telefono.ToString();
            txtNombre.Text = nombre.ToString();
            txtDireccion.Text = direccion.ToString();
            txtRUC.Text = id.ToString();

        }

        protected void OnBtnEditarClicked(object sender, EventArgs e)
        {
            int modificado = 0;
            String msj = "";
            Entidades.Empresa act = new Entidades.Empresa();
            DTEmpresa dT = new DTEmpresa();

            act.NumeroRuc = Convert.ToInt32(this.txtRUC.Text);
            act.Nombre = this.txtNombre.Text;
            act.Telefono = this.txtTelefono.Text;
            act.Direccion = this.txtDireccion.Text;
            modificado = dT.modificarEmpresa(act);

            if (modificado > 0)
            {
                msj = "Empresa modificada con éxito!";
                _msj.ShowMessage(null, "Éxito", msj);
                txtRUC.Text = "";
                txtNombre.Text = "";
                txtTelefono.Text = "";
                txtDireccion.Text = "";
                recargarTreeView();
                llenarTreeview();
            }
            else
            {
                msj = "Error al Guardar";
                _msj.ShowMessage(null, "Error", msj);
            }
        }

        protected void OnBtnListarClicked(object sender, EventArgs e)
        {
            Visualizar_Empresa vs = new Visualizar_Empresa();
            vs.Show();
            this.Destroy();
        }

        protected void OnBtnAgregarClicked(object sender, EventArgs e)
        {
            Agregar_Empresa _as = new Agregar_Empresa();
            _as.Show();
            this.Destroy();
        }
    }
}
