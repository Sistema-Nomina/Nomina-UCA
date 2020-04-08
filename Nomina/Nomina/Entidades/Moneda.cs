using System;
namespace Nomina.Entidades
{
    public class Moneda
    {
        private int idMoneda;
        private string nombre;
        private double cambio;

        public int IdMoneda { get => idMoneda; set => idMoneda = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Cambio { get => cambio; set => cambio = value; }

        public Moneda()
        {
        }

    }
}
