using System;
namespace Nomina.Entidades
{
    public class Area
    {
        private int idArea;
        private string nombre;
        private int idDepartamento;

        public int IdArea { get => idArea; set => idArea = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int IdDepartamento { get => idDepartamento; set => idDepartamento = value; }

        public Area()
        {
        }

    }
}
