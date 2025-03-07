using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listas
{
    internal class Automovil
    {
        public Automovil() { }
        public Automovil(string marca, string modelo, int anio, int noPuertas, string color)
        {
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
            NoPuertas = noPuertas;
            Color = color;
        }

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public int NoPuertas { get; set; }
        public string Color { get; set; }
    }
}
