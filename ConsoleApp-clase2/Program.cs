using ClassLibrary_clase2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_clase2
{
    class Program
    {

        static void Main(string[] args)
        {
            //alumno alumno1 = new alumno("Claudio Montoya","15-8",12346);
            //alumno alumno2 = new alumno("Juan Perez", "18-7",45678);
            //alumno alumno3 = new alumno("Pedro", "19-7", 45578);
            //alumno alumno1 = new alumno("Pedro");
            asignatura a1 = new asignatura();
            alumno alumno2 = new alumno(a1);
            alumno2.InscribirRamos();
            alumno2.asignatura2.Nombre = "Computacion";

            alumno2.domicilio.calle = "Almagro 123";


            //domicilio dom = new domicilio();
            //dom.calle = "Almagro 123";
            //alumno2.asignaDomicilio(dom);


            //agregar asignaturas 
            asignatura a2 = new asignatura();
            a2.Id = 1;
            a2.Nombre = "Taller de programacion";
            alumno2.listadoAsignatura.Add(a2);

            List<asignatura> listadoA = new List<asignatura>();
            listadoA.Add(a2);
            listadoA.Add(a1);
            alumno2.creaAsignaturasAsignacion(listadoA);

            // alumno2.crearAsignaturas();
            alumno2.listadoAsignatura2.Add(a2);




            Console.WriteLine("Asignatura :" + alumno2.asignatura2.Nombre);

            //Console.WriteLine("Ingrese el nombre del alumno");
            //alumno2.setNombre(Console.ReadLine());

            //Console.WriteLine("Ingrese el Rut");
            //alumno2.setRut(Console.ReadLine());

            //Console.WriteLine("Ingrese el numero de matricula");
            //int mat = int.Parse(Console.ReadLine());
            //alumno2.setMatricula(mat);


            //alumno2.Celular = "99999999";

            //Console.WriteLine($"Nombre: {alumno2.getNombre()}");
            //Console.WriteLine($"Rut: {alumno2.getRut()}");
            //Console.WriteLine($"Matricula: {alumno2.getMatricula()}");
            //Console.WriteLine($"Nombre:{alumno2.getNombre()} Rut:{alumno2.getRut()} Matricula:{alumno2.getMatricula()}");


            //Console.WriteLine("Nombre:" + alumno2.getNombre());


            Console.ReadKey();


            //Se necesita almacenar los datos de los automoviles de una automotora, la cual tiene
            //diferentes sucursales a nivel pais, para cada sucursal  es necesario almacenar
            //los datos del encargado y el detalle de los vehiculos que se encuentran en ella. 
            //La automotora posee vehiculos propios y en consignacion por lo cual es necesario
            //tener la informacion del dueño del vehiculo en caso de que sea en consignacion


        }
    }
}
