// * En la parte más top del programa sera la función main de .net
using CoreEscuela.Entidades;

var escuela = new Escuela("Soul Code Academy", 2022, TiposEscuela.Primaria, pais: "Colombia", ciudad: "Pereira");
var curso1 = new Curso() {
    Nombre = "101"    
};

var curso2 = new Curso() {
    Nombre = "201"    
};

var curso3 = new Curso() {
    Nombre = "301"    
};

Console.WriteLine(escuela);
Console.WriteLine("================");
Console.WriteLine(curso1.Nombre + "," + curso1.UniqueId);
Console.WriteLine($"{curso2.Nombre} , {curso2.UniqueId}");
Console.WriteLine($"{curso3.Nombre} , {curso3.UniqueId}");