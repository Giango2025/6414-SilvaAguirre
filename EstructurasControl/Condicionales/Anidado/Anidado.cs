using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anidada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Estructura anidada para clasificación
            if (numero > 0)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine("✅ Número positivo y par");
                }
                else
                {
                    Console.WriteLine("✅ Número positivo e impar");
                }
            }
            else if (numero < 0)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine("❌ Número negativo y par");
                }
                else
                {
                    Console.WriteLine("❌ Número negativo e impar");
                }
            }
            else
            {
                Console.WriteLine("⚪ El número es cero");
            }
        }
    }
}
