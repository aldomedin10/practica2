using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_striem
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string ciudad;
            //1.- pedir por consola el nombre de una persona
            Console.WriteLine("por favor escriba su nombre");
            nombre = Console.ReadLine();
            //2.- pedir el nombre de una ciudad
            Console.WriteLine("escribe tu cicudad");
            ciudad = Console.ReadLine();
            //3.- mostrar en pantalla
            Console.WriteLine("hola" + nombre + "bienvenido a " + ciudad);
            Console.WriteLine("presionar cualquier tecla para coontinuar");
            Console.ReadKey();



        }
    }
}
