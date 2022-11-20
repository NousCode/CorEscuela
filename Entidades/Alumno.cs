namespace CoreEscuela.Entidades
{
    public class Alumno : EscuelaBase
    {

        public List<Evaluacion> Evaluaciones { get; set; }

        public Alumno() { 
            this.Evaluaciones = new List<Evaluacion>(){};
        }
    }
}