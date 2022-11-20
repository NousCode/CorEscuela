// * En la parte más top del programa sera la función main de .net
using CoreEscuela;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;

var engine = new EscuelaEngine();
engine.Inicializar();

Printer.WriteTitle("Bienvenido a la Escuela");
Printer.Beep(5);

Printer.WriteTitle("Pruebas de polimorfismo");

var alumnoTest = new Alumno { Nombre = "Claire Underwood" };

EscuelaBase obj = alumnoTest;


Printer.WriteTitle("Alumno");
WriteLine($"Alumno: {alumnoTest.Nombre}");
WriteLine($"Alumno: {alumnoTest.UniqueId}");
WriteLine($"Alumno: {alumnoTest.GetType()}");

Printer.WriteTitle("Objeto");
WriteLine($"Alumno: {obj.Nombre}");
WriteLine($"Alumno: {obj.UniqueId}");
WriteLine($"Alumno: {obj.GetType()}");
