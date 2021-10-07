using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Ejercicio
{
    public class vehiculo
    {
        private string patente;
        private string marca;
        private string chasis;
        private string color;
        private int anio;
        private string modelo;
        private int precio;
        private cliente duenio;

        public vehiculo()
        {

        }

        public string Patente { get => patente; set => patente = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Chasis { get => chasis; set => chasis = value; }
        public string Color { get => color; set => color = value; }
        public int Anio { get => anio; set => anio = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Precio { get => precio; set => precio = value; }
        public cliente Duenio { get => duenio; set => duenio = value; }
    }
}
