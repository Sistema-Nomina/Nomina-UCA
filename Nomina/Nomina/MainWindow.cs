using System;
using Gtk;

public partial class MainWindow : Gtk.Window 
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnBtnSalirClicked(object sender, EventArgs e)
    {
        Application.Quit();
    }

    protected void OnAgregarActionActivated(object sender, EventArgs e)
    {
        Nomina.Agregar_Usuario ag = new Nomina.Agregar_Usuario();
        ag.Show();
    }

    protected void OnModificarActionActivated(object sender, EventArgs e)
    {
        Nomina.Modificar_Usuario md = new Nomina.Modificar_Usuario();
        md.Show();
    }

    protected void OnVisualizarActionActivated(object sender, EventArgs e)
    {
        Nomina.Visualizar_Usuario vs = new Nomina.Visualizar_Usuario();
        vs.Show();
    }

    protected void OnAgregarAction1Activated(object sender, EventArgs e)
    {
        Nomina.Agregar_Empleado ae = new Nomina.Agregar_Empleado();
        ae.Show();
    }

    protected void OnVisualizarAction1Activated(object sender, EventArgs e)
    {
        Nomina.Visualizar_Empleado ve = new Nomina.Visualizar_Empleado();
        ve.Show();
    }


    protected void OnVisualizarAction7Activated(object sender, EventArgs e)
    {
        Nomina.Visualizar_Plantilla vp = new Nomina.Visualizar_Plantilla();
        vp.Show();
    }

    protected void OnDetalleDeEmpleadoAction1Activated(object sender, EventArgs e)
    {
        Nomina.Detalle_Empleado de = new Nomina.Detalle_Empleado();
        de.Show();
    }

    protected void OnAgregarAction4Activated(object sender, EventArgs e)
    {
        Nomina.Agregar_Pago ap = new Nomina.Agregar_Pago();
        ap.Show();
    }

    protected void OnVisualizarAction5Activated(object sender, EventArgs e)
    {
        Nomina.Visualizar_Pago vi = new Nomina.Visualizar_Pago();
        vi.Show();
    }

    protected void OnAgregarAction5Activated(object sender, EventArgs e)
    {
        Nomina.Agregar_Extras ax = new Nomina.Agregar_Extras();
        ax.Show();
    }

    protected void OnAgregarAction6Activated(object sender, EventArgs e)
    {
        Nomina.Agregar_Deducciones ad = new Nomina.Agregar_Deducciones();
        ad.Show();
    }

    protected void OnAgregarAction2Activated(object sender, EventArgs e)
    {
        Nomina.Agregar_Empresa ar = new Nomina.Agregar_Empresa();
        ar.Show();
    }

    protected void OnVisualizarAction3Activated(object sender, EventArgs e)
    {
        Nomina.Visualizar_Empresa vem = new Nomina.Visualizar_Empresa();
        vem.Show();
    }

    protected void OnEditarAction1Activated(object sender, EventArgs e)
    {
        Nomina.Editar_Empresa ee = new Nomina.Editar_Empresa();
        ee.Show();
    }

    protected void OnAgregarAction3Activated(object sender, EventArgs e)
    {
        Nomina.Agregar_Sucursal az = new Nomina.Agregar_Sucursal();
        az.Show();
    }

    protected void OnVisualizarAction4Activated(object sender, EventArgs e)
    {
        Nomina.Visualizar_Sucursal asu = new Nomina.Visualizar_Sucursal();
        asu.Show();
    }

    protected void OnEditarAction2Activated(object sender, EventArgs e)
    {
        Nomina.Editar_Sucursal edit = new Nomina.Editar_Sucursal();
        edit.Show();
    }
}
