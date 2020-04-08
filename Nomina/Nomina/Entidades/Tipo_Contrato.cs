using System;
namespace Nomina.Entidades
{
    public class Tipo_Contrato
    {
        private int idTipo_Contrato;
        private string descripcion;

        public int IdTipo_Contrato { get => idTipo_Contrato; set => idTipo_Contrato = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public Tipo_Contrato()
        {
        }

    }
}
