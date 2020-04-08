using System;
namespace Nomina.Entidades
{
    public class Cargo
    {
        private int idCargo;
        private string nombre;

        public int IdCargo { get => idCargo; set => idCargo = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public Cargo()
        {
        }

    }
}
