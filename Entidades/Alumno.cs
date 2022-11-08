namespace CoreEscuela.Entidades
{
    public class Alumno
    {
        public string? UniqueId { get; set; }
        public string? Nombre { get; set; }
        public List<Evaluaciones>? Evaluaciones { get; set; }

        public Alumno() { 
            this.UniqueId = Guid.NewGuid().ToString();
            this.Evaluaciones = new List<Evaluaciones>(){};
        }
    }
}