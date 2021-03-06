﻿using System;
using System.Collections.Generic;
using Gtk;
using Nomina.Datos;

namespace Nomina
{
    public partial class Visualizar_Sucursal : Gtk.Window
    {
        public Visualizar_Sucursal() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            llenarTreeview();
            llenarCombobox();
        }

        ListStore ls = new ListStore(typeof(String), typeof(String), typeof(String), typeof(String));
        ListStore lscmb = new ListStore(typeof(String));

        //Método para llenar treeview
        public void llenarTreeview()
        {
            DTSucursal dta = new DTSucursal();
            List<Nomina.Entidades.Sucursal> lista = new List<Nomina.Entidades.Sucursal>();
            lista = dta.ListarSucursal();

            foreach (Nomina.Entidades.Sucursal a in lista)
            {
                ls.AppendValues(a.IdSucursal.ToString(), a.Nombre.ToString(), a.Extension.ToString(), a.NombreEmpresa.ToString());
            }

            //Crear el modelo de datos
            trvSucursal.Model = ls;

            trvSucursal.AppendColumn("IdSucursal", new CellRendererText(), "text", 0);
            trvSucursal.AppendColumn("Nombre", new CellRendererText(), "text", 1);
            trvSucursal.AppendColumn("Extension", new CellRendererText(), "text", 2);
            trvSucursal.AppendColumn("Nombre Empresa", new CellRendererText(), "text", 3);

        }



        //Método para llenar combobox
        public void llenarCombobox()
        {
            DTEmpresa dta = new DTEmpresa();
            List<Nomina.Entidades.Empresa> lista = new List<Nomina.Entidades.Empresa>();
            lista = dta.ListarEmpresa();

            foreach (Nomina.Entidades.Empresa a in lista)
            {
                lscmb.AppendValues(a.Nombre.ToString());
            }

            //Crear el modelo de datos
            cmbEmpresa.Model = lscmb;
        }


        public void llenarTreeviewPorEmpresa(string nombreEmpresa)
        {
            DTSucursal dta = new DTSucursal();
            List<Nomina.Entidades.Sucursal> lista = new List<Nomina.Entidades.Sucursal>();
            lista = dta.ListarSucursal();

            foreach (Nomina.Entidades.Sucursal a in lista)
            {
                if (nombreEmpresa == a.NombreEmpresa)
                {
                    ls.AppendValues(a.IdSucursal.ToString(), a.Nombre.ToString(), a.Extension.ToString(), a.NombreEmpresa.ToString());
                }

            }

            //Crear el modelo de datos
            trvSucursal.Model = ls;

            trvSucursal.AppendColumn("IdSucursal", new CellRendererText(), "text", 0);
            trvSucursal.AppendColumn("Nombre", new CellRendererText(), "text", 1);
            trvSucursal.AppendColumn("Extension", new CellRendererText(), "text", 2);
            trvSucursal.AppendColumn("Nombre Empresa", new CellRendererText(), "text", 3);

        }

        public void recargarTreeView()
        {
            TreeViewColumn[] listColumns;
            listColumns = trvSucursal.Columns;
            foreach (TreeViewColumn tvc in listColumns)
            {
                trvSucursal.RemoveColumn(tvc);
            }
            ls.Clear();
        }

        protected void OnBtnBuscarEmpresaClicked(object sender, EventArgs e)
        {
            string nombreEmpresa = cmbEmpresa.ActiveText;

            recargarTreeView();
            llenarTreeviewPorEmpresa(nombreEmpresa);

        }
    }
}
