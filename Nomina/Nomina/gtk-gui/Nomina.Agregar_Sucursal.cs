
// This file has been generated by the GUI designer. Do not modify.
namespace Nomina
{
	public partial class Agregar_Sucursal
	{
		private global::Gtk.UIManager UIManager;

		private global::Gtk.Action INICIOAction;

		private global::Gtk.Action MENAction;

		private global::Gtk.VBox vbox21;

		private global::Gtk.MenuBar menubar14;

		private global::Gtk.Frame frame14;

		private global::Gtk.Alignment GtkAlignment;

		private global::Gtk.HBox hbox46;

		private global::Gtk.Button btnAgregar;

		private global::Gtk.Button btnListar;

		private global::Gtk.HSeparator hseparator14;

		private global::Gtk.Label GtkLabel4;

		private global::Gtk.Table table14;

		private global::Gtk.ComboBox cmbEmpresa;

		private global::Gtk.Label label57;

		private global::Gtk.Label label58;

		private global::Gtk.Label label59;

		private global::Gtk.Label label60;

		private global::Gtk.Entry txtExtension;

		private global::Gtk.Entry txtID;

		private global::Gtk.Entry txtNombre;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Nomina.Agregar_Sucursal
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
			this.Name = "Nomina.Agregar_Sucursal";
			this.Title = global::Mono.Unix.Catalog.GetString("Agregar_Sucursal");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child Nomina.Agregar_Sucursal.Gtk.Container+ContainerChild
			this.vbox21 = new global::Gtk.VBox();
			this.vbox21.Name = "vbox21";
			this.vbox21.Spacing = 6;
			// Container child vbox21.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString("<ui><menubar name=\'menubar14\'><menu name=\'INICIOAction\' action=\'INICIOAction\'/><m" +
					"enu name=\'MENAction\' action=\'MENAction\'/></menubar></ui>");
			this.menubar14 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget("/menubar14")));
			this.menubar14.Name = "menubar14";
			this.vbox21.Add(this.menubar14);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox21[this.menubar14]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox21.Gtk.Box+BoxChild
			this.frame14 = new global::Gtk.Frame();
			this.frame14.Name = "frame14";
			this.frame14.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame14.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.hbox46 = new global::Gtk.HBox();
			this.hbox46.Name = "hbox46";
			this.hbox46.Spacing = 6;
			// Container child hbox46.Gtk.Box+BoxChild
			this.btnAgregar = new global::Gtk.Button();
			this.btnAgregar.CanFocus = true;
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.UseUnderline = true;
			this.btnAgregar.BorderWidth = ((uint)(9));
			this.btnAgregar.Label = global::Mono.Unix.Catalog.GetString("Agregar ");
			this.hbox46.Add(this.btnAgregar);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox46[this.btnAgregar]));
			w3.Position = 0;
			// Container child hbox46.Gtk.Box+BoxChild
			this.btnListar = new global::Gtk.Button();
			this.btnListar.CanFocus = true;
			this.btnListar.Name = "btnListar";
			this.btnListar.UseUnderline = true;
			this.btnListar.BorderWidth = ((uint)(9));
			this.btnListar.Label = global::Mono.Unix.Catalog.GetString("Listar");
			this.hbox46.Add(this.btnListar);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox46[this.btnListar]));
			w4.Position = 1;
			// Container child hbox46.Gtk.Box+BoxChild
			this.hseparator14 = new global::Gtk.HSeparator();
			this.hseparator14.Name = "hseparator14";
			this.hbox46.Add(this.hseparator14);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox46[this.hseparator14]));
			w5.Position = 2;
			this.GtkAlignment.Add(this.hbox46);
			this.frame14.Add(this.GtkAlignment);
			this.GtkLabel4 = new global::Gtk.Label();
			this.GtkLabel4.Name = "GtkLabel4";
			this.GtkLabel4.LabelProp = global::Mono.Unix.Catalog.GetString("SUCURSALES");
			this.GtkLabel4.UseMarkup = true;
			this.frame14.LabelWidget = this.GtkLabel4;
			this.vbox21.Add(this.frame14);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox21[this.frame14]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox21.Gtk.Box+BoxChild
			this.table14 = new global::Gtk.Table(((uint)(4)), ((uint)(2)), false);
			this.table14.Name = "table14";
			this.table14.RowSpacing = ((uint)(6));
			this.table14.ColumnSpacing = ((uint)(6));
			// Container child table14.Gtk.Table+TableChild
			this.cmbEmpresa = global::Gtk.ComboBox.NewText();
			this.cmbEmpresa.Name = "cmbEmpresa";
			this.table14.Add(this.cmbEmpresa);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table14[this.cmbEmpresa]));
			w9.TopAttach = ((uint)(3));
			w9.BottomAttach = ((uint)(4));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table14.Gtk.Table+TableChild
			this.label57 = new global::Gtk.Label();
			this.label57.Name = "label57";
			this.label57.Xalign = 1F;
			this.label57.LabelProp = global::Mono.Unix.Catalog.GetString("ID:");
			this.table14.Add(this.label57);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table14[this.label57]));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table14.Gtk.Table+TableChild
			this.label58 = new global::Gtk.Label();
			this.label58.Name = "label58";
			this.label58.Xalign = 1F;
			this.label58.LabelProp = global::Mono.Unix.Catalog.GetString("Nombre:");
			this.table14.Add(this.label58);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table14[this.label58]));
			w11.TopAttach = ((uint)(1));
			w11.BottomAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table14.Gtk.Table+TableChild
			this.label59 = new global::Gtk.Label();
			this.label59.Name = "label59";
			this.label59.Xalign = 1F;
			this.label59.LabelProp = global::Mono.Unix.Catalog.GetString("Extensión:");
			this.table14.Add(this.label59);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table14[this.label59]));
			w12.TopAttach = ((uint)(2));
			w12.BottomAttach = ((uint)(3));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table14.Gtk.Table+TableChild
			this.label60 = new global::Gtk.Label();
			this.label60.Name = "label60";
			this.label60.Xalign = 1F;
			this.label60.LabelProp = global::Mono.Unix.Catalog.GetString("Empresa:");
			this.table14.Add(this.label60);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table14[this.label60]));
			w13.TopAttach = ((uint)(3));
			w13.BottomAttach = ((uint)(4));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table14.Gtk.Table+TableChild
			this.txtExtension = new global::Gtk.Entry();
			this.txtExtension.CanFocus = true;
			this.txtExtension.Name = "txtExtension";
			this.txtExtension.IsEditable = true;
			this.txtExtension.InvisibleChar = '•';
			this.table14.Add(this.txtExtension);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table14[this.txtExtension]));
			w14.TopAttach = ((uint)(2));
			w14.BottomAttach = ((uint)(3));
			w14.LeftAttach = ((uint)(1));
			w14.RightAttach = ((uint)(2));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table14.Gtk.Table+TableChild
			this.txtID = new global::Gtk.Entry();
			this.txtID.CanFocus = true;
			this.txtID.Name = "txtID";
			this.txtID.IsEditable = true;
			this.txtID.InvisibleChar = '•';
			this.table14.Add(this.txtID);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table14[this.txtID]));
			w15.LeftAttach = ((uint)(1));
			w15.RightAttach = ((uint)(2));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table14.Gtk.Table+TableChild
			this.txtNombre = new global::Gtk.Entry();
			this.txtNombre.CanFocus = true;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.IsEditable = true;
			this.txtNombre.InvisibleChar = '•';
			this.table14.Add(this.txtNombre);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table14[this.txtNombre]));
			w16.TopAttach = ((uint)(1));
			w16.BottomAttach = ((uint)(2));
			w16.LeftAttach = ((uint)(1));
			w16.RightAttach = ((uint)(2));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox21.Add(this.table14);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox21[this.table14]));
			w17.Position = 2;
			w17.Expand = false;
			w17.Fill = false;
			this.Add(this.vbox21);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 450;
			this.DefaultHeight = 300;
			this.Show();
			this.btnAgregar.Clicked += new global::System.EventHandler(this.OnBtnAgregarClicked);
			this.btnListar.Clicked += new global::System.EventHandler(this.OnBtnListarClicked);
		}
	}
}
