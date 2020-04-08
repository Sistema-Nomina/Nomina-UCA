using System;
namespace Nomina.Entidades
{
    public class Departamento
    {
        private int idDepartamento;
        private string nombre;

        public int IdDepartamento { get => idDepartamento; set => idDepartamento = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public Departamento()
        {
        }

    }
}
