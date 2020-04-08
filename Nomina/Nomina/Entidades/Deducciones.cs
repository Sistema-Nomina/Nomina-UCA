using System;
namespace Nomina.Entidades
{
    public class Deducciones
    {
        private int idDeduccion;
        private string nombre;
        private string descripcion;

        public int IdDeduccion { get => idDeduccion; set => idDeduccion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public Deducciones()
        {
        }

    }
}
