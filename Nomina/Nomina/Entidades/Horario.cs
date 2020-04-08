using System;
namespace Nomina.Entidades
{
    public class Horario
    {
        private int idHorario;
        private string horarioEntrada;
        private string horarioSalida;
        private int idTurno;

        public int IdHorario { get => idHorario; set => idHorario = value; }
        public string HorarioEntrada { get => horarioEntrada; set => horarioEntrada = value; }
        public string HorarioSalida { get => horarioSalida; set => horarioSalida = value; }
        public int IdTurno { get => idTurno; set => idTurno = value; }

        public Horario()
        {
        }

    }
}
