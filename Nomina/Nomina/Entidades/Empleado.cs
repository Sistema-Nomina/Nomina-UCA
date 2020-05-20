using System;
namespace Nomina.Entidades
{
    public class Empleado
    {
        private int idEmpleado;
        private string nombre;
        private string apellidos;
        private string cedula;
        private string nivelEstudio;
        private string inss_Empleado;
        private DateTime fecha_contratacion;
        private DateTime fecha_de_baja;
        private int idEstado;
        private string seguroEmpleado;
        private string direccion;
        private string motivoBaja;
        private double salarioEmpleado;
        private int idPlanilla;
        private int idArea;
        private int idContrato;
        private int idSucursal;
        private int idCargo;
        string nombreSucursal;
        string nombreEmpresa;


        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string NivelEstudio { get => nivelEstudio; set => nivelEstudio = value; }
        public string Inss_Empleado { get => inss_Empleado; set => inss_Empleado = value; }
        public DateTime Fecha_contratacion { get => fecha_contratacion; set => fecha_contratacion = value; }
        public DateTime Fecha_de_baja { get => fecha_de_baja; set => fecha_de_baja = value; }
        public int IdEstado { get => idEstado; set => idEstado = value; }
        public string SeguroEmpleado { get => seguroEmpleado; set => seguroEmpleado = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string MotivoBaja { get => motivoBaja; set => motivoBaja = value; }
        public double SalarioEmpleado { get => salarioEmpleado; set => salarioEmpleado = value; }
        public int IdPlanilla { get => idPlanilla; set => idPlanilla = value; }
        public int IdArea { get => idArea; set => idArea = value; }
        public int IdContrato { get => idContrato; set => idContrato = value; }
        public int IdSucursal { get => idSucursal; set => idSucursal = value; }
        public int IdCargo { get => idCargo; set => idCargo = value; }
        public string NombreSucursal { get => nombreSucursal; set => nombreSucursal = value; }
        public string NombreEmpresa { get => nombreEmpresa; set => nombreEmpresa = value; }

        public Empleado()
        {
        }


    }
}
