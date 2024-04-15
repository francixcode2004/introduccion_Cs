using System;
namespace hola_mundo
{
    public class Perro
    {
        private string Nombre;
        private int Edad;

        public Perro() { }
        public Perro(string nombre, int edad)
        {
            Nombre1 = nombre;
            Edad1 = edad;
        }

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public int Edad1 { get => Edad; set => Edad = value; }

        public string Saludar_perro()
        {
            return $"Hola mi nombre es {Nombre1} y tengo {Edad1} me gusta ser un perro";
        }
    }
}
