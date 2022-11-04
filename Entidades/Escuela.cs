namespace CoreEscuela.Entidades
{
    class Escuela
    {
        string nombre;
        public string Nombre { 
            get { return "Copia: " + nombre; } 
            set { nombre = value.ToUpper(); }
        }

        public int AñoDeCreación { get; set; }
        public string País { get; set; }
        public string Ciudad { get; set; }

        public Escuela(string nombre, int año) {
            this.nombre = nombre;
            this.AñoDeCreación = año;
        }

    }
}