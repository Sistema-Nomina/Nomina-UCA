using System;
using Nomina.Datos;
using Nomina.Utilidades;

namespace Nomina
{
    public partial class Agregar_Empresa : Gtk.Window
    {
        Mensaje _msj = new Mensaje();
        public Agregar_Empresa() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        protected void OnBtnGuardarClicked(object sender, EventArgs e)
        {
            int guardado = 0;
            String msj = "";
            Entidades.Empresa act = new Entidades.Empresa();
            DTEmpresa dT = new DTEmpresa();

            act.NumeroRuc = Convert.ToInt32(this.txtNumeroRUC.Text);
            act.Nombre = this.txtNombre.Text;
            act.Telefono = this.txtTelefono.Text;
            act.Direccion = this.txtDireccion.Text;
            guardado = dT.guardarEmpresa(act);

            if (guardado > 0)
            {
                msj = "Empresa guardada con éxito!";
                _msj.ShowMessage(null, "Éxito", msj);
                txtNombre.Text = "";
                txtTelefono.Text = "";
                txtDireccion.Text = "";
            }
            else
            {
                msj = "Error al Guardar";
                _msj.ShowMessage(null, "Error", msj);
            }
        }
    }
}
