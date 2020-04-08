using System;
namespace Nomina.Entidades
{
    public class Usuario
    {
        private int idUsuario;
        private int idEmpleado;
        private string usuarios;
        private string pwd;
        private DateTime fecha_creacion;
        private string activo;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string Usuarios { get => usuarios; set => usuarios = value; }
        public string Pwd { get => pwd; set => pwd = value; }
        public DateTime Fecha_creacion { get => fecha_creacion; set => fecha_creacion = value; }
        public string Activo { get => activo; set => activo = value; }

        public Usuario()
        {
        }
    }
}
