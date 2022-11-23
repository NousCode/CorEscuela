using CoreEscuela.Util;
using corEscuela.Entidades;

namespace CoreEscuela.Entidades
{
    public class Curso : EscuelaBase, ILugar
    {
        public string? Jornada { get; set; }

        public List<Asignatura>? Asignaturas { get; set; }
        public string Dirección { get; set; }
        public List<Alumno>? Alumnos { get; set; }

        public void LimpiarLugar()
        {
            Printer.DrawLine();
            Console.WriteLine("Limpiando el Establecimiento 🧹");
            Console.WriteLine($"Curso {Nombre} esta limpio. ");
        }
    }
}