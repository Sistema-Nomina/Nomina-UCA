using System;
namespace Nomina
{
    public partial class ActionGroup : Gtk.ActionGroup
    {
        public ActionGroup() :
                base("Nomina.ActionGroup")
        {
            this.Build();
        }
    }
}
