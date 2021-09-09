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
            alumno alumno2 = new alumno();

            Console.WriteLine("Ingrese el nombre del alumno");
            alumno2.setNombre(Console.ReadLine());

            Console.WriteLine("Ingrese el Rut");
            alumno2.setRut(Console.ReadLine());

            Console.WriteLine("Ingrese el numero de matricula");
            int mat = int.Parse(Console.ReadLine());
            alumno2.setMatricula(mat);


            alumno2.Celular = "99999999";

            Console.WriteLine($"Nombre: {alumno2.getNombre()}");
            Console.WriteLine($"Rut: {alumno2.getRut()}");
            Console.WriteLine($"Matricula: {alumno2.getMatricula()}");
            Console.WriteLine($"Nombre:{alumno2.getNombre()} Rut:{alumno2.getRut()} Matricula:{alumno2.getMatricula()}");


            //Console.WriteLine("Nombre:" + alumno2.getNombre());


            Console.ReadKey();
        }
    }
}
