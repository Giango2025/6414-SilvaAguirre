using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULAR PROMEDIO DE NOTAS");
            Console.WriteLine("==========================");

            // Pedir las 3 notas
            Console.Write("Nota 1: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 2: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 3: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            // Calcular el promedio
            double promedio = (nota1 + nota2 + nota3) / 3;

            // Mostrar resultado
            Console.WriteLine("==========================");
            Console.WriteLine("PROMEDIO: " + promedio.ToString("0.00"));

            Console.Write("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
