using System;
namespace Nomina.Entidades
{
    public class Pago
    {
        private int idPago;
        private int idEmpleado;
        private double monto;
        private int idMoneda;
        private DateTime fecha_pago;

        public int IdPago { get => idPago; set => idPago = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public int IdMoneda { get => idMoneda; set => idMoneda = value; }
        public DateTime Fecha_pago { get => fecha_pago; set => fecha_pago = value; }
        public double Monto { get => monto; set => monto = value; }

        public Pago()
        {
        }

    }
}
