using System;
namespace Nomina.Entidades
{
    public class Extras
    {
        private int idExtra;
        private string nombre;
        private string descripcion;

        public int IdExtra { get => idExtra; set => idExtra = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public Extras()
        {
        }

    }
}
