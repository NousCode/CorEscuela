namespace CoreEscuela.Entidades
{
    public class Evaluacion : EscuelaBase
    {
        public Alumno? Alumno { get; set; }

        public Asignatura? Asignatura { get; set; }
        
        public float? Nota { get; set; }
    }
}