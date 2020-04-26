using System;
namespace Nomina
{
    public partial class Detalle_Empleado : Gtk.Window
    {
        public Detalle_Empleado() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }
    }
}
