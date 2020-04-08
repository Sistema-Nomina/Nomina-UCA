using System;
namespace Nomina.Entidades
{
    public class Turno
    {
        private int idTurno;
        private string nombre;

        public int IdTurno { get => idTurno; set => idTurno = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public Turno()
        {
        }


    }
}
