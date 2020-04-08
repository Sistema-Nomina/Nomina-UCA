using System;
namespace Nomina.Entidades
{
    public class Opciones
    {
        private int idOpciones;
        private string nombre;
        private string formulario;

        public int IdOpciones { get => idOpciones; set => idOpciones = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Formulario { get => formulario; set => formulario = value; }

        public Opciones()
        {
        }


    }
}
