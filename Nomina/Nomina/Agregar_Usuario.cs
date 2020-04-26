using System;
using Gtk;

namespace Nomina
{
    public partial class Agregar_Usuario : Gtk.Window
    {
        public Agregar_Usuario() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }
    }
}
