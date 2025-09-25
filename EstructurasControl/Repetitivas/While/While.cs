using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        Console.WriteLine("=== WHILE CON CONTADOR ===\n");

        int contador = 1;

        while (contador <= 5)
        {
            Console.WriteLine($"Iteración número: {contador}");
            contador++; // Incremento manual
        }

        Console.WriteLine($"\nValor final del contador: {contador}");
    }
}