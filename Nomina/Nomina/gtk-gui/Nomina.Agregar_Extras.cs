
// This file has been generated by the GUI designer. Do not modify.
namespace Nomina
{
	public partial class Agregar_Extras
	{
		private global::Gtk.UIManager UIManager;

		private global::Gtk.Action InicioAction;

		private global::Gtk.Action MenAction;

		private global::Gtk.VBox vbox12;

		private global::Gtk.MenuBar menubar9;

		private global::Gtk.Frame frame9;

		private global::Gtk.Alignment GtkAlignment;

		private global::Gtk.HBox hbox35;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TreeView trvExtras;

		private global::Gtk.Label GtkLabel3;

		private global::Gtk.VBox vbox13;

		private global::Gtk.Table table8;

		private global::Gtk.HBox hbox36;

		private global::Gtk.Button btnGuardar;

		private global::Gtk.HSeparator hseparator7;

		private global::Gtk.HSeparator hseparator8;

		private global::Gtk.Label label50;

		private global::Gtk.Label label51;

		private global::Gtk.Label label52;

		private global::Gtk.Entry txtDescripcion;

		private global::Gtk.Entry txtNombre;

		private global::Gtk.Alignment alignment15;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Nomina.Agregar_Extras
			this.UIManager = new global::Gtk.UIManager();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
			this.InicioAction = new global::Gtk.Action("InicioAction", global::Mono.Unix.Catalog.GetString("Inicio"), null, null);
			this.InicioAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Inicio");
			w1.Add(this.InicioAction, null);
			this.MenAction = new global::Gtk.Action("MenAction", global::Mono.Unix.Catalog.GetString("Menú"), null, null);
			this.MenAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Menú");
			w1.Add(this.MenAction, null);
			this.UIManager.InsertActionGroup(w1, 0);
			this.AddAccelGroup(this.UIManager.AccelGroup);
			this.Name = "Nomina.Agregar_Extras";
			this.Title = global::Mono.Unix.Catalog.GetString("Agregar_Extras");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child Nomina.Agregar_Extras.Gtk.Container+ContainerChild
			this.vbox12 = new global::Gtk.VBox();
			this.vbox12.Name = "vbox12";
			this.vbox12.Spacing = 6;
			// Container child vbox12.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString("<ui><menubar name=\'menubar9\'><menu name=\'InicioAction\' action=\'InicioAction\'/><me" +
					"nu name=\'MenAction\' action=\'MenAction\'/></menubar></ui>");
			this.menubar9 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget("/menubar9")));
			this.menubar9.Name = "menubar9";
			this.vbox12.Add(this.menubar9);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.menubar9]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox12.Gtk.Box+BoxChild
			this.frame9 = new global::Gtk.Frame();
			this.frame9.Name = "frame9";
			this.frame9.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame9.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.hbox35 = new global::Gtk.HBox();
			this.hbox35.Name = "hbox35";
			this.hbox35.Spacing = 6;
			// Container child hbox35.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.trvExtras = new global::Gtk.TreeView();
			this.trvExtras.CanFocus = true;
			this.trvExtras.Name = "trvExtras";
			this.GtkScrolledWindow.Add(this.trvExtras);
			this.hbox35.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox35[this.GtkScrolledWindow]));
			w4.Position = 0;
			this.GtkAlignment.Add(this.hbox35);
			this.frame9.Add(this.GtkAlignment);
			this.GtkLabel3 = new global::Gtk.Label();
			this.GtkLabel3.Name = "GtkLabel3";
			this.GtkLabel3.LabelProp = global::Mono.Unix.Catalog.GetString("EXTRAS");
			this.GtkLabel3.UseMarkup = true;
			this.frame9.LabelWidget = this.GtkLabel3;
			this.vbox12.Add(this.frame9);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.frame9]));
			w7.Position = 1;
			// Container child vbox12.Gtk.Box+BoxChild
			this.vbox13 = new global::Gtk.VBox();
			this.vbox13.Name = "vbox13";
			this.vbox13.Spacing = 6;
			// Container child vbox13.Gtk.Box+BoxChild
			this.table8 = new global::Gtk.Table(((uint)(3)), ((uint)(3)), false);
			this.table8.Name = "table8";
			this.table8.RowSpacing = ((uint)(6));
			this.table8.ColumnSpacing = ((uint)(6));
			// Container child table8.Gtk.Table+TableChild
			this.hbox36 = new global::Gtk.HBox();
			this.hbox36.Name = "hbox36";
			this.hbox36.Spacing = 6;
			// Container child hbox36.Gtk.Box+BoxChild
			this.btnGuardar = new global::Gtk.Button();
			this.btnGuardar.CanFocus = true;
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.UseUnderline = true;
			this.btnGuardar.Label = global::Mono.Unix.Catalog.GetString("Guardar");
			this.hbox36.Add(this.btnGuardar);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox36[this.btnGuardar]));
			w8.Position = 0;
			w8.Fill = false;
			this.table8.Add(this.hbox36);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table8[this.hbox36]));
			w9.TopAttach = ((uint)(1));
			w9.BottomAttach = ((uint)(2));
			w9.LeftAttach = ((uint)(2));
			w9.RightAttach = ((uint)(3));
			w9.XOptions = ((global::Gtk.AttachOptions)(1));
			w9.YOptions = ((global::Gtk.AttachOptions)(1));
			// Container child table8.Gtk.Table+TableChild
			this.hseparator7 = new global::Gtk.HSeparator();
			this.hseparator7.Name = "hseparator7";
			this.table8.Add(this.hseparator7);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table8[this.hseparator7]));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table8.Gtk.Table+TableChild
			this.hseparator8 = new global::Gtk.HSeparator();
			this.hseparator8.Name = "hseparator8";
			this.table8.Add(this.hseparator8);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table8[this.hseparator8]));
			w11.LeftAttach = ((uint)(2));
			w11.RightAttach = ((uint)(3));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table8.Gtk.Table+TableChild
			this.label50 = new global::Gtk.Label();
			this.label50.Name = "label50";
			this.label50.LabelProp = global::Mono.Unix.Catalog.GetString("Agregar Extras");
			this.table8.Add(this.label50);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table8[this.label50]));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table8.Gtk.Table+TableChild
			this.label51 = new global::Gtk.Label();
			this.label51.Name = "label51";
			this.label51.Xalign = 1F;
			this.label51.LabelProp = global::Mono.Unix.Catalog.GetString("Nombre:");
			this.table8.Add(this.label51);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table8[this.label51]));
			w13.TopAttach = ((uint)(1));
			w13.BottomAttach = ((uint)(2));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table8.Gtk.Table+TableChild
			this.label52 = new global::Gtk.Label();
			this.label52.Name = "label52";
			this.label52.Xalign = 1F;
			this.label52.LabelProp = global::Mono.Unix.Catalog.GetString("Descripción:");
			this.table8.Add(this.label52);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table8[this.label52]));
			w14.TopAttach = ((uint)(2));
			w14.BottomAttach = ((uint)(3));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table8.Gtk.Table+TableChild
			this.txtDescripcion = new global::Gtk.Entry();
			this.txtDescripcion.CanFocus = true;
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.IsEditable = true;
			this.txtDescripcion.InvisibleChar = '•';
			this.table8.Add(this.txtDescripcion);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table8[this.txtDescripcion]));
			w15.TopAttach = ((uint)(2));
			w15.BottomAttach = ((uint)(3));
			w15.LeftAttach = ((uint)(1));
			w15.RightAttach = ((uint)(2));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table8.Gtk.Table+TableChild
			this.txtNombre = new global::Gtk.Entry();
			this.txtNombre.CanFocus = true;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.IsEditable = true;
			this.txtNombre.InvisibleChar = '•';
			this.table8.Add(this.txtNombre);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table8[this.txtNombre]));
			w16.TopAttach = ((uint)(1));
			w16.BottomAttach = ((uint)(2));
			w16.LeftAttach = ((uint)(1));
			w16.RightAttach = ((uint)(2));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox13.Add(this.table8);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.table8]));
			w17.Position = 0;
			w17.Expand = false;
			w17.Fill = false;
			// Container child vbox13.Gtk.Box+BoxChild
			this.alignment15 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment15.Name = "alignment15";
			this.vbox13.Add(this.alignment15);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.alignment15]));
			w18.Position = 1;
			this.vbox12.Add(this.vbox13);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.vbox13]));
			w19.Position = 2;
			this.Add(this.vbox12);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 490;
			this.DefaultHeight = 318;
			this.Show();
			this.btnGuardar.Clicked += new global::System.EventHandler(this.OnBtnGuardarClicked);
		}
	}
}
