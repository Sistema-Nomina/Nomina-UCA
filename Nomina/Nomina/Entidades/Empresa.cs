using System;
namespace Nomina.Entidades
{
    public class Empresa
    {
        private int numeroRuc;
        private string nombre;
        private string direccion;
        private string telefono;

        public int NumeroRuc { get => numeroRuc; set => numeroRuc = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        public Empresa()
        {
        }

    }
}
