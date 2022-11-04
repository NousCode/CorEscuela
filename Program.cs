// * En la parte más top del programa sera la función main de .net
using CoreEscuela.Entidades;

var escuela = new Escuela("Soul Code Academy", 2022);
escuela.País = "Colombia";
escuela.Ciudad = "Pereira";
Console.WriteLine(escuela.Nombre);