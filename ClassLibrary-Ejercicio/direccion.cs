using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Ejercicio
{
    public class direccion
    {
        private string calle;
        private int numero;
        private ciudad ciudad;

        public direccion()
        {

        }
        public direccion(string calle,int numero,ciudad ciudad)
        {
            this.calle = calle;
            this.numero = numero;
            this.ciudad = ciudad;
        }
        public string Calle { get => calle; set => calle = value; }
        public int Numero { get => numero; set => numero = value; }
        public ciudad Ciudad { get => ciudad; set => ciudad = value; }

    }
}
