namespace CoreEscuela.Entidades
{
    public class Escuela : EscuelaBase
    {
        public int? AñoDeCreación { get; set; }
        public string? País { get; set; }
        public string? Ciudad { get; set; }
        public TiposEscuela? TipoEscuela { get; set; }

        public List<Curso>? Cursos { get; set; }
        // ? Forma de construir el constructor a través de tuplas
        public Escuela(string nombre, int año) => (Nombre, AñoDeCreación) = (nombre, año);
        // * Podemos sobre escribir los métodos, pero estos deben de tener diferentes parámetros.
        public Escuela(string nombre, int año, TiposEscuela tiposEscuela, string pais="", string ciudad="") {
            (Nombre, AñoDeCreación) = (nombre, año);
            this.TipoEscuela = tiposEscuela;
            this.País = pais;
            this.Ciudad = ciudad;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Tipo: {TipoEscuela}. {System.Environment.NewLine}País: {País}, Ciudad: {Ciudad}.";
        }
    }
}