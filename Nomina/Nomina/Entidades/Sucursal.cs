using System;
namespace Nomina.Entidades
{
    public class Sucursal
    {
        private int idSucursal;
        private string nombre;
        private string extension;
        private int numeroRuc;

        public int IdSucursal { get => idSucursal; set => idSucursal = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Extension { get => extension; set => extension = value; }
        public int NumeroRuc { get => numeroRuc; set => numeroRuc = value; }

        public Sucursal()
        {
        }

    }
}
