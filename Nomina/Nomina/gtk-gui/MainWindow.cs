
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;

	private global::Gtk.Action InicioAction;

	private global::Gtk.Action UsuarioAction;

	private global::Gtk.Action EmpleadoAction;

	private global::Gtk.Action NminaAction;

	private global::Gtk.Action PanelAction;

	private global::Gtk.Action ConfiguracinAction;

	private global::Gtk.Action AgregarAction;

	private global::Gtk.Action VisualizarAction;

	private global::Gtk.Action ModificarAction;

	private global::Gtk.Action EliminarAction;

	private global::Gtk.Action AgregarAction1;

	private global::Gtk.Action VisualizarAction1;

	private global::Gtk.Action EditarAction;

	private global::Gtk.Action BorrarAction;

	private global::Gtk.Action VisualizarAction6;

	private global::Gtk.Action DetalleDeEmpleadoAction;

	private global::Gtk.Action OpcionesAction;

	private global::Gtk.Action PlantillasAction;

	private global::Gtk.Action PagosAction;

	private global::Gtk.Action EmpresaAction;

	private global::Gtk.Action SucursalAction;

	private global::Gtk.Action AgregarAction2;

	private global::Gtk.Action VisualizarAction3;

	private global::Gtk.Action EditarAction1;

	private global::Gtk.Action AgregarAction3;

	private global::Gtk.Action VisualizarAction4;

	private global::Gtk.Action EditarAction2;

	private global::Gtk.Action AgregarAction4;

	private global::Gtk.Action VisualizarAction5;

	private global::Gtk.Action ExtrasAction;

	private global::Gtk.Action AgregarAction5;

	private global::Gtk.Action DeduccionesAction;

	private global::Gtk.Action AgregarAction6;

	private global::Gtk.Action AyudaAction;

	private global::Gtk.Action VisualizarAction7;

	private global::Gtk.Action DetalleDeEmpleadoAction1;

	private global::Gtk.Action dsAction;

	private global::Gtk.VBox vbox1;

	private global::Gtk.HBox hbox1;

	private global::Gtk.ColorButton colorbutton2;

	private global::Gtk.Label label3;

	private global::Gtk.ColorButton colorbutton3;

	private global::Gtk.MenuBar menubar1;

	private global::Gtk.VBox vbox3;

	private global::Gtk.Alignment alignment1;

	private global::Gtk.Alignment alignment2;

	private global::Gtk.HBox hbox4;

	private global::Gtk.Alignment alignment3;

	private global::Gtk.Alignment alignment4;

	private global::Gtk.Button btnSalir;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
		this.InicioAction = new global::Gtk.Action("InicioAction", global::Mono.Unix.Catalog.GetString("Inicio"), null, null);
		this.InicioAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Inicio");
		w1.Add(this.InicioAction, null);
		this.UsuarioAction = new global::Gtk.Action("UsuarioAction", global::Mono.Unix.Catalog.GetString("Usuario"), null, null);
		this.UsuarioAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Usuario");
		w1.Add(this.UsuarioAction, null);
		this.EmpleadoAction = new global::Gtk.Action("EmpleadoAction", global::Mono.Unix.Catalog.GetString("Empleado"), null, null);
		this.EmpleadoAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Empleado");
		w1.Add(this.EmpleadoAction, null);
		this.NminaAction = new global::Gtk.Action("NminaAction", global::Mono.Unix.Catalog.GetString("Nómina"), null, null);
		this.NminaAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Nómina");
		w1.Add(this.NminaAction, null);
		this.PanelAction = new global::Gtk.Action("PanelAction", global::Mono.Unix.Catalog.GetString("Panel"), null, null);
		this.PanelAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Panel");
		w1.Add(this.PanelAction, null);
		this.ConfiguracinAction = new global::Gtk.Action("ConfiguracinAction", global::Mono.Unix.Catalog.GetString("Configuración"), null, null);
		this.ConfiguracinAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Configuración");
		w1.Add(this.ConfiguracinAction, null);
		this.AgregarAction = new global::Gtk.Action("AgregarAction", global::Mono.Unix.Catalog.GetString("Agregar"), null, null);
		this.AgregarAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Agregar");
		w1.Add(this.AgregarAction, null);
		this.VisualizarAction = new global::Gtk.Action("VisualizarAction", global::Mono.Unix.Catalog.GetString("Visualizar"), null, null);
		this.VisualizarAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Visualizar");
		w1.Add(this.VisualizarAction, null);
		this.ModificarAction = new global::Gtk.Action("ModificarAction", global::Mono.Unix.Catalog.GetString("Modificar"), null, null);
		this.ModificarAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Modificar");
		w1.Add(this.ModificarAction, null);
		this.EliminarAction = new global::Gtk.Action("EliminarAction", global::Mono.Unix.Catalog.GetString("Eliminar"), null, null);
		this.EliminarAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Eliminar");
		w1.Add(this.EliminarAction, null);
		this.AgregarAction1 = new global::Gtk.Action("AgregarAction1", global::Mono.Unix.Catalog.GetString("Agregar "), null, null);
		this.AgregarAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Agregar ");
		w1.Add(this.AgregarAction1, null);
		this.VisualizarAction1 = new global::Gtk.Action("VisualizarAction1", global::Mono.Unix.Catalog.GetString("Visualizar"), null, null);
		this.VisualizarAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Visualizar");
		w1.Add(this.VisualizarAction1, null);
		this.EditarAction = new global::Gtk.Action("EditarAction", global::Mono.Unix.Catalog.GetString("Editar"), null, null);
		this.EditarAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Editar");
		w1.Add(this.EditarAction, null);
		this.BorrarAction = new global::Gtk.Action("BorrarAction", global::Mono.Unix.Catalog.GetString("Borrar"), null, null);
		this.BorrarAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Borrar");
		w1.Add(this.BorrarAction, null);
		this.VisualizarAction6 = new global::Gtk.Action("VisualizarAction6", global::Mono.Unix.Catalog.GetString("Visualizar"), null, null);
		this.VisualizarAction6.ShortLabel = global::Mono.Unix.Catalog.GetString("Visualizar");
		w1.Add(this.VisualizarAction6, null);
		this.DetalleDeEmpleadoAction = new global::Gtk.Action("DetalleDeEmpleadoAction", global::Mono.Unix.Catalog.GetString("Detalle de Empleado"), null, null);
		this.DetalleDeEmpleadoAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Detalle de Empleado");
		w1.Add(this.DetalleDeEmpleadoAction, null);
		this.OpcionesAction = new global::Gtk.Action("OpcionesAction", global::Mono.Unix.Catalog.GetString("Opciones"), null, null);
		this.OpcionesAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Opciones");
		w1.Add(this.OpcionesAction, null);
		this.PlantillasAction = new global::Gtk.Action("PlantillasAction", global::Mono.Unix.Catalog.GetString("Plantillas"), null, null);
		this.PlantillasAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Plantillas");
		w1.Add(this.PlantillasAction, null);
		this.PagosAction = new global::Gtk.Action("PagosAction", global::Mono.Unix.Catalog.GetString("Pagos"), null, null);
		this.PagosAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Pagos");
		w1.Add(this.PagosAction, null);
		this.EmpresaAction = new global::Gtk.Action("EmpresaAction", global::Mono.Unix.Catalog.GetString("Empresa"), null, null);
		this.EmpresaAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Empresa");
		w1.Add(this.EmpresaAction, null);
		this.SucursalAction = new global::Gtk.Action("SucursalAction", global::Mono.Unix.Catalog.GetString("Sucursal"), null, null);
		this.SucursalAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Sucursal");
		w1.Add(this.SucursalAction, null);
		this.AgregarAction2 = new global::Gtk.Action("AgregarAction2", global::Mono.Unix.Catalog.GetString("Agregar"), null, null);
		this.AgregarAction2.ShortLabel = global::Mono.Unix.Catalog.GetString("Agregar");
		w1.Add(this.AgregarAction2, null);
		this.VisualizarAction3 = new global::Gtk.Action("VisualizarAction3", global::Mono.Unix.Catalog.GetString("Visualizar"), null, null);
		this.VisualizarAction3.ShortLabel = global::Mono.Unix.Catalog.GetString("Visualizar");
		w1.Add(this.VisualizarAction3, null);
		this.EditarAction1 = new global::Gtk.Action("EditarAction1", global::Mono.Unix.Catalog.GetString("Editar"), null, null);
		this.EditarAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Editar");
		w1.Add(this.EditarAction1, null);
		this.AgregarAction3 = new global::Gtk.Action("AgregarAction3", global::Mono.Unix.Catalog.GetString("Agregar"), null, null);
		this.AgregarAction3.ShortLabel = global::Mono.Unix.Catalog.GetString("Agregar");
		w1.Add(this.AgregarAction3, null);
		this.VisualizarAction4 = new global::Gtk.Action("VisualizarAction4", global::Mono.Unix.Catalog.GetString("Visualizar"), null, null);
		this.VisualizarAction4.ShortLabel = global::Mono.Unix.Catalog.GetString("Visualizar");
		w1.Add(this.VisualizarAction4, null);
		this.EditarAction2 = new global::Gtk.Action("EditarAction2", global::Mono.Unix.Catalog.GetString("Editar"), null, null);
		this.EditarAction2.ShortLabel = global::Mono.Unix.Catalog.GetString("Editar");
		w1.Add(this.EditarAction2, null);
		this.AgregarAction4 = new global::Gtk.Action("AgregarAction4", global::Mono.Unix.Catalog.GetString("Agregar"), null, null);
		this.AgregarAction4.ShortLabel = global::Mono.Unix.Catalog.GetString("Agregar");
		w1.Add(this.AgregarAction4, null);
		this.VisualizarAction5 = new global::Gtk.Action("VisualizarAction5", global::Mono.Unix.Catalog.GetString("Visualizar"), null, null);
		this.VisualizarAction5.ShortLabel = global::Mono.Unix.Catalog.GetString("Visualizar");
		w1.Add(this.VisualizarAction5, null);
		this.ExtrasAction = new global::Gtk.Action("ExtrasAction", global::Mono.Unix.Catalog.GetString("Extras"), null, null);
		this.ExtrasAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Extras");
		w1.Add(this.ExtrasAction, null);
		this.AgregarAction5 = new global::Gtk.Action("AgregarAction5", global::Mono.Unix.Catalog.GetString("Agregar"), null, null);
		this.AgregarAction5.ShortLabel = global::Mono.Unix.Catalog.GetString("Agregar");
		w1.Add(this.AgregarAction5, null);
		this.DeduccionesAction = new global::Gtk.Action("DeduccionesAction", global::Mono.Unix.Catalog.GetString("Deducciones"), null, null);
		this.DeduccionesAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Deducciones");
		w1.Add(this.DeduccionesAction, null);
		this.AgregarAction6 = new global::Gtk.Action("AgregarAction6", global::Mono.Unix.Catalog.GetString("Agregar"), null, null);
		this.AgregarAction6.ShortLabel = global::Mono.Unix.Catalog.GetString("Agregar");
		w1.Add(this.AgregarAction6, null);
		this.AyudaAction = new global::Gtk.Action("AyudaAction", global::Mono.Unix.Catalog.GetString("Ayuda"), null, null);
		this.AyudaAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Ayuda");
		w1.Add(this.AyudaAction, null);
		this.VisualizarAction7 = new global::Gtk.Action("VisualizarAction7", global::Mono.Unix.Catalog.GetString("Visualizar"), null, null);
		this.VisualizarAction7.ShortLabel = global::Mono.Unix.Catalog.GetString("Visualizar");
		w1.Add(this.VisualizarAction7, null);
		this.DetalleDeEmpleadoAction1 = new global::Gtk.Action("DetalleDeEmpleadoAction1", global::Mono.Unix.Catalog.GetString("Detalle de Empleado"), null, null);
		this.DetalleDeEmpleadoAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Detalle de Empleado");
		w1.Add(this.DetalleDeEmpleadoAction1, null);
		this.dsAction = new global::Gtk.Action("dsAction", global::Mono.Unix.Catalog.GetString("ds"), null, null);
		this.dsAction.ShortLabel = global::Mono.Unix.Catalog.GetString("ds");
		w1.Add(this.dsAction, null);
		this.UIManager.InsertActionGroup(w1, 0);
		this.AddAccelGroup(this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.colorbutton2 = new global::Gtk.ColorButton();
		this.colorbutton2.CanFocus = true;
		this.colorbutton2.Events = ((global::Gdk.EventMask)(784));
		this.colorbutton2.Name = "colorbutton2";
		this.hbox1.Add(this.colorbutton2);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.colorbutton2]));
		w2.Position = 0;
		w2.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.label3 = new global::Gtk.Label();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("SISTEMA DE NÓMINA");
		this.hbox1.Add(this.label3);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label3]));
		w3.Position = 1;
		w3.Expand = false;
		w3.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.colorbutton3 = new global::Gtk.ColorButton();
		this.colorbutton3.CanFocus = true;
		this.colorbutton3.Events = ((global::Gdk.EventMask)(784));
		this.colorbutton3.Name = "colorbutton3";
		this.hbox1.Add(this.colorbutton3);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.colorbutton3]));
		w4.Position = 2;
		w4.Fill = false;
		this.vbox1.Add(this.hbox1);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString("<ui><menubar name=\'menubar1\'><menu name=\'InicioAction\' action=\'InicioAction\'><men" +
				"uitem name=\'PanelAction\' action=\'PanelAction\'/></menu><menu name=\'UsuarioAction\'" +
				" action=\'UsuarioAction\'><menuitem name=\'AgregarAction\' action=\'AgregarAction\'/><" +
				"menuitem name=\'VisualizarAction\' action=\'VisualizarAction\'/><menuitem name=\'Modi" +
				"ficarAction\' action=\'ModificarAction\'/><menuitem name=\'EliminarAction\' action=\'E" +
				"liminarAction\'/></menu><menu name=\'EmpleadoAction\' action=\'EmpleadoAction\'><menu" +
				"item name=\'AgregarAction1\' action=\'AgregarAction1\'/><menuitem name=\'VisualizarAc" +
				"tion1\' action=\'VisualizarAction1\'/><menuitem name=\'BorrarAction\' action=\'BorrarA" +
				"ction\'/></menu><menu name=\'NminaAction\' action=\'NminaAction\'><menu name=\'Opcione" +
				"sAction\' action=\'OpcionesAction\'><menu name=\'PlantillasAction\' action=\'Plantilla" +
				"sAction\'><menuitem name=\'VisualizarAction7\' action=\'VisualizarAction7\'/><menuite" +
				"m name=\'DetalleDeEmpleadoAction1\' action=\'DetalleDeEmpleadoAction1\'/></menu><men" +
				"u name=\'PagosAction\' action=\'PagosAction\'><menuitem name=\'AgregarAction4\' action" +
				"=\'AgregarAction4\'/><menuitem name=\'VisualizarAction5\' action=\'VisualizarAction5\'" +
				"/></menu><menu name=\'ExtrasAction\' action=\'ExtrasAction\'><menuitem name=\'Agregar" +
				"Action5\' action=\'AgregarAction5\'/></menu><menu name=\'DeduccionesAction\' action=\'" +
				"DeduccionesAction\'><menuitem name=\'AgregarAction6\' action=\'AgregarAction6\'/></me" +
				"nu></menu></menu><menu name=\'ConfiguracinAction\' action=\'ConfiguracinAction\'><me" +
				"nu name=\'EmpresaAction\' action=\'EmpresaAction\'><menuitem name=\'AgregarAction2\' a" +
				"ction=\'AgregarAction2\'/><menuitem name=\'VisualizarAction3\' action=\'VisualizarAct" +
				"ion3\'/><menuitem name=\'EditarAction1\' action=\'EditarAction1\'/></menu><menu name=" +
				"\'SucursalAction\' action=\'SucursalAction\'><menuitem name=\'AgregarAction3\' action=" +
				"\'AgregarAction3\'/><menuitem name=\'VisualizarAction4\' action=\'VisualizarAction4\'/" +
				"><menuitem name=\'EditarAction2\' action=\'EditarAction2\'/></menu></menu><menu name" +
				"=\'AyudaAction\' action=\'AyudaAction\'/></menubar></ui>");
		this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget("/menubar1")));
		this.menubar1.Name = "menubar1";
		this.vbox1.Add(this.menubar1);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.menubar1]));
		w6.Position = 1;
		w6.Expand = false;
		w6.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.vbox3 = new global::Gtk.VBox();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.alignment1 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
		this.alignment1.Name = "alignment1";
		this.vbox3.Add(this.alignment1);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.alignment1]));
		w7.Position = 0;
		// Container child vbox3.Gtk.Box+BoxChild
		this.alignment2 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
		this.alignment2.Name = "alignment2";
		this.vbox3.Add(this.alignment2);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.alignment2]));
		w8.Position = 1;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.alignment3 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
		this.alignment3.Name = "alignment3";
		this.hbox4.Add(this.alignment3);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.alignment3]));
		w9.Position = 0;
		// Container child hbox4.Gtk.Box+BoxChild
		this.alignment4 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
		this.alignment4.Name = "alignment4";
		this.hbox4.Add(this.alignment4);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.alignment4]));
		w10.Position = 1;
		// Container child hbox4.Gtk.Box+BoxChild
		this.btnSalir = new global::Gtk.Button();
		this.btnSalir.CanFocus = true;
		this.btnSalir.Name = "btnSalir";
		this.btnSalir.UseUnderline = true;
		this.btnSalir.Label = global::Mono.Unix.Catalog.GetString("Salir del Sistema");
		this.hbox4.Add(this.btnSalir);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.btnSalir]));
		w11.Position = 2;
		w11.Expand = false;
		w11.Fill = false;
		this.vbox3.Add(this.hbox4);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox4]));
		w12.Position = 2;
		w12.Expand = false;
		w12.Fill = false;
		this.vbox1.Add(this.vbox3);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.vbox3]));
		w13.Position = 2;
		this.Add(this.vbox1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 765;
		this.DefaultHeight = 300;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.AgregarAction.Activated += new global::System.EventHandler(this.OnAgregarActionActivated);
		this.VisualizarAction.Activated += new global::System.EventHandler(this.OnVisualizarActionActivated);
		this.ModificarAction.Activated += new global::System.EventHandler(this.OnModificarActionActivated);
		this.EliminarAction.Activated += new global::System.EventHandler(this.OnEliminarActionActivated);
		this.AgregarAction1.Activated += new global::System.EventHandler(this.OnAgregarAction1Activated);
		this.VisualizarAction1.Activated += new global::System.EventHandler(this.OnVisualizarAction1Activated);
		this.BorrarAction.Activated += new global::System.EventHandler(this.OnBorrarActionActivated);
		this.AgregarAction2.Activated += new global::System.EventHandler(this.OnAgregarAction2Activated);
		this.VisualizarAction3.Activated += new global::System.EventHandler(this.OnVisualizarAction3Activated);
		this.EditarAction1.Activated += new global::System.EventHandler(this.OnEditarAction1Activated);
		this.AgregarAction3.Activated += new global::System.EventHandler(this.OnAgregarAction3Activated);
		this.VisualizarAction4.Activated += new global::System.EventHandler(this.OnVisualizarAction4Activated);
		this.EditarAction2.Activated += new global::System.EventHandler(this.OnEditarAction2Activated);
		this.AgregarAction4.Activated += new global::System.EventHandler(this.OnAgregarAction4Activated);
		this.VisualizarAction5.Activated += new global::System.EventHandler(this.OnVisualizarAction5Activated);
		this.AgregarAction5.Activated += new global::System.EventHandler(this.OnAgregarAction5Activated);
		this.AgregarAction6.Activated += new global::System.EventHandler(this.OnAgregarAction6Activated);
		this.VisualizarAction7.Activated += new global::System.EventHandler(this.OnVisualizarAction7Activated);
		this.DetalleDeEmpleadoAction1.Activated += new global::System.EventHandler(this.OnDetalleDeEmpleadoAction1Activated);
		this.btnSalir.Clicked += new global::System.EventHandler(this.OnBtnSalirClicked);
	}
}
