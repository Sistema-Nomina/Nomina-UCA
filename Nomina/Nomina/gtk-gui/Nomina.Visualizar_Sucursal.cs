
// This file has been generated by the GUI designer. Do not modify.
namespace Nomina
{
	public partial class Visualizar_Sucursal
	{
		private global::Gtk.UIManager UIManager;

		private global::Gtk.Action INICIOAction;

		private global::Gtk.Action MENAction;

		private global::Gtk.Action findAction;

		private global::Gtk.Action findAndReplaceAction;

		private global::Gtk.VBox vbox22;

		private global::Gtk.MenuBar menubar15;

		private global::Gtk.Frame frame15;

		private global::Gtk.Alignment GtkAlignment;

		private global::Gtk.HBox hbox47;

		private global::Gtk.Label label15;

		private global::Gtk.Entry entry12;

		private global::Gtk.HBox hbox48;

		private global::Gtk.Toolbar toolbar1;

		private global::Gtk.Label label16;

		private global::Gtk.HBox hbox49;

		private global::Gtk.CheckButton checkbutton1;

		private global::Gtk.CheckButton checkbutton2;

		private global::Gtk.Button button13;

		private global::Gtk.Label GtkLabel6;

		private global::Gtk.HBox hbox50;

		private global::Gtk.Label label61;

		private global::Gtk.HBox hbox4;

		private global::Gtk.ComboBox cmbEmpresa;

		private global::Gtk.HBox hbox5;

		private global::Gtk.Alignment alignment3;

		private global::Gtk.Button btnBuscarEmpresa;

		private global::Gtk.HSeparator hseparator17;

		private global::Gtk.VBox vbox23;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TreeView trvSucursal;

		private global::Gtk.HSeparator hseparator18;

		private global::Gtk.HBox hbox51;

		private global::Gtk.Label label17;

		private global::Gtk.Entry entry13;

		private global::Gtk.Alignment alignment21;

