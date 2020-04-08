using System;
namespace Nomina.Entidades
{
    public class Planilla
    {
        private int idPlanilla;
        private string tipo_planilla;

        public int IdPlanilla { get => idPlanilla; set => idPlanilla = value; }
        public string Tipo_planilla { get => tipo_planilla; set => tipo_planilla = value; }

        public Planilla()
        {
        }

    }
}
