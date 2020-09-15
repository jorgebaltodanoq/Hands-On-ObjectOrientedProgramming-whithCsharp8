using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp08_Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            //ClaseGenerica<int> valor = new ClaseGenerica<int>(1200);
            //ClaseGenerica<string> cadena = new ClaseGenerica<string>("1200");

            //valor.printType();
            //int a = valor.GetAdd();
            //Console.WriteLine($"El valor es: {a}");

            //cadena.printType();
            //string ca = cadena.GetAdd();
            //Console.WriteLine($"El valor es: {ca}");

            int entero = MetodoGenerico.Maximo<int>(14,25);
            double doble = MetodoGenerico.Maximo<double>(25.50, 332.52);

            Console.WriteLine($"The Large value is {entero}");
            Console.WriteLine($"The Double Large value is {doble} ");


            Console.WriteLine("Enter close");
            _ = Console.ReadKey();
        }
    }
}
