using System;
namespace Nomina.Entidades
{
    public class Rol
    {
        private int idRol;
        private string nombre;

        public int IdRol { get => idRol; set => idRol = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public Rol()
        {
        }

    
    }
}
