using System;
using System.Linq;

namespace entityF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            //instanciamos nuestro dbcontext para cerrrar la conexion a bd
            using (var context = new ApplicationDbContext()) 
            {
                var estudiante = new Estudiante();
                estudiante.Nombre = "felipe";
                context.Estudiantes.Add(estudiante);
                context.SaveChanges();
            }
            Console.Write("LISTO");
        }
    }

    class Estudiante {
        public int Id { get; set; }
        public string Nombre { get; set; }

    }

}
