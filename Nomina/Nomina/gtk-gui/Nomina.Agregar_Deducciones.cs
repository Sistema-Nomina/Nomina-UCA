
// This file has been generated by the GUI designer. Do not modify.
namespace Nomina
{
	public partial class Agregar_Deducciones
	{
		private global::Gtk.UIManager UIManager;

		private global::Gtk.Action INICIOAction;

		private global::Gtk.Action MENAction;

		private global::Gtk.VBox vbox14;

		private global::Gtk.MenuBar menubar10;

		private global::Gtk.Frame frame10;

		private global::Gtk.Alignment GtkAlignment;

		private global::Gtk.HBox hbox37;

		private global::Gtk.Button button9;

		private global::Gtk.Button button10;

		private global::Gtk.Label GtkLabel2;

		private global::Gtk.VBox vbox15;

		private global::Gtk.Table table10;

		private global::Gtk.Entry entry38;

		private global::Gtk.Entry entry39;

		private global::Gtk.HBox hbox38;

		private global::Gtk.Label label53;

		private global::Gtk.ComboBoxEntry comboboxentry2;

		private global::Gtk.HSeparator hseparator11;

		private global::Gtk.HSeparator hseparator12;

		private global::Gtk.Label label50;

		private global::Gtk.Label label51;

		private global::Gtk.Label label52;

		private global::Gtk.Alignment alignment16;

		private global::Gtk.Table table11;

		private global::Gtk.ComboBoxEntry comboboxentry3;

		private global::Gtk.Entry entry42;

		private global::Gtk.HSeparator hseparator13;

		private global::Gtk.Label label54;

		private global::Gtk.Label label55;

