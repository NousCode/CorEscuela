using CoreEscuela.Entidades;

namespace CoreEscuela
{
    public class EscuelaEngine
    {

        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {

        }
        public void Inicializar()
        {
            Escuela = new Escuela("Soul Code Academy", 2022, TiposEscuela.Primaria, pais: "Colombia", ciudad: "Pereira");
            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();
        }

        private void CargarEvaluaciones()
        {
            foreach (var curso in Escuela.Cursos)
            {
                foreach (var asignatura in curso.Asignaturas)
                {
                    foreach (var alumno in curso.Alumnos)
                    {
                        var rnd = new Random(System.Environment.TickCount);

                        for (int i = 0; i < 5; i++)
                        {
                            var ev = new Evaluaciones{
                                Asignatura = asignatura,
                                Nombre = $"{asignatura.Nombre} Ev#{i+1}",
                                Nota = (float)(5 * rnd.NextDouble()),
                                Alumno = alumno,
                            };
                            alumno.Evaluaciones.Add(ev);
                        }
                    }
                }
            }
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {

                List<Asignatura> listaAsignaturas = new List<Asignatura>(){
                    new Asignatura { Nombre = "Matemáticas" },
                    new Asignatura { Nombre = "Educación Física" },
                    new Asignatura { Nombre = "Castellano" },
                    new Asignatura { Nombre = "Ciencias Naturales" },
                    new Asignatura { Nombre = "Química" },
                };
                curso.Asignaturas = listaAsignaturas;
            }
        }

        private List<Alumno> GenerarAlumnosAzar(int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                                from n2 in nombre2
                                from a1 in apellido1
                                select new Alumno { Nombre= $"{n1} {n2} {a1}" };
            return listaAlumnos.OrderBy((al)=>al.UniqueId).Take(cantidad).ToList();
        }

        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>(){
                new Curso(){ Nombre = "101", Jornada = TiposJornada.Mañana.ToString() },
                new Curso(){ Nombre = "201", Jornada = TiposJornada.Mañana.ToString() },
                new Curso(){ Nombre = "301", Jornada = TiposJornada.Mañana.ToString() },
                new Curso(){ Nombre = "401", Jornada = TiposJornada.Mañana.ToString() },
                new Curso(){ Nombre = "501", Jornada = TiposJornada.Mañana.ToString() },
                new Curso(){ Nombre = "102", Jornada = TiposJornada.Tarde.ToString() },
                new Curso(){ Nombre = "202", Jornada = TiposJornada.Tarde.ToString() },
            };
            Random rnd = new Random();
            foreach (var curso in Escuela.Cursos)
            {
                int cantRandom = rnd.Next(5, 30);
                curso.Alumnos = GenerarAlumnosAzar(cantRandom);
            }
        }
    }
}