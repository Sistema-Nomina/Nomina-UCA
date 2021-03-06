﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Nomina.Datos
{
    public class DTExtras
    {
        conexion con = new conexion();

        public List<Nomina.Entidades.Extras> ListarExtras()
        {
            List<Nomina.Entidades.Extras> listaExtras = new List<Nomina.Entidades.Extras>();
            IDataReader idr = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("USE nomina;");
            sb.Append("Select * from Extra;");

            try
            {
                con.Open();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    Nomina.Entidades.Extras a = new Nomina.Entidades.Extras()
                    {
                        IdExtra = Convert.ToInt32(idr["IdExtra"]),
                        Nombre = idr["Nombre"].ToString(),
                        Descripcion = idr["Descripcion"].ToString()
                    };

                    listaExtras.Add(a);

                }
                idr.Close();

                return listaExtras;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                con.Close();
            }
            return listaExtras;
        }

        public Int32 guardarExtras(Entidades.Extras a)
        {
            int guardado = 0;
            StringBuilder sb = new StringBuilder();
            sb.Append("Insert into nomina.Extra(Nombre, Descripcion) Values('" + a.Nombre + "','" + a.Descripcion + "');");
            /*sb.Append("(Nombre, Extension, NumeroRUC)");
            sb.Append("VALUES('"+ a.Nombre + "','" + a.Extension + "'," + a.NumeroRuc + ";");*/

            try
            {
                con.Open();
                guardado = con.Ejecutar(CommandType.Text, sb.ToString());
                return guardado;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        public DTExtras()
        {
        }
    }
}
