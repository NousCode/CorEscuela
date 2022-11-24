// * En la parte más top del programa sera la función main de .net
using CoreEscuela;
using CoreEscuela.Util;
using corEscuela.Entidades;
using static System.Console;

var engine = new EscuelaEngine();
engine.Inicializar();

Printer.WriteTitle("Bienvenido a la Escuela");

int dummy = 0;
var listaObjetos = engine.GetObjetosEscuela(out dummy, out int traeAlumnos);

Printer.Beep(5);
