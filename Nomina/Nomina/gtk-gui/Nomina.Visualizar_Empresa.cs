
// This file has been generated by the GUI designer. Do not modify.
namespace Nomina
{
	public partial class Visualizar_Empresa
	{
		private global::Gtk.UIManager UIManager;

		private global::Gtk.Action INICIOAction;

		private global::Gtk.Action MENAction;

		private global::Gtk.Action findAction;

		private global::Gtk.VBox vbox18;

		private global::Gtk.MenuBar menubar12;

		private global::Gtk.Frame frame12;

		private global::Gtk.Alignment GtkAlignment;

		private global::Gtk.HBox hbox40;

		private global::Gtk.Label label15;

		private global::Gtk.Entry entry12;

		private global::Gtk.HBox hbox41;

		private global::Gtk.Toolbar toolbar1;

		private global::Gtk.Label label16;

		private global::Gtk.HBox hbox42;

		private global::Gtk.CheckButton checkbutton1;

		private global::Gtk.CheckButton checkbutton2;

		private global::Gtk.Alignment alignment17;

		private global::Gtk.Button button13;

		private global::Gtk.Label GtkLabel6;

		private global::Gtk.VBox vbox19;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TreeView treeview5;

		private global::Gtk.HSeparator hseparator15;

		private global::Gtk.HBox hbox43;

		private global::Gtk.Label label17;

		private global::Gtk.Entry entry13;

		private global::Gtk.HBox hbox44;

		private global::Gtk.Alignment alignment18;

		private global::Gtk.Alignment alignment19;

		private global::Gtk.Alignment alignment20;

		private global::Gtk.Button button14;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Nomina.Visualizar_Empresa
			this.UIManager = new global::Gtk.UIManager();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
			this.INICIOAction = new global::Gtk.Action("INICIOAction", global::Mono.Unix.Catalog.GetString("INICIO"), null, null);
			this.INICIOAction.ShortLabel = global::Mono.Unix.Catalog.GetString("INICIO");
			w1.Add(this.INICIOAction, null);
			this.MENAction = new global::Gtk.Action("MENAction", global::Mono.Unix.Catalog.GetString("MENÚ"), null, null);
			this.MENAction.ShortLabel = global::Mono.Unix.Catalog.GetString("MENÚ");
			w1.Add(this.MENAction, null);
			this.findAction = new global::Gtk.Action("findAction", null, null, "gtk-find");
			this.findAction.ShortLabel = "";
			w1.Add(this.findAction, null);
			this.UIManager.InsertActionGroup(w1, 0);
			this.AddAccelGroup(this.UIManager.AccelGroup);
			this.Name = "Nomina.Visualizar_Empresa";
			this.Title = global::Mono.Unix.Catalog.GetString("Visualizar_Empresa");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child Nomina.Visualizar_Empresa.Gtk.Container+ContainerChild
			this.vbox18 = new global::Gtk.VBox();
			this.vbox18.Name = "vbox18";
			this.vbox18.Spacing = 6;
			// Container child vbox18.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString("<ui><menubar name=\'menubar12\'><menu name=\'INICIOAction\' action=\'INICIOAction\'/><m" +
					"enu name=\'MENAction\' action=\'MENAction\'/></menubar></ui>");
			this.menubar12 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget("/menubar12")));
			this.menubar12.Name = "menubar12";
			this.vbox18.Add(this.menubar12);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox18[this.menubar12]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox18.Gtk.Box+BoxChild
			this.frame12 = new global::Gtk.Frame();
			this.frame12.Name = "frame12";
			this.frame12.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame12.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.hbox40 = new global::Gtk.HBox();
			this.hbox40.Name = "hbox40";
			this.hbox40.Spacing = 6;
			// Container child hbox40.Gtk.Box+BoxChild
			this.label15 = new global::Gtk.Label();
			this.label15.Name = "label15";
			this.label15.LabelProp = global::Mono.Unix.Catalog.GetString("Buscar");
			this.hbox40.Add(this.label15);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox40[this.label15]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox40.Gtk.Box+BoxChild
			this.entry12 = new global::Gtk.Entry();
			this.entry12.CanFocus = true;
			this.entry12.Name = "entry12";
			this.entry12.IsEditable = true;
			this.entry12.InvisibleChar = '•';
			this.hbox40.Add(this.entry12);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox40[this.entry12]));
			w4.Position = 1;
			// Container child hbox40.Gtk.Box+BoxChild
			this.hbox41 = new global::Gtk.HBox();
			this.hbox41.Name = "hbox41";
			this.hbox41.Spacing = 6;
			// Container child hbox41.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString("<ui><toolbar name=\'toolbar1\'><toolitem/><toolitem name=\'findAction\' action=\'findA" +
					"ction\'/></toolbar></ui>");
			this.toolbar1 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget("/toolbar1")));
			this.toolbar1.Name = "toolbar1";
			this.toolbar1.ShowArrow = false;
			this.hbox41.Add(this.toolbar1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox41[this.toolbar1]));
			w5.Position = 0;
			// Container child hbox41.Gtk.Box+BoxChild
			this.label16 = new global::Gtk.Label();
			this.label16.Name = "label16";
			this.label16.LabelProp = global::Mono.Unix.Catalog.GetString("Ordenar por:");
			this.hbox41.Add(this.label16);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox41[this.label16]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hbox41.Gtk.Box+BoxChild
			this.hbox42 = new global::Gtk.HBox();
			this.hbox42.Name = "hbox42";
			this.hbox42.Spacing = 6;
			// Container child hbox42.Gtk.Box+BoxChild
			this.checkbutton1 = new global::Gtk.CheckButton();
			this.checkbutton1.CanFocus = true;
			this.checkbutton1.Name = "checkbutton1";
			this.checkbutton1.Label = global::Mono.Unix.Catalog.GetString("Ascendente");
			this.checkbutton1.Active = true;
			this.checkbutton1.DrawIndicator = true;
			this.checkbutton1.UseUnderline = true;
			this.hbox42.Add(this.checkbutton1);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox42[this.checkbutton1]));
			w7.Position = 0;
			// Container child hbox42.Gtk.Box+BoxChild
			this.checkbutton2 = new global::Gtk.CheckButton();
			this.checkbutton2.CanFocus = true;
			this.checkbutton2.Name = "checkbutton2";
			this.checkbutton2.Label = global::Mono.Unix.Catalog.GetString("Descendente");
			this.checkbutton2.DrawIndicator = true;
			this.checkbutton2.UseUnderline = true;
			this.hbox42.Add(this.checkbutton2);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox42[this.checkbutton2]));
			w8.Position = 1;
			// Container child hbox42.Gtk.Box+BoxChild
			this.alignment17 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment17.Name = "alignment17";
			this.hbox42.Add(this.alignment17);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox42[this.alignment17]));
			w9.Position = 2;
			// Container child hbox42.Gtk.Box+BoxChild
			this.button13 = new global::Gtk.Button();
			this.button13.CanFocus = true;
			this.button13.Name = "button13";
			this.button13.UseUnderline = true;
			this.button13.Label = global::Mono.Unix.Catalog.GetString("Agregar");
			this.hbox42.Add(this.button13);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox42[this.button13]));
			w10.Position = 3;
			w10.Expand = false;
			w10.Fill = false;
			this.hbox41.Add(this.hbox42);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox41[this.hbox42]));
			w11.Position = 2;
			this.hbox40.Add(this.hbox41);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox40[this.hbox41]));
			w12.Position = 2;
			this.GtkAlignment.Add(this.hbox40);
			this.frame12.Add(this.GtkAlignment);
			this.GtkLabel6 = new global::Gtk.Label();
			this.GtkLabel6.Name = "GtkLabel6";
			this.GtkLabel6.LabelProp = global::Mono.Unix.Catalog.GetString("EMPRESAS");
			this.GtkLabel6.UseMarkup = true;
			this.frame12.LabelWidget = this.GtkLabel6;
			this.vbox18.Add(this.frame12);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox18[this.frame12]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox18.Gtk.Box+BoxChild
			this.vbox19 = new global::Gtk.VBox();
			this.vbox19.Name = "vbox19";
			this.vbox19.Spacing = 6;
			// Container child vbox19.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeview5 = new global::Gtk.TreeView();
			this.treeview5.CanFocus = true;
			this.treeview5.Name = "treeview5";
			this.GtkScrolledWindow.Add(this.treeview5);
			this.vbox19.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox19[this.GtkScrolledWindow]));
			w17.Position = 0;
			// Container child vbox19.Gtk.Box+BoxChild
			this.hseparator15 = new global::Gtk.HSeparator();
			this.hseparator15.Name = "hseparator15";
			this.vbox19.Add(this.hseparator15);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox19[this.hseparator15]));
			w18.Position = 1;
			w18.Expand = false;
			w18.Fill = false;
			// Container child vbox19.Gtk.Box+BoxChild
			this.hbox43 = new global::Gtk.HBox();
			this.hbox43.Name = "hbox43";
			this.hbox43.Spacing = 6;
			// Container child hbox43.Gtk.Box+BoxChild
			this.label17 = new global::Gtk.Label();
			this.label17.Name = "label17";
			this.label17.LabelProp = global::Mono.Unix.Catalog.GetString("Nombre:");
			this.hbox43.Add(this.label17);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox43[this.label17]));
			w19.Position = 0;
			w19.Expand = false;
			w19.Fill = false;
			// Container child hbox43.Gtk.Box+BoxChild
			this.entry13 = new global::Gtk.Entry();
			this.entry13.CanFocus = true;
			this.entry13.Name = "entry13";
			this.entry13.IsEditable = true;
			this.entry13.InvisibleChar = '•';
			this.hbox43.Add(this.entry13);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox43[this.entry13]));
			w20.Position = 1;
			w20.Expand = false;
			// Container child hbox43.Gtk.Box+BoxChild
			this.hbox44 = new global::Gtk.HBox();
			this.hbox44.Name = "hbox44";
			this.hbox44.Spacing = 6;
			// Container child hbox44.Gtk.Box+BoxChild
			this.alignment18 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment18.Name = "alignment18";
			this.hbox44.Add(this.alignment18);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox44[this.alignment18]));
			w21.Position = 0;
			// Container child hbox44.Gtk.Box+BoxChild
			this.alignment19 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment19.Name = "alignment19";
			// Container child alignment19.Gtk.Container+ContainerChild
			this.alignment20 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment20.Name = "alignment20";
			this.alignment19.Add(this.alignment20);
			this.hbox44.Add(this.alignment19);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox44[this.alignment19]));
			w23.Position = 1;
			// Container child hbox44.Gtk.Box+BoxChild
			this.button14 = new global::Gtk.Button();
			this.button14.CanFocus = true;
			this.button14.Name = "button14";
			this.button14.UseUnderline = true;
			this.button14.Label = global::Mono.Unix.Catalog.GetString("Editar");
			this.hbox44.Add(this.button14);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox44[this.button14]));
			w24.Position = 2;
			w24.Expand = false;
			w24.Fill = false;
			this.hbox43.Add(this.hbox44);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox43[this.hbox44]));
			w25.Position = 2;
			this.vbox19.Add(this.hbox43);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox19[this.hbox43]));
			w26.Position = 2;
			w26.Expand = false;
			w26.Fill = false;
			this.vbox18.Add(this.vbox19);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox18[this.vbox19]));
			w27.Position = 2;
			this.Add(this.vbox18);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 824;
			this.DefaultHeight = 300;
			this.Show();
		}
	}
}