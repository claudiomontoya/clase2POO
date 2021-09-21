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

        //private string direccion;
        private int matricula;
        private string celular;
        private string wsp;

        public asignatura asignatura = new asignatura();//relacion de composicion
        public domicilio domicilio = new domicilio();
        public asignatura asignatura2; // relacion de agregacion     
        public List<asignatura> listadoAsignatura = new List<asignatura>(); //composicion
        public List<asignatura> listadoAsignatura2; // agregacion


        public string Celular { get => celular; set => celular = value; }
        public string Wsp { get => wsp; set => wsp = value; }

        //public string Direccion { get => direccion; set => direccion = value; }
        public int Matricula { get => matricula; set => matricula = value; }
     
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
            this.Matricula = 1;
        }


        public alumno(asignatura a)
        {
            asignatura2 = a;
        }

        public void crearAsignaturas()
        {
            listadoAsignatura2 = new List<asignatura>();
        }

        public void creaAsignaturasAsignacion(List<asignatura> listado)
        {
            listadoAsignatura2 = listado;
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
            this.Matricula = matricula;
        }
        public alumno(int matricula,string nombre, string rut)
        {
            this.nombre = nombre;
            this.rut = rut;
            this.Matricula = matricula;
        }
        //metodos
        // diferencia entre procedimientos y funciones
        public string datos()//funcion ya que devuleve datos
        {
           return "Alumno:"+nombre+" "+rut+" "+Matricula.ToString();
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
            return this.Matricula;
        }

        public void setMatricula(int matricula)
        {
            this.Matricula = matricula;
        }

        public void InscribirRamos()// relacion de dependencia
        {
            tomaRamos tomaR = new tomaRamos();
            tomaR.procesoInscripcion();
        }
    }
}
