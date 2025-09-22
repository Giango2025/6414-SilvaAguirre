using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Llueve actualmente? (si/no)");
            string respuesta = Console.ReadLine();

            // Condicional doble simple y claro
            if (respuesta.ToLower() == "si")
            {
                Console.WriteLine("☔ Lleva paraguas contigo");
            }
            else
            {
                Console.WriteLine("☀️ No necesitas paraguas hoy");
            }

            Console.WriteLine("¡Que tengas un buen día!");
        }
    }
}


