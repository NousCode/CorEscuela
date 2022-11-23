// * En la parte más top del programa sera la función main de .net
using CoreEscuela;
using CoreEscuela.Util;
using corEscuela.Entidades;
using static System.Console;

var engine = new EscuelaEngine();
engine.Inicializar();

Printer.WriteTitle("Bienvenido a la Escuela");

var listaObjetos = engine.GetObjetosEscuela();

Printer.Beep(5);

var listaILugar = from obj in listaObjetos
                  where obj is ILugar
                  select (ILugar) obj;

Printer.Beep(5);
