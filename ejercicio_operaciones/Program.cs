using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_operaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaracion de variables
            int num1, num2, resultados;
            string linea;
            // pedir numeros
            Console.WriteLine("ingresar el primer numero");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.WriteLine("ingresar el segundo numero");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            //operaciones suma
            resultados = num1 + num2;
            Console.WriteLine(" la suma es: {0}: ", num1 + num2);

                //operaciones resta
            resultados = num1 - num2;

            Console.WriteLine(" la resta es: {0}: ", num1 + num2);

                 //operaciones multiplicacion
            resultados = num1 * num2;

            Console.WriteLine(" la multiplicacion es: {0}: ", num1 + num2);
                 //operaciones division
            resultados = num1 / num2;

            Console.WriteLine(" la division es: {0}: ", num1 + num2);

                 //operaciones division
            resultados = num1 % num2;

            Console.WriteLine(" el residuo es: {0}: ", num1 + num2);
            Console.WriteLine(" presione cualquier tecla para continuar ");
            Console.ReadKey();
        }
    }
    }
    }

    }
    }
}
