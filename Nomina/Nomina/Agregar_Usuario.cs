using System;
using System.Collections.Generic;
using Gtk;
using Nomina.Datos;
using Nomina.Utilidades;

namespace Nomina
{
    public partial class Agregar_Usuario : Gtk.Window
    {
        Mensaje _msj = new Mensaje();
        public Agregar_Usuario() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            llenarTreeview();
            llenarCombobox();
        }

        ListStore lscmb = new ListStore(typeof(String));
        ListStore ls = new ListStore(typeof(String), typeof(String), typeof(String), typeof(String), typeof(String), typeof(String), typeof(String));

        //Método para llenar treeview
        public void llenarTreeview()
        {
            DTEmpleado dta = new DTEmpleado();
            List<Nomina.Entidades.Empleado> lista = new List<Nomina.Entidades.Empleado>();
            lista = dta.ListarEmpleadoNoUsuario();

            foreach (Nomina.Entidades.Empleado a in lista)
            {
                ls.AppendValues(a.IdEmpleado.ToString(), a.Nombre.ToString(), a.Apellidos.ToString(), a.Cedula.ToString(), a.SalarioEmpleado.ToString(), a.Fecha_contratacion.ToString(), a.Direccion.ToString());
            }

            //Crear el modelo de datos
            trvEmpleado.Model = ls;

            trvEmpleado.AppendColumn("ID", new CellRendererText(), "text", 0);
            trvEmpleado.AppendColumn("Nombre", new CellRendererText(), "text", 1);
            trvEmpleado.AppendColumn("Apellido", new CellRendererText(), "text", 2);
            trvEmpleado.AppendColumn("Cedula", new CellRendererText(), "text", 3);
            trvEmpleado.AppendColumn("Salario C$", new CellRendererText(), "text", 4);
            trvEmpleado.AppendColumn("Fecha Contratacion", new CellRendererText(), "text", 5);
            trvEmpleado.AppendColumn("Direccion", new CellRendererText(), "text", 6);
        }

        //Método para recargar TreeView
        public void recargarTreeView()
        {
            TreeViewColumn[] listColumns;
            listColumns = trvEmpleado.Columns;
            foreach (TreeViewColumn tvc in listColumns)
            {
                trvEmpleado.RemoveColumn(tvc);
            }
            ls.Clear();
        }

        //Método para llenar combobox
        public void llenarCombobox()
        {
            DTRol dta = new DTRol();
            List<Nomina.Entidades.Rol> lista = new List<Nomina.Entidades.Rol>();
            lista = dta.ListarRol();

            foreach (Nomina.Entidades.Rol a in lista)
            {
                lscmb.AppendValues(a.Nombre.ToString());
            }

            //Crear el modelo de datos
            cmbRol.Model = lscmb;
        }

        protected void OnBtnGuardarClicked(object sender, EventArgs e)
        {
            int idRol = 0;
            string nombreRol = cmbRol.ActiveText;
            string activoNombre = cmbEstado.ActiveText;
            string activo="0";

            if (activoNombre=="Activo")
            {
                activo = "1";
            }
            else
            {
                activo = "0";
            }

            DTRol dta = new DTRol();
            List<Nomina.Entidades.Rol> lista = new List<Nomina.Entidades.Rol>();
            lista = dta.ListarRol();

            foreach (Nomina.Entidades.Rol a in lista)
            {
                if (a.Nombre == nombreRol)
                {
                    idRol = a.IdRol;
                }
            }

            int guardado = 0;
            String msj = "";
            Entidades.Usuario act = new Entidades.Usuario();
            DTUsuario dT = new DTUsuario();

            act.IdEmpleado = Convert.ToInt32(txtIDEmpleado.Text);
            act.Usuarios = this.txtUser.Text;
            act.Pwd = txtPwd.Text;
            act.Activo = activo;


            guardado = dT.guardarUsuario(act);

            if (guardado > 0)
            {
                msj = "Usuario guardado con éxito!";
                _msj.ShowMessage(null, "Éxito", msj);
                recargarTreeView();
                llenarTreeview();
                limpiarTxt();

                Int32 idusuario = dT.idusuario();
                int guardar = 0;
                txtId.Text = "" + idusuario;

                Entidades.Usuario_Rol act1 = new Entidades.Usuario_Rol();
                DTUsuario_Rol dT1 = new DTUsuario_Rol();

                act1.IdUsuario = idusuario;
                act1.IdRol = idRol;
                guardar = dT1.guardarUsuario_Rol(act1);

                if (guardar > 0)
                {
                    msj = "Usuario Rol guardado con éxito!";
                    _msj.ShowMessage(null, "Éxito", msj);
                }
                else
                {
                    msj = "Error al Guardar";
                    _msj.ShowMessage(null, "Error", msj);
                }

            }
            else
            {
                msj = "Error al Guardar";
                _msj.ShowMessage(null, "Error", msj);
            }
        }

        protected void OnTrvEmpleadoRowActivated(object o, RowActivatedArgs args)
        {
            var model = trvEmpleado.Model;
            TreeIter iter;

            model.GetIter(out iter, args.Path);

            var id = model.GetValue(iter, 0);
            this.txtIDEmpleado.Text = Convert.ToString(id);
        }

        private void limpiarTxt()
        {
            txtPwd.Text = "";
            txtId.Text = "";
            txtUser.Text = "";
            txtIDEmpleado.Text = "";
        }

        protected void OnSaveAsActionActivated(object sender, EventArgs e)
        {
            limpiarTxt();
        }
    }
}
