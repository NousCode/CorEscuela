// * En la parte más top del programa sera la función main de .net
using CoreEscuela;
using CoreEscuela.Util;
using static System.Console;

var engine = new EscuelaEngine();
engine.Inicializar();

Printer.WriteTitle("Bienvenido a la Escuela");

var listaObjetos = engine.GetObjetosEscuela();

Printer.Beep(5);