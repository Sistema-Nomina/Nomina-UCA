using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Nomina.Datos
{
    public class DTTurno
    {
        conexion con = new conexion();

        public List<Nomina.Entidades.Turno> ListarCargo()
        {
            List<Nomina.Entidades.Turno> listaTurno = new List<Nomina.Entidades.Turno>();
            IDataReader idr = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("USE nomina;");
            sb.Append("Select * from Turno;");

            try
            {
                con.Open();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    Nomina.Entidades.Turno a = new Nomina.Entidades.Turno()
                    {
                        IdTurno = Convert.ToInt32(idr["IdTurno"]),
                        Nombre = idr["Nombre"].ToString()
                    };

                    listaTurno.Add(a);

                }
                idr.Close();

                return listaTurno;
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
            return listaTurno;
        }
        public DTTurno()
        {
        }
    }
}
