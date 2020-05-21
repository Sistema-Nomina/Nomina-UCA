using System;
using System.Data;
using System.Text;

namespace Nomina.Datos
{
    public class DTContrato
    {
        conexion con = new conexion();

        public Int32 guardarContrato(Entidades.Contrato a)
        {
            int guardado = 0;
            StringBuilder sb = new StringBuilder();
            sb.Append("Insert into nomina.Contrato(Descripcion, IdTipo_Contrato, IdTurno) Values('" + a.Descripcion + "'," + a.IdTipoContrato + "," + a.IdTurno + ");");
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

        public Int32 idLastContrato()
        {
            Int32 idContrato = 0;
            IDataReader idr = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("USE nomina;");
            sb.Append("SELECT max(IdContrato) as id from Contrato;");

            try
            {
                con.Open();
                idr = con.Leer(CommandType.Text, sb.ToString());
                if (idr.Read())
                {
                    idContrato = Convert.ToInt32(idr["id"]);
                }
                idr.Close();

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


            return idContrato;
        }

        public DTContrato()
        {
        }
    }
}
