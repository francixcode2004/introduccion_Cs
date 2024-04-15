using System;
namespace hola_mundo;
class ejercicio1
{   
    private string nombre { get; set; }
    private int edad { get; set; }

    public ejercicio1(string nombre, int edad)
    {
        this.nombre = nombre; this.edad = edad;
    }
    public void Saludar()
    {
        Console.WriteLine($"Hola desde la clase {this.nombre} y tienes {this.edad} años");
    } 

    static void Main()
    {
        Console.WriteLine("Hola mundo");
        Int32 entero = 32;
        Console.WriteLine("mi entero es:" + entero);
        string nombre = "francisco";
        Console.WriteLine("mi nombre es: " + nombre);
        float mi_float = 3.14f ;
        Console.WriteLine("mi flotante es: "+mi_float);
        double mi_double = 3.12;
        Console.WriteLine("mi double es: "+mi_double);

        Console.WriteLine("Ingrese su nombre");
        string nombre_2=Console.ReadLine();
        Console.WriteLine("Ingrese su edad");
        int edad_2=int.Parse(Console.ReadLine());
        Console.WriteLine($"Hola, soy {nombre_2} y tengo {edad_2} años");

        if( edad_2<=18)
        {
            Console.WriteLine("Es menor de edad");
        }
        else
        {
            Console.WriteLine("Es mayor de edad");
        }

        ejercicio1 ej1 = new ejercicio1("Mario",18);
        ej1.Saludar();
        Console.WriteLine($"el nombres es {ej1.nombre}");
        ej1.nombre = "Alexander";
        ej1.edad = 34;
        ej1.Saludar();

        Perro p1= new Perro("tobby",7);
        Console.WriteLine(p1.Saludar_perro());
        p1.Nombre1 = "barbara";
        p1.Edad1 = 5;
        Console.WriteLine(p1.Saludar_perro());    
    }
}