
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

		private global::Gtk.Button button9;

		private global::Gtk.Button button10;

		private global::Gtk.Label GtkLabel2;

		private global::Gtk.VBox vbox13;

		private global::Gtk.Table table8;

		private global::Gtk.Entry entry38;

		private global::Gtk.Entry entry39;

		private global::Gtk.HBox hbox36;

		private global::Gtk.Label label53;

		private global::Gtk.ComboBoxEntry comboboxentry2;

		private global::Gtk.HSeparator hseparator7;

		private global::Gtk.HSeparator hseparator8;

		private global::Gtk.Label label50;

		private global::Gtk.Label label51;

		private global::Gtk.Label label52;

		private global::Gtk.Alignment alignment15;

		private global::Gtk.Table table9;

		private global::Gtk.ComboBoxEntry comboboxentry3;

		private global::Gtk.Entry entry41;

		private global::Gtk.HSeparator hseparator9;

		private global::Gtk.Label label54;

		private global::Gtk.Label label55;

		private global::Gtk.Label label56;

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
			this.button9 = new global::Gtk.Button();
			this.button9.CanFocus = true;
			this.button9.Name = "button9";
			this.button9.UseUnderline = true;
			this.button9.Label = global::Mono.Unix.Catalog.GetString("Agregar Extra");
			this.hbox35.Add(this.button9);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox35[this.button9]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox35.Gtk.Box+BoxChild
			this.button10 = new global::Gtk.Button();
			this.button10.CanFocus = true;
			this.button10.Name = "button10";
			this.button10.UseUnderline = true;
			this.button10.Label = global::Mono.Unix.Catalog.GetString("Buscar Empleado");
			this.hbox35.Add(this.button10);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox35[this.button10]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			this.GtkAlignment.Add(this.hbox35);
			this.frame9.Add(this.GtkAlignment);
			this.GtkLabel2 = new global::Gtk.Label();
			this.GtkLabel2.Name = "GtkLabel2";
			this.GtkLabel2.LabelProp = global::Mono.Unix.Catalog.GetString("EXTRAS");
			this.GtkLabel2.UseMarkup = true;
			this.frame9.LabelWidget = this.GtkLabel2;
			this.vbox12.Add(this.frame9);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.frame9]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
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
			this.entry38 = new global::Gtk.Entry();
			this.entry38.CanFocus = true;
			this.entry38.Name = "entry38";
			this.entry38.IsEditable = true;
			this.entry38.InvisibleChar = '•';
			this.table8.Add(this.entry38);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table8[this.entry38]));
			w8.TopAttach = ((uint)(1));
			w8.BottomAttach = ((uint)(2));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table8.Gtk.Table+TableChild
			this.entry39 = new global::Gtk.Entry();
			this.entry39.CanFocus = true;
			this.entry39.Name = "entry39";
			this.entry39.IsEditable = true;
			this.entry39.InvisibleChar = '•';
			this.table8.Add(this.entry39);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table8[this.entry39]));
			w9.TopAttach = ((uint)(2));
			w9.BottomAttach = ((uint)(3));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table8.Gtk.Table+TableChild
			this.hbox36 = new global::Gtk.HBox();
			this.hbox36.Name = "hbox36";
			this.hbox36.Spacing = 6;
			// Container child hbox36.Gtk.Box+BoxChild
			this.label53 = new global::Gtk.Label();
			this.label53.Name = "label53";
			this.label53.LabelProp = global::Mono.Unix.Catalog.GetString("ID Pago:");
			this.hbox36.Add(this.label53);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox36[this.label53]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox36.Gtk.Box+BoxChild
			this.comboboxentry2 = global::Gtk.ComboBoxEntry.NewText();
			this.comboboxentry2.Name = "comboboxentry2";
			this.hbox36.Add(this.comboboxentry2);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox36[this.comboboxentry2]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			this.table8.Add(this.hbox36);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table8[this.hbox36]));
			w12.TopAttach = ((uint)(1));
			w12.BottomAttach = ((uint)(2));
			w12.LeftAttach = ((uint)(2));
			w12.RightAttach = ((uint)(3));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table8.Gtk.Table+TableChild
			this.hseparator7 = new global::Gtk.HSeparator();
			this.hseparator7.Name = "hseparator7";
			this.table8.Add(this.hseparator7);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table8[this.hseparator7]));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table8.Gtk.Table+TableChild
			this.hseparator8 = new global::Gtk.HSeparator();
			this.hseparator8.Name = "hseparator8";
			this.table8.Add(this.hseparator8);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table8[this.hseparator8]));
			w14.LeftAttach = ((uint)(2));
			w14.RightAttach = ((uint)(3));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table8.Gtk.Table+TableChild
			this.label50 = new global::Gtk.Label();
			this.label50.Name = "label50";
			this.label50.LabelProp = global::Mono.Unix.Catalog.GetString("Empleado");
			this.table8.Add(this.label50);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table8[this.label50]));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table8.Gtk.Table+TableChild
			this.label51 = new global::Gtk.Label();
			this.label51.Name = "label51";
			this.label51.LabelProp = global::Mono.Unix.Catalog.GetString("Nombre:");
			this.table8.Add(this.label51);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table8[this.label51]));
			w16.TopAttach = ((uint)(1));
			w16.BottomAttach = ((uint)(2));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table8.Gtk.Table+TableChild
			this.label52 = new global::Gtk.Label();
			this.label52.Name = "label52";
			this.label52.LabelProp = global::Mono.Unix.Catalog.GetString("Cédula:");
			this.table8.Add(this.label52);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table8[this.label52]));
			w17.TopAttach = ((uint)(2));
			w17.BottomAttach = ((uint)(3));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox13.Add(this.table8);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.table8]));
			w18.Position = 0;
			w18.Expand = false;
			w18.Fill = false;
			// Container child vbox13.Gtk.Box+BoxChild
			this.alignment15 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment15.Name = "alignment15";
			this.vbox13.Add(this.alignment15);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.alignment15]));
			w19.Position = 1;
			// Container child vbox13.Gtk.Box+BoxChild
			this.table9 = new global::Gtk.Table(((uint)(3)), ((uint)(2)), false);
			this.table9.Name = "table9";
			this.table9.RowSpacing = ((uint)(6));
			this.table9.ColumnSpacing = ((uint)(6));
			// Container child table9.Gtk.Table+TableChild
			this.comboboxentry3 = global::Gtk.ComboBoxEntry.NewText();
			this.comboboxentry3.Name = "comboboxentry3";
			this.table9.Add(this.comboboxentry3);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table9[this.comboboxentry3]));
			w20.TopAttach = ((uint)(1));
			w20.BottomAttach = ((uint)(2));
			w20.LeftAttach = ((uint)(1));
			w20.RightAttach = ((uint)(2));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table9.Gtk.Table+TableChild
			this.entry41 = new global::Gtk.Entry();
			this.entry41.CanFocus = true;
			this.entry41.Name = "entry41";
			this.entry41.IsEditable = true;
			this.entry41.InvisibleChar = '•';
			this.table9.Add(this.entry41);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table9[this.entry41]));
			w21.TopAttach = ((uint)(2));
			w21.BottomAttach = ((uint)(3));
			w21.LeftAttach = ((uint)(1));
			w21.RightAttach = ((uint)(2));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table9.Gtk.Table+TableChild
			this.hseparator9 = new global::Gtk.HSeparator();
			this.hseparator9.Name = "hseparator9";
			this.table9.Add(this.hseparator9);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table9[this.hseparator9]));
			w22.LeftAttach = ((uint)(1));
			w22.RightAttach = ((uint)(2));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table9.Gtk.Table+TableChild
			this.label54 = new global::Gtk.Label();
			this.label54.Name = "label54";
			this.label54.Xalign = 0F;
			this.label54.LabelProp = global::Mono.Unix.Catalog.GetString("Extras");
			this.table9.Add(this.label54);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table9[this.label54]));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table9.Gtk.Table+TableChild
			this.label55 = new global::Gtk.Label();
			this.label55.Name = "label55";
			this.label55.LabelProp = global::Mono.Unix.Catalog.GetString("Tipo de Extra:");
			this.table9.Add(this.label55);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table9[this.label55]));
			w24.TopAttach = ((uint)(1));
			w24.BottomAttach = ((uint)(2));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table9.Gtk.Table+TableChild
			this.label56 = new global::Gtk.Label();
			this.label56.Name = "label56";
			this.label56.Xalign = 1F;
			this.label56.LabelProp = global::Mono.Unix.Catalog.GetString("Monto:");
			this.table9.Add(this.label56);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table9[this.label56]));
			w25.TopAttach = ((uint)(2));
			w25.BottomAttach = ((uint)(3));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox13.Add(this.table9);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.table9]));
			w26.Position = 2;
			w26.Expand = false;
			w26.Fill = false;
			this.vbox12.Add(this.vbox13);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.vbox13]));
			w27.Position = 2;
			this.Add(this.vbox12);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 490;
			this.DefaultHeight = 300;
			this.Show();
		}
	}
}
