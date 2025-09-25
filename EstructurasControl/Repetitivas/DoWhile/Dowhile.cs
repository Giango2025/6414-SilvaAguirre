using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        int numero;

        do
        {
            Console.Write("Ingresa un número (10 para salir): ");
            // Convertimos la entrada de texto a un número entero.
            // Si la conversión falla, 'numero' será 0.
            int.TryParse(Console.ReadLine(), out numero);

            // Esta línea se ejecutará al menos una vez, incluso si el usuario
            // no ingresa un número, ya que la condición se evalúa al final.
            Console.WriteLine($"El número que ingresaste es: {numero}\n");

        } while (numero != 10); // El ciclo continuará mientras el número no sea 10.

        Console.WriteLine("¡Saliste del bucle!");
    }
}