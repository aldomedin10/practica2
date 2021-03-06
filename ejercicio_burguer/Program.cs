using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_burguer
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaracion de variables
            int cantidadburguer , cantidadpapas, cantidadbebidas;
            double total;
            string linea;
            const double precioburguer = 45;
            const double preciobebida = 15;
            const double preciopapas = 20;

            // pedir datos en consola

            Console.WriteLine(" ingrese la cantidad de hamburguesas: ");
            linea = Console.ReadLine();
            cantidadburguer = int.Parse(linea);

            //papas

            Console.WriteLine(" ingrese la cantidad de papas: ");
            linea = Console.ReadLine();
            cantidadpapas = int.Parse(linea);

            //bebidas

            Console.WriteLine(" ingrese la cantidad de bebidas: ");
            linea = Console.ReadLine();
            cantidadbebidas = int.Parse(linea);

            // pagar
            total = (cantidadburguer   * precioburguer) + (cantidadpapas * preciopapas) + (cantidadbebidas * preciobebida);
            Console.WriteLine(" el total a pagar es: " + total);
            Console.WriteLine(" presione cualquier tecla para continuar ");
            Console.ReadKey();


        }
    }
}
