using System;
namespace Nomina.Entidades
{
    public class Pago_Extra
    {
        private int idEmpleado_Extra;
        private int idPago;
        private int idExtra;
        string nombreExtra;
        private double monto;

        public int IdEmpleado_Extra { get => idEmpleado_Extra; set => idEmpleado_Extra = value; }
        public int IdPago { get => idPago; set => idPago = value; }
        public int IdExtra { get => idExtra; set => idExtra = value; }
        public double Monto { get => monto; set => monto = value; }
        public string NombreExtra { get => nombreExtra; set => nombreExtra = value; }

        public Pago_Extra()
        {
        }

    }
}
