using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, ingresa tu calificación (del 0 al 100):");
            string entrada = Console.ReadLine();
            int calificacion;

            if (int.TryParse(entrada, out calificacion))
            {
                if (calificacion >= 90)
                {
                    Console.WriteLine("¡Excelente! Has obtenido una A. 🥳");
                }
                else if (calificacion >= 80)
                {
                    Console.WriteLine("Muy bien, tienes una B. Sigue así. 👍");
                }
                else if (calificacion >= 70)
                {
                    Console.WriteLine("Aprobado con una C. ¡No está mal! 😉");
                }
                else if (calificacion >= 60)
                {
                    Console.WriteLine("Aprobado, pero con una D. Hay que mejorar. 🤔");
                }
                else
                {
                    Console.WriteLine("Reprobado. Tu calificación es F. 😥");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingresa un número. ⛔");
            }   }
    }
}
