namespace CoreEscuela.Entidades
{
    public class Curso : EscuelaBase
    {
        public string? Jornada { get; set; }

        public List<Asignatura>? Asignaturas { get; set; }
        public List<Alumno>? Alumnos { get; set; }
    }
}