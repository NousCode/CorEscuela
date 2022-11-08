// * En la parte más top del programa sera la función main de .net
using CoreEscuela;
using CoreEscuela.Util;

var engine = new EscuelaEngine();
engine.Inicializar();

Printer.WriteTitle("Bienvenido a la Escuela");
Printer.Beep(5);