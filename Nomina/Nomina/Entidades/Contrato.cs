using System;
namespace Nomina.Entidades
{
    public class Contrato
    {
        private int idContrato;
        private string descripcion;
        private int idTipoContrato;
        private int idTurno;

        public int IdContrato { get => idContrato; set => idContrato = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdTipoContrato { get => idTipoContrato; set => idTipoContrato = value; }
        public int IdTurno { get => idTurno; set => idTurno = value; }

        public Contrato()
        {
        }

    }
}