		private global::Gtk.Button button14;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Nomina.Visualizar_Sucursal
			this.UIManager = new global::Gtk.UIManager();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
			this.INICIOAction = new global::Gtk.Action("INICIOAction", global::Mono.Unix.Catalog.GetString("INICIO"), null, null);
			this.INICIOAction.ShortLabel = global::Mono.Unix.Catalog.GetString("INICIO");
			w1.Add(this.INICIOAction, null);
			this.MENAction = new global::Gtk.Action("MENAction", global::Mono.Unix.Catalog.GetString("MENÚ"), null, null);
			this.MENAction.ShortLabel = global::Mono.Unix.Catalog.GetString("MENÚ");
			w1.Add(this.MENAction, null);
			this.findAction = new global::Gtk.Action("findAction", null, null, "gtk-find");
			w1.Add(this.findAction, null);
			this.findAndReplaceAction = new global::Gtk.Action("findAndReplaceAction", null, null, "gtk-find-and-replace");
			w1.Add(this.findAndReplaceAction, null);
			this.UIManager.InsertActionGroup(w1, 0);
			this.AddAccelGroup(this.UIManager.AccelGroup);
			this.Name = "Nomina.Visualizar_Sucursal";
			this.Title = global::Mono.Unix.Catalog.GetString("Visualizar_Sucursal");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child Nomina.Visualizar_Sucursal.Gtk.Container+ContainerChild
			this.vbox22 = new global::Gtk.VBox();
			this.vbox22.Name = "vbox22";
			this.vbox22.Spacing = 6;
			// Container child vbox22.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString("<ui><menubar name=\'menubar15\'><menu name=\'INICIOAction\' action=\'INICIOAction\'/><m" +
					"enu name=\'MENAction\' action=\'MENAction\'/></menubar></ui>");
			this.menubar15 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget("/menubar15")));
			this.menubar15.Name = "menubar15";
			this.vbox22.Add(this.menubar15);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox22[this.menubar15]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox22.Gtk.Box+BoxChild
			this.frame15 = new global::Gtk.Frame();
			this.frame15.Name = "frame15";
			this.frame15.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame15.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.hbox47 = new global::Gtk.HBox();
			this.hbox47.Name = "hbox47";
			this.hbox47.Spacing = 6;
			// Container child hbox47.Gtk.Box+BoxChild
			this.label15 = new global::Gtk.Label();
			this.label15.Name = "label15";
			this.label15.LabelProp = global::Mono.Unix.Catalog.GetString("Buscar");
			this.hbox47.Add(this.label15);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox47[this.label15]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox47.Gtk.Box+BoxChild
			this.entry12 = new global::Gtk.Entry();
			this.entry12.CanFocus = true;
			this.entry12.Name = "entry12";
			this.entry12.IsEditable = true;
			this.entry12.InvisibleChar = '•';
			this.hbox47.Add(this.entry12);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox47[this.entry12]));
			w4.Position = 1;
			// Container child hbox47.Gtk.Box+BoxChild
			this.hbox48 = new global::Gtk.HBox();
			this.hbox48.Name = "hbox48";
			this.hbox48.Spacing = 6;
			// Container child hbox48.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString("<ui><toolbar name=\'toolbar1\'><toolitem/><toolitem/><toolitem name=\'findAndReplace" +
					"Action\' action=\'findAndReplaceAction\'/></toolbar></ui>");
			this.toolbar1 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget("/toolbar1")));
			this.toolbar1.Name = "toolbar1";
			this.toolbar1.ShowArrow = false;
			this.hbox48.Add(this.toolbar1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox48[this.toolbar1]));
			w5.Position = 0;
			// Container child hbox48.Gtk.Box+BoxChild
			this.label16 = new global::Gtk.Label();
			this.label16.Name = "label16";
			this.label16.LabelProp = global::Mono.Unix.Catalog.GetString("Ordenar por:");
			this.hbox48.Add(this.label16);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox48[this.label16]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hbox48.Gtk.Box+BoxChild
			this.hbox49 = new global::Gtk.HBox();
			this.hbox49.Name = "hbox49";
			this.hbox49.Spacing = 6;
			// Container child hbox49.Gtk.Box+BoxChild
			this.checkbutton1 = new global::Gtk.CheckButton();
			this.checkbutton1.CanFocus = true;
			this.checkbutton1.Name = "checkbutton1";
			this.checkbutton1.Label = global::Mono.Unix.Catalog.GetString("Ascendente");
			this.checkbutton1.Active = true;
			this.checkbutton1.DrawIndicator = true;
			this.checkbutton1.UseUnderline = true;
			this.hbox49.Add(this.checkbutton1);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox49[this.checkbutton1]));
			w7.Position = 0;
			// Container child hbox49.Gtk.Box+BoxChild
			this.checkbutton2 = new global::Gtk.CheckButton();
			this.checkbutton2.CanFocus = true;
			this.checkbutton2.Name = "checkbutton2";
			this.checkbutton2.Label = global::Mono.Unix.Catalog.GetString("Descendente");
			this.checkbutton2.DrawIndicator = true;
			this.checkbutton2.UseUnderline = true;
			this.hbox49.Add(this.checkbutton2);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox49[this.checkbutton2]));
			w8.Position = 1;
			// Container child hbox49.Gtk.Box+BoxChild
			this.button13 = new global::Gtk.Button();
			this.button13.CanFocus = true;
			this.button13.Name = "button13";
			this.button13.UseUnderline = true;
			this.button13.Label = global::Mono.Unix.Catalog.GetString("Agregar");
			this.hbox49.Add(this.button13);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox49[this.button13]));
			w9.Position = 3;
			w9.Expand = false;
			w9.Fill = false;
			this.hbox48.Add(this.hbox49);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox48[this.hbox49]));
			w10.Position = 2;
			this.hbox47.Add(this.hbox48);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox47[this.hbox48]));
			w11.Position = 2;
			this.GtkAlignment.Add(this.hbox47);
			this.frame15.Add(this.GtkAlignment);
			this.GtkLabel6 = new global::Gtk.Label();
			this.GtkLabel6.Name = "GtkLabel6";
			this.GtkLabel6.LabelProp = global::Mono.Unix.Catalog.GetString("SUCURSALES");
			this.GtkLabel6.UseMarkup = true;
			this.frame15.LabelWidget = this.GtkLabel6;
			this.vbox22.Add(this.frame15);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox22[this.frame15]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			// Container child vbox22.Gtk.Box+BoxChild
			this.hbox50 = new global::Gtk.HBox();
			this.hbox50.Name = "hbox50";
			this.hbox50.Spacing = 6;
			// Container child hbox50.Gtk.Box+BoxChild
			this.label61 = new global::Gtk.Label();
			this.label61.Name = "label61";
			this.label61.LabelProp = global::Mono.Unix.Catalog.GetString("Buscar por Empresa");
			this.hbox50.Add(this.label61);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox50[this.label61]));
			w15.Position = 0;
			w15.Expand = false;
			w15.Fill = false;
			// Container child hbox50.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.cmbEmpresa = global::Gtk.ComboBox.NewText();
			this.cmbEmpresa.Name = "cmbEmpresa";
			this.hbox4.Add(this.cmbEmpresa);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.cmbEmpresa]));
			w16.Position = 0;
			// Container child hbox4.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.alignment3 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment3.Name = "alignment3";
			this.hbox5.Add(this.alignment3);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.alignment3]));
			w17.Position = 0;
			// Container child hbox5.Gtk.Box+BoxChild
			this.btnBuscarEmpresa = new global::Gtk.Button();
			this.btnBuscarEmpresa.CanFocus = true;
			this.btnBuscarEmpresa.Name = "btnBuscarEmpresa";
			this.btnBuscarEmpresa.UseUnderline = true;
			this.btnBuscarEmpresa.Label = global::Mono.Unix.Catalog.GetString("Buscar por Empresa");
			this.hbox5.Add(this.btnBuscarEmpresa);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.btnBuscarEmpresa]));
			w18.Position = 1;
			w18.Fill = false;
			this.hbox4.Add(this.hbox5);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.hbox5]));
			w19.Position = 1;
			this.hbox50.Add(this.hbox4);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox50[this.hbox4]));
			w20.Position = 1;
			// Container child hbox50.Gtk.Box+BoxChild
			this.hseparator17 = new global::Gtk.HSeparator();
			this.hseparator17.Name = "hseparator17";
			this.hbox50.Add(this.hseparator17);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox50[this.hseparator17]));
			w21.Position = 2;
			this.vbox22.Add(this.hbox50);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox22[this.hbox50]));
			w22.Position = 2;
			w22.Expand = false;
			w22.Fill = false;
			// Container child vbox22.Gtk.Box+BoxChild
			this.vbox23 = new global::Gtk.VBox();
			this.vbox23.Name = "vbox23";
			this.vbox23.Spacing = 6;
			// Container child vbox23.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.trvSucursal = new global::Gtk.TreeView();
			this.trvSucursal.CanFocus = true;
			this.trvSucursal.Name = "trvSucursal";
			this.GtkScrolledWindow.Add(this.trvSucursal);
			this.vbox23.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox23[this.GtkScrolledWindow]));
			w24.Position = 0;
			// Container child vbox23.Gtk.Box+BoxChild
			this.hseparator18 = new global::Gtk.HSeparator();
			this.hseparator18.Name = "hseparator18";
			this.vbox23.Add(this.hseparator18);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox23[this.hseparator18]));
			w25.Position = 1;
			w25.Expand = false;
			w25.Fill = false;
			// Container child vbox23.Gtk.Box+BoxChild
			this.hbox51 = new global::Gtk.HBox();
			this.hbox51.Name = "hbox51";
			this.hbox51.Spacing = 6;
			// Container child hbox51.Gtk.Box+BoxChild
			this.label17 = new global::Gtk.Label();
			this.label17.Name = "label17";
			this.label17.LabelProp = global::Mono.Unix.Catalog.GetString("Nombre:");
			this.hbox51.Add(this.label17);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox51[this.label17]));
			w26.Position = 0;
			w26.Expand = false;
			w26.Fill = false;
			// Container child hbox51.Gtk.Box+BoxChild
			this.entry13 = new global::Gtk.Entry();
			this.entry13.CanFocus = true;
			this.entry13.Name = "entry13";
			this.entry13.IsEditable = true;
			this.entry13.InvisibleChar = '•';
			this.hbox51.Add(this.entry13);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox51[this.entry13]));
			w27.Position = 1;
			w27.Expand = false;
			// Container child hbox51.Gtk.Box+BoxChild
			this.alignment21 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment21.Name = "alignment21";
			this.hbox51.Add(this.alignment21);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox51[this.alignment21]));
			w28.Position = 2;
			// Container child hbox51.Gtk.Box+BoxChild
			this.button14 = new global::Gtk.Button();
			this.button14.CanFocus = true;
			this.button14.Name = "button14";
			this.button14.UseUnderline = true;
			this.button14.Label = global::Mono.Unix.Catalog.GetString("Editar");
			this.hbox51.Add(this.button14);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox51[this.button14]));
			w29.Position = 3;
			w29.Expand = false;
			w29.Fill = false;
			this.vbox23.Add(this.hbox51);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox23[this.hbox51]));
			w30.Position = 2;
			w30.Expand = false;
			w30.Fill = false;
			this.vbox22.Add(this.vbox23);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox22[this.vbox23]));
			w31.Position = 3;
			this.Add(this.vbox22);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 770;
			this.DefaultHeight = 300;
			this.Show();
			this.btnBuscarEmpresa.Clicked += new global::System.EventHandler(this.OnBtnBuscarEmpresaClicked);
		}
	}
}