		private global::Gtk.Label label56;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Nomina.Agregar_Deducciones
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
			this.Name = "Nomina.Agregar_Deducciones";
			this.Title = global::Mono.Unix.Catalog.GetString("Agregar_Deducciones");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child Nomina.Agregar_Deducciones.Gtk.Container+ContainerChild
			this.vbox14 = new global::Gtk.VBox();
			this.vbox14.Name = "vbox14";
			this.vbox14.Spacing = 6;
			// Container child vbox14.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString("<ui><menubar name=\'menubar10\'><menu name=\'INICIOAction\' action=\'INICIOAction\'/><m" +
					"enu name=\'MENAction\' action=\'MENAction\'/></menubar></ui>");
			this.menubar10 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget("/menubar10")));
			this.menubar10.Name = "menubar10";
			this.vbox14.Add(this.menubar10);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox14[this.menubar10]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox14.Gtk.Box+BoxChild
			this.frame10 = new global::Gtk.Frame();
			this.frame10.Name = "frame10";
			this.frame10.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame10.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.hbox37 = new global::Gtk.HBox();
			this.hbox37.Name = "hbox37";
			this.hbox37.Spacing = 6;
			// Container child hbox37.Gtk.Box+BoxChild
			this.button9 = new global::Gtk.Button();
			this.button9.CanFocus = true;
			this.button9.Name = "button9";
			this.button9.UseUnderline = true;
			this.button9.Label = global::Mono.Unix.Catalog.GetString("Agregar Deducción");
			this.hbox37.Add(this.button9);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox37[this.button9]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox37.Gtk.Box+BoxChild
			this.button10 = new global::Gtk.Button();
			this.button10.CanFocus = true;
			this.button10.Name = "button10";
			this.button10.UseUnderline = true;
			this.button10.Label = global::Mono.Unix.Catalog.GetString("Buscar Empleado");
			this.hbox37.Add(this.button10);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox37[this.button10]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			this.GtkAlignment.Add(this.hbox37);
			this.frame10.Add(this.GtkAlignment);
			this.GtkLabel2 = new global::Gtk.Label();
			this.GtkLabel2.Name = "GtkLabel2";
			this.GtkLabel2.LabelProp = global::Mono.Unix.Catalog.GetString("DEDUCCIONES");
			this.GtkLabel2.UseMarkup = true;
			this.frame10.LabelWidget = this.GtkLabel2;
			this.vbox14.Add(this.frame10);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox14[this.frame10]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox14.Gtk.Box+BoxChild
			this.vbox15 = new global::Gtk.VBox();
			this.vbox15.Name = "vbox15";
			this.vbox15.Spacing = 6;
			// Container child vbox15.Gtk.Box+BoxChild
			this.table10 = new global::Gtk.Table(((uint)(3)), ((uint)(3)), false);
			this.table10.Name = "table10";
			this.table10.RowSpacing = ((uint)(6));
			this.table10.ColumnSpacing = ((uint)(6));
			// Container child table10.Gtk.Table+TableChild
			this.entry38 = new global::Gtk.Entry();
			this.entry38.CanFocus = true;
			this.entry38.Name = "entry38";
			this.entry38.IsEditable = true;
			this.entry38.InvisibleChar = '•';
			this.table10.Add(this.entry38);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table10[this.entry38]));
			w8.TopAttach = ((uint)(1));
			w8.BottomAttach = ((uint)(2));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table10.Gtk.Table+TableChild
			this.entry39 = new global::Gtk.Entry();
			this.entry39.CanFocus = true;
			this.entry39.Name = "entry39";
			this.entry39.IsEditable = true;
			this.entry39.InvisibleChar = '•';
			this.table10.Add(this.entry39);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table10[this.entry39]));
			w9.TopAttach = ((uint)(2));
			w9.BottomAttach = ((uint)(3));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table10.Gtk.Table+TableChild
			this.hbox38 = new global::Gtk.HBox();
			this.hbox38.Name = "hbox38";
			this.hbox38.Spacing = 6;
			// Container child hbox38.Gtk.Box+BoxChild
			this.label53 = new global::Gtk.Label();
			this.label53.Name = "label53";
			this.label53.LabelProp = global::Mono.Unix.Catalog.GetString("ID Pago:");
			this.hbox38.Add(this.label53);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox38[this.label53]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox38.Gtk.Box+BoxChild
			this.comboboxentry2 = global::Gtk.ComboBoxEntry.NewText();
			this.comboboxentry2.Name = "comboboxentry2";
			this.hbox38.Add(this.comboboxentry2);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox38[this.comboboxentry2]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			this.table10.Add(this.hbox38);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table10[this.hbox38]));
			w12.TopAttach = ((uint)(1));
			w12.BottomAttach = ((uint)(2));
			w12.LeftAttach = ((uint)(2));
			w12.RightAttach = ((uint)(3));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table10.Gtk.Table+TableChild
			this.hseparator11 = new global::Gtk.HSeparator();
			this.hseparator11.Name = "hseparator11";
			this.table10.Add(this.hseparator11);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table10[this.hseparator11]));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table10.Gtk.Table+TableChild
			this.hseparator12 = new global::Gtk.HSeparator();
			this.hseparator12.Name = "hseparator12";
			this.table10.Add(this.hseparator12);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table10[this.hseparator12]));
			w14.LeftAttach = ((uint)(2));
			w14.RightAttach = ((uint)(3));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table10.Gtk.Table+TableChild
			this.label50 = new global::Gtk.Label();
			this.label50.Name = "label50";
			this.label50.LabelProp = global::Mono.Unix.Catalog.GetString("Empleado");
			this.table10.Add(this.label50);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table10[this.label50]));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table10.Gtk.Table+TableChild
			this.label51 = new global::Gtk.Label();
			this.label51.Name = "label51";
			this.label51.LabelProp = global::Mono.Unix.Catalog.GetString("Nombre:");
			this.table10.Add(this.label51);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table10[this.label51]));
			w16.TopAttach = ((uint)(1));
			w16.BottomAttach = ((uint)(2));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table10.Gtk.Table+TableChild
			this.label52 = new global::Gtk.Label();
			this.label52.Name = "label52";
			this.label52.LabelProp = global::Mono.Unix.Catalog.GetString("Cédula:");
			this.table10.Add(this.label52);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table10[this.label52]));
			w17.TopAttach = ((uint)(2));
			w17.BottomAttach = ((uint)(3));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox15.Add(this.table10);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox15[this.table10]));
			w18.Position = 0;
			w18.Expand = false;
			w18.Fill = false;
			// Container child vbox15.Gtk.Box+BoxChild
			this.alignment16 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment16.Name = "alignment16";
			this.vbox15.Add(this.alignment16);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox15[this.alignment16]));
			w19.Position = 1;
			// Container child vbox15.Gtk.Box+BoxChild
			this.table11 = new global::Gtk.Table(((uint)(3)), ((uint)(2)), false);
			this.table11.Name = "table11";
			this.table11.RowSpacing = ((uint)(6));
			this.table11.ColumnSpacing = ((uint)(6));
			// Container child table11.Gtk.Table+TableChild
			this.comboboxentry3 = global::Gtk.ComboBoxEntry.NewText();
			this.comboboxentry3.Name = "comboboxentry3";
			this.table11.Add(this.comboboxentry3);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table11[this.comboboxentry3]));
			w20.TopAttach = ((uint)(1));
			w20.BottomAttach = ((uint)(2));
			w20.LeftAttach = ((uint)(1));
			w20.RightAttach = ((uint)(2));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table11.Gtk.Table+TableChild
			this.entry42 = new global::Gtk.Entry();
			this.entry42.CanFocus = true;
			this.entry42.Name = "entry42";
			this.entry42.IsEditable = true;
			this.entry42.InvisibleChar = '•';
			this.table11.Add(this.entry42);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table11[this.entry42]));
			w21.TopAttach = ((uint)(2));
			w21.BottomAttach = ((uint)(3));
			w21.LeftAttach = ((uint)(1));
			w21.RightAttach = ((uint)(2));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table11.Gtk.Table+TableChild
			this.hseparator13 = new global::Gtk.HSeparator();
			this.hseparator13.Name = "hseparator13";
			this.table11.Add(this.hseparator13);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table11[this.hseparator13]));
			w22.LeftAttach = ((uint)(1));
			w22.RightAttach = ((uint)(2));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table11.Gtk.Table+TableChild
			this.label54 = new global::Gtk.Label();
			this.label54.Name = "label54";
			this.label54.Xalign = 0F;
			this.label54.LabelProp = global::Mono.Unix.Catalog.GetString("Deducción");
			this.table11.Add(this.label54);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table11[this.label54]));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table11.Gtk.Table+TableChild
			this.label55 = new global::Gtk.Label();
			this.label55.Name = "label55";
			this.label55.LabelProp = global::Mono.Unix.Catalog.GetString("Tipo de Deducción:");
			this.table11.Add(this.label55);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table11[this.label55]));
			w24.TopAttach = ((uint)(1));
			w24.BottomAttach = ((uint)(2));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table11.Gtk.Table+TableChild
			this.label56 = new global::Gtk.Label();
			this.label56.Name = "label56";
			this.label56.Xalign = 1F;
			this.label56.LabelProp = global::Mono.Unix.Catalog.GetString("Monto:");
			this.table11.Add(this.label56);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table11[this.label56]));
			w25.TopAttach = ((uint)(2));
			w25.BottomAttach = ((uint)(3));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox15.Add(this.table11);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox15[this.table11]));
			w26.Position = 2;
			w26.Expand = false;
			w26.Fill = false;
			this.vbox14.Add(this.vbox15);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox14[this.vbox15]));
			w27.Position = 2;
			this.Add(this.vbox14);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 506;
			this.DefaultHeight = 300;
			this.Show();
		}
	}
}
