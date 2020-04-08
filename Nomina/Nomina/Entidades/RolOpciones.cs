using System;
namespace Nomina.Entidades
{
    public class RolOpciones
    {
        private int idRolOpciones;
        private int idRol;
        private int idOpciones;
        private string habilitado;
        private DateTime fecha_creacion;

        public int IdRolOpciones { get => idRolOpciones; set => idRolOpciones = value; }
        public int IdRol { get => idRol; set => idRol = value; }
        public int IdOpciones { get => idOpciones; set => idOpciones = value; }
        public string Habilitado { get => habilitado; set => habilitado = value; }
        public DateTime Fecha_creacion { get => fecha_creacion; set => fecha_creacion = value; }

        public RolOpciones()
        {
        }
    }
}
