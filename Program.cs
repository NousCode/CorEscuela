// * En la parte más top del programa sera la función main de .net
var miEscuela = new Escuela();
miEscuela.nombre = "Soul Code Academy";
miEscuela.direccion = "Mz 31 Cs 09 Br Jardín";
miEscuela.añofundacion = 2010;
miEscuela.director = "Liliana Restrepo";
Console.WriteLine("Timbrar!!");
miEscuela.Timbrar();

class Escuela
{
    // Atributos
    public string nombre;
    public string direccion;
    public int añofundacion;
    public string director;

    // Métodos
    public void Timbrar()
    {
        Console.Beep();
    }
}