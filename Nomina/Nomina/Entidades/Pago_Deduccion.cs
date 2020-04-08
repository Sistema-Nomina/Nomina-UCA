using System;
namespace Nomina.Entidades
{
    public class Pago_Deduccion
    {
        private int idEmpleado_Deduccion;
        private int idPago;
        private int idDeduccion;
        private double monto;

        public int IdEmpleado_Deduccion { get => idEmpleado_Deduccion; set => idEmpleado_Deduccion = value; }
        public int IdPago { get => idPago; set => idPago = value; }
        public int IdDeduccion { get => idDeduccion; set => idDeduccion = value; }
        public double Monto { get => monto; set => monto = value; }

        public Pago_Deduccion()
        {
        }

    }
}
