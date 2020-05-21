using System;
using System.Collections.Generic;
using Gtk;
using Nomina.Datos;
using Nomina.Utilidades;

namespace Nomina
{
    public partial class Editar_Sucursal : Gtk.Window
    {
        Mensaje _msj = new Mensaje();
        public Editar_Sucursal() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            llenarTreeview();
            llenarCombobox();
        }

        ListStore ls = new ListStore(typeof(String), typeof(String), typeof(String), typeof(String));
        ListStore lscmb = new ListStore(typeof(String));

        //Método para llenar treeview
        public void llenarTreeview()
        {
            DTSucursal dta = new DTSucursal();
            List<Nomina.Entidades.Sucursal> lista = new List<Nomina.Entidades.Sucursal>();
            lista = dta.ListarSucursal();

            foreach (Nomina.Entidades.Sucursal a in lista)
            {
                ls.AppendValues(a.IdSucursal.ToString(), a.Nombre.ToString(), a.Extension.ToString(), a.NombreEmpresa.ToString());
            }

            //Crear el modelo de datos
            trvSucursal.Model = ls;

            trvSucursal.AppendColumn("IdSucursal", new CellRendererText(), "text", 0);
            trvSucursal.AppendColumn("Nombre", new CellRendererText(), "text", 1);
            trvSucursal.AppendColumn("Extension", new CellRendererText(), "text", 2);
            trvSucursal.AppendColumn("Nombre Empresa", new CellRendererText(), "text", 3);

        }



        //Método para llenar combobox
        public void llenarCombobox()
        {
            DTEmpresa dta = new DTEmpresa();
            List<Nomina.Entidades.Empresa> lista = new List<Nomina.Entidades.Empresa>();
            lista = dta.ListarEmpresa();

            foreach (Nomina.Entidades.Empresa a in lista)
            {
                lscmb.AppendValues(a.Nombre.ToString());
            }

            //Crear el modelo de datos
            cmbEmpresa.Model = lscmb;
        }

        public void recargarTreeView()
        {
            TreeViewColumn[] listColumns;
            listColumns = trvSucursal.Columns;
            foreach (TreeViewColumn tvc in listColumns)
            {
                trvSucursal.RemoveColumn(tvc);
            }
            ls.Clear();
        }

        protected void OnTrvSucursalRowActivated(object o, RowActivatedArgs args)
        {
            var model = trvSucursal.Model;
            TreeIter iter;

            model.GetIter(out iter, args.Path);

            var id = model.GetValue(iter, 0);
            var nombre = model.GetValue(iter, 1);
            var extension = model.GetValue(iter, 2);
            //var empresa = model.GetValue(iter, 3);


            txtId.Text = id.ToString();
            txtNombre.Text = nombre.ToString();
            txtExtension.Text = extension.ToString();

        }

        protected void OnBtnEditarClicked(object sender, EventArgs e)
        {
            int idEmpresa = 0;
            string nombreEmpresa = cmbEmpresa.ActiveText;

            if (nombreEmpresa != "")
            {
                DTEmpresa dta = new DTEmpresa();
                List<Nomina.Entidades.Empresa> lista = new List<Nomina.Entidades.Empresa>();
                lista = dta.ListarEmpresa();

                foreach (Nomina.Entidades.Empresa a in lista)
                {
                    if (a.Nombre == nombreEmpresa)
                    {
                        idEmpresa = a.NumeroRuc;
                    }
                }

                int modificado = 0;
                String msj = "";
                Entidades.Sucursal act = new Entidades.Sucursal();
                DTSucursal dT = new DTSucursal();

                act.IdSucursal = Convert.ToInt32(txtId.Text);
                act.Nombre = this.txtNombre.Text;
                act.Extension = this.txtExtension.Text;
                act.NumeroRuc = idEmpresa;
                modificado = dT.modificarSucursal(act);

                if (modificado > 0)
                {
                    msj = "Sucursal modificada con éxito!";
                    _msj.ShowMessage(null, "Éxito", msj);
                    txtId.Text = "";
                    txtNombre.Text = "";
                    txtExtension.Text = "";
                    //txtDireccion.Text = "";
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
}
