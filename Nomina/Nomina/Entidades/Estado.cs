using System;
namespace Nomina.Entidades
{
    public class Estado
    {
        private int idEstado;
        private string nombre;

        public int IdEstado { get => idEstado; set => idEstado = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public Estado()
        {
        }

    }
}
