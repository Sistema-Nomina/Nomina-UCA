﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Nomina.Datos
{
    public class DTEmpleado
    {

        conexion con = new conexion();

        public List<Nomina.Entidades.Empleado> ListarEmpleado()
        {
            List<Nomina.Entidades.Empleado> listaEmpleado = new List<Nomina.Entidades.Empleado>();
            IDataReader idr = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("USE Nomina;");
            sb.Append("Select * from Empleado;");

            try
            {
                con.Open();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    Nomina.Entidades.Empleado a = new Nomina.Entidades.Empleado()
                    {
                        IdEmpleado = Convert.ToInt32(idr["IdEmpleado"]),
                        Nombre = idr["Nombre"].ToString(),
                        Apellidos = idr["Apellidos"].ToString()
                        //Last_update = Convert.ToDateTime(idr["last_update"])
                    };

                    listaEmpleado.Add(a);

                }
                idr.Close();

                return listaEmpleado;
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
            return listaEmpleado;
        }
        public DTEmpleado()
        {
        }
    }
}