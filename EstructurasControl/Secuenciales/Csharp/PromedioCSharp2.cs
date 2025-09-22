using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARCHIVO_CSHARP_EJEMPLO_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la temperatura en grados Celsius:");
            double celsius = Convert.ToDouble(Console.ReadLine());

            // Proceso (estructura secuencial: paso por paso)
            double fahrenheit = (celsius * 9 / 5) + 32;
            double kelvin = celsius + 273.15;

            // Salida
            Console.WriteLine("La temperatura en Fahrenheit es: " + fahrenheit);
            Console.WriteLine("La temperatura en Kelvin es: " + kelvin);

        }
    }
}
