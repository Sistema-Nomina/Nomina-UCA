
// This file has been generated by the GUI designer. Do not modify.
namespace Nomina
{
	public partial class Agregar_Empresa
	{
		private global::Gtk.UIManager UIManager;

		private global::Gtk.Action INICIOAction;

		private global::Gtk.Action MENAction;

		private global::Gtk.VBox vbox17;

		private global::Gtk.MenuBar menubar11;

		private global::Gtk.Frame frame11;

		private global::Gtk.Alignment GtkAlignment;

		private global::Gtk.HBox hbox39;

		private global::Gtk.Button button11;

		private global::Gtk.Button button12;

		private global::Gtk.HSeparator hseparator14;

		private global::Gtk.Label GtkLabel4;

		private global::Gtk.Table table12;

		private global::Gtk.Entry entry43;

		private global::Gtk.Entry entry44;

		private global::Gtk.Entry entry45;

		private global::Gtk.Entry entry46;

		private global::Gtk.Label label57;

		private global::Gtk.Label label59;

		private global::Gtk.Label label60;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Nomina.Agregar_Empresa
			this.UIManager = new global::Gtk.UIManager();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
			this.INICIOAction = new global::Gtk.Action("INICIOAction", global::Mono.Unix.Catalog.GetString("INICIO"), null, null);
			this.INICIOAction.ShortLabel = global::Mono.Unix.Catalog.GetString("INICIO");
			w1.Add(this.INICIOAction, null);
			this.MENAction = new global::Gtk.Action("MENAction", global::Mono.Unix.Catalog.GetString("MENÚ"), null, null);
			this.MENAction.ShortLabel = global::Mono.Unix.Catalog.GetString("MENÚ");
			w1.Add(this.MENAction, null);
			this.UIManager.InsertActionGroup(w1, 0);
			this.AddAccelGroup(this.UIManager.AccelGroup);
			this.Name = "Nomina.Agregar_Empresa";
			this.Title = global::Mono.Unix.Catalog.GetString("Agregar_Empresa");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child Nomina.Agregar_Empresa.Gtk.Container+ContainerChild
			this.vbox17 = new global::Gtk.VBox();
			this.vbox17.Name = "vbox17";
			this.vbox17.Spacing = 6;
			// Container child vbox17.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString("<ui><menubar name=\'menubar11\'><menu name=\'INICIOAction\' action=\'INICIOAction\'/><m" +
					"enu name=\'MENAction\' action=\'MENAction\'/></menubar></ui>");
			this.menubar11 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget("/menubar11")));
			this.menubar11.Name = "menubar11";
			this.vbox17.Add(this.menubar11);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox17[this.menubar11]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox17.Gtk.Box+BoxChild
			this.frame11 = new global::Gtk.Frame();
			this.frame11.Name = "frame11";
			this.frame11.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame11.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.hbox39 = new global::Gtk.HBox();
			this.hbox39.Name = "hbox39";
			this.hbox39.Spacing = 6;
			// Container child hbox39.Gtk.Box+BoxChild
			this.button11 = new global::Gtk.Button();
			this.button11.CanFocus = true;
			this.button11.Name = "button11";
			this.button11.UseUnderline = true;
			this.button11.BorderWidth = ((uint)(9));
			this.button11.Label = global::Mono.Unix.Catalog.GetString("Agregar ");
			this.hbox39.Add(this.button11);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox39[this.button11]));
			w3.Position = 0;
			// Container child hbox39.Gtk.Box+BoxChild
			this.button12 = new global::Gtk.Button();
			this.button12.CanFocus = true;
			this.button12.Name = "button12";
			this.button12.UseUnderline = true;
			this.button12.BorderWidth = ((uint)(9));
			this.button12.Label = global::Mono.Unix.Catalog.GetString("Listar");
			this.hbox39.Add(this.button12);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox39[this.button12]));
			w4.Position = 1;
			// Container child hbox39.Gtk.Box+BoxChild
			this.hseparator14 = new global::Gtk.HSeparator();
			this.hseparator14.Name = "hseparator14";
			this.hbox39.Add(this.hseparator14);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox39[this.hseparator14]));
			w5.Position = 2;
			this.GtkAlignment.Add(this.hbox39);
			this.frame11.Add(this.GtkAlignment);
			this.GtkLabel4 = new global::Gtk.Label();
			this.GtkLabel4.Name = "GtkLabel4";
			this.GtkLabel4.LabelProp = global::Mono.Unix.Catalog.GetString("EMPRESAS");
			this.GtkLabel4.UseMarkup = true;
			this.frame11.LabelWidget = this.GtkLabel4;
			this.vbox17.Add(this.frame11);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox17[this.frame11]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox17.Gtk.Box+BoxChild
			this.table12 = new global::Gtk.Table(((uint)(4)), ((uint)(2)), false);
			this.table12.Name = "table12";
			this.table12.RowSpacing = ((uint)(6));
			this.table12.ColumnSpacing = ((uint)(6));
			this.table12.BorderWidth = ((uint)(6));
			// Container child table12.Gtk.Table+TableChild
			this.entry43 = new global::Gtk.Entry();
			this.entry43.CanFocus = true;
			this.entry43.Name = "entry43";
			this.entry43.IsEditable = true;
			this.entry43.InvisibleChar = '•';
			this.table12.Add(this.entry43);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table12[this.entry43]));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table12.Gtk.Table+TableChild
			this.entry44 = new global::Gtk.Entry();
			this.entry44.CanFocus = true;
			this.entry44.Name = "entry44";
			this.entry44.IsEditable = true;
			this.entry44.InvisibleChar = '•';
			this.table12.Add(this.entry44);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table12[this.entry44]));
			w10.TopAttach = ((uint)(1));
			w10.BottomAttach = ((uint)(2));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table12.Gtk.Table+TableChild
			this.entry45 = new global::Gtk.Entry();
			this.entry45.CanFocus = true;
			this.entry45.Name = "entry45";
			this.entry45.IsEditable = true;
			this.entry45.InvisibleChar = '•';
			this.table12.Add(this.entry45);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table12[this.entry45]));
			w11.TopAttach = ((uint)(2));
			w11.BottomAttach = ((uint)(3));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table12.Gtk.Table+TableChild
			this.entry46 = new global::Gtk.Entry();
			this.entry46.CanFocus = true;
			this.entry46.Name = "entry46";
			this.entry46.IsEditable = true;
			this.entry46.InvisibleChar = '•';
			this.table12.Add(this.entry46);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table12[this.entry46]));
			w12.TopAttach = ((uint)(3));
			w12.BottomAttach = ((uint)(4));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table12.Gtk.Table+TableChild
			this.label57 = new global::Gtk.Label();
			this.label57.Name = "label57";
			this.label57.Xalign = 1F;
			this.label57.LabelProp = global::Mono.Unix.Catalog.GetString("RUC:");
			this.table12.Add(this.label57);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table12[this.label57]));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table12.Gtk.Table+TableChild
			this.label59 = new global::Gtk.Label();
			this.label59.Name = "label59";
			this.label59.Xalign = 1F;
			this.label59.LabelProp = global::Mono.Unix.Catalog.GetString("Teléfono:");
			this.table12.Add(this.label59);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table12[this.label59]));
			w14.TopAttach = ((uint)(2));
			w14.BottomAttach = ((uint)(3));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table12.Gtk.Table+TableChild
			this.label60 = new global::Gtk.Label();
			this.label60.Name = "label60";
			this.label60.Xalign = 1F;
			this.label60.LabelProp = global::Mono.Unix.Catalog.GetString("Dirección:");
			this.table12.Add(this.label60);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table12[this.label60]));
			w15.TopAttach = ((uint)(3));
			w15.BottomAttach = ((uint)(4));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox17.Add(this.table12);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox17[this.table12]));
			w16.Position = 2;
			this.Add(this.vbox17);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 450;
			this.DefaultHeight = 317;
			this.Show();
		}
	}
}