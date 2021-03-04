using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_int
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.- declarar 3 variables de tipo INT y asignarles valores estaticos
            int numero_1 = 5;
            int numero_2 = 20;
            int numero_3 = 10;

            //2.-- crear una variable de tipo INT la cual guardara la SUMA de las 3 variables 
            int suma = numero_1 + numero_2 + numero_3;

            //3.- mostar en pantalla el valor de suma el valor de suma es:
            Console.WriteLine("el valor de la suma es: " + suma);
            Console.WriteLine("presiona cualquier tecla para continuar");
            Console.ReadKey();


        }
    }
}
