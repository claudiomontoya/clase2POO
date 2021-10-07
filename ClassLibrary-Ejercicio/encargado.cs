using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Ejercicio
{
    public class encargado
    {
        private string rut;
        private string nombre;
        private string telefono;
        private string email;
        private bool estado;
        private direccion direccion=new direccion();
        
        public encargado()
        {
            this.estado = true;
        }

        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public direccion Direccion { get => direccion; set => direccion = value; }

        public void cambiarEstado() {
            this.estado = !this.estado;
        }

        public string desactivar()// retornar si se desactivo o no realizo cambio
        {
            if (estado)
            {
                this.estado = false;
                return "Se ha desactivado al encargado de sucursal!!";
            }
            else
            {
                return "El encargado ya se encuentra desactivado!!";
            }
        }
        public void activar() {

            if(estado==false)
             this.estado = true;
        }
    }
}
