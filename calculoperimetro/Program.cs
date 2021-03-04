using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculoperimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            //definir variables
            int a = 10;
            int b = 10;
            int c = 7;
            int p = a + b + c;
            Console.WriteLine("el perimetro del trinagulo es:" + p);
            Console.WriteLine("presione cualquier tecla para continuar");
            Console.ReadKey();

        }
    }
}
