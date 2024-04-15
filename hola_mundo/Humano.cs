using System;

namespace hola_mundo
{
    public class Humano
    {
        private string _nacionalidad;
        private int _cedula;

        public Humano(string nacionalidad, int cedula)
        {
            Nacionalidad = nacionalidad;
            Cedula = cedula;
        }

        public string Nacionalidad { get => _nacionalidad; set => _nacionalidad = value; }
        public int Cedula { get => _cedula; set => _cedula = value; }

        public string Saludar_H()
        {
            return $"Hola vivo en {Nacionalidad} y tengo CI {Cedula}";
        }
    }
}
