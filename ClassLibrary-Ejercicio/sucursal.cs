using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Ejercicio
{
    class sucursal
    {
        private int id;
        private direccion direccion = new direccion();
        private encargado encargado;
        private string telefono;
        private List<vehiculo> vehiculos;

        public sucursal()
        {
            vehiculos= new List<vehiculo>();
        }

        public int Id { get => id; set => id = value; }
        public direccion Direccion { get => direccion; set => direccion = value; }
        public encargado Encargado { get => encargado; set => encargado = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        public string agregarVehiculo(vehiculo auto)
        {
            try
            {
                //bool flag = false;
                //linq

                if (vehiculos.Where(x => x.Patente == auto.Patente).Count() >= 1)
                {
                    return "El vehiculo ya existe en la sucursal!!";
                }

                foreach (var item in vehiculos)
                {
                    if (item.Patente == auto.Patente)
                    {
                        //flag = true;
                        return "El vehiculo ya existe en la sucursal!!";
                    }
                }

                //if (flag)
               // {
                //    return "El vehiculo ya existe en la sucursal!!";
                //}

                vehiculos.Add(auto);
                return "Ingreso Correcto";
            }
            catch (Exception e)
            {
                return "Error Inesperado al agregar vehiculo error:"+e.Message;
            }
           
        }

        public List<vehiculo> listadoVehiculos()
        {
            return vehiculos;
        }

        public List<vehiculo> ventaVehiculo(string patente)
        {

        }
    }
}
