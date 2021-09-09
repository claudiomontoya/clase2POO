using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_clase2
{
   public class alumno
    {
        //atributos
        private string nombre;
        private string rut;
        private string direccion;
        private int matricula;
        private string celular;
        private string wsp;

        public string Celular { get => celular; set => celular = value; }

        //public string getCelular()
        //{
        //    return this.celular;
        //}

        //public void setCelular(string celular)
        //{
        //    this.celular = celular;
        //}


        //constructores



        public alumno()
        {
            this.matricula = 1;
        }
        public alumno(string nombre):this(nombre,"15-8",4566) {

        }
        public alumno(string nombre, string rut)
        {
            this.nombre = nombre;
            this.rut = rut;
        }
        public alumno(string nombre, string rut, int matricula)
        {
            this.nombre = nombre;
            this.rut = rut;
            this.matricula = matricula;
        }
        public alumno(int matricula,string nombre, string rut)
        {
            this.nombre = nombre;
            this.rut = rut;
            this.matricula = matricula;
        }
        //metodos
        // diferencia entre procedimientos y funciones
        public string datos()//funcion ya que devuleve datos
        {
           return "Alumno:"+nombre+" "+rut+" "+matricula.ToString();
        }
        public void agregarWhatsapp()// metodo que realiza un proceso 
        {
            wsp = "+56" + celular;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string getRut()
        {
            return this.rut;
        }

        public void setRut(string rut)
        {
            this.rut = rut;
        }
        public int getMatricula()
        {
            return this.matricula;
        }

        public void setMatricula(int matricula)
        {
            this.matricula = matricula;
        }
    }
}
