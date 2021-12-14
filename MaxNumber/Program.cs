using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] subs = { "1" };

            List<string> numbers = new List<string>();

            while ( numbers.Count != 10)
            {
                Console.WriteLine("Ingrese 10 numeros diferentes entre sí, separados por espacios: ");
                var strNumbers = Console.ReadLine();
                numbers = strNumbers.Split(' ').Distinct().ToList();
            }

            int max = Int32.MinValue;
            bool success = true;
            foreach (var item in numbers)
            {
                var currentNumber = 0;
                //var currentNumber = Int32.Parse(item);
                success = int.TryParse(item, out currentNumber);
                if (success)
                {
                    if (currentNumber > max)
                    {
                        max = currentNumber;
                    }
                }
                else
                {
                    Console.WriteLine("Valor no numerico ingresado");
                    break;
                }
            }

            Console.WriteLine("El número mayor es: {0}", max);
            Console.Write("Ejecución finalizada, precione cualquier tecla");
            Console.ReadKey();
        }
    }
}
