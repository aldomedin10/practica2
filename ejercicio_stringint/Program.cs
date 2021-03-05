using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_stringint
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string lineaedad;
            int edad;
            Console.WriteLine("escribe tu nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("escribe la edad:");
            lineaedad = Console.ReadLine();
            edad = Convert.ToInt32(lineaedad);
            Console.WriteLine("tu nombre es:" + nombre + " y tienes " + edad + " anos ");
            Console.WriteLine("presiona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
