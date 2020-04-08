using System;
namespace Nomina.Entidades
{
    public class Usuario_Rol
    {
        private int idUsuario_Rol;
        private int idUsuario;
        private int idRol;
        private DateTime fecha_Creacion;

        public int IdUsuario_Rol { get => idUsuario_Rol; set => idUsuario_Rol = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int IdRol { get => idRol; set => idRol = value; }
        public DateTime Fecha_Creacion { get => fecha_Creacion; set => fecha_Creacion = value; }

        public Usuario_Rol()
        {
        }

    }
}
