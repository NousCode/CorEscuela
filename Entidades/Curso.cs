namespace CoreEscuela.Entidades
{
    public class Curso
    {
        public string? UniqueId { get; private set; }
        public string? Nombre { get; set; }
        public string? Jornada { get; set; }

        public Curso() => UniqueId = Guid.NewGuid().ToString();
    }
}