using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== CÁLCULO DE SUMATORIA Y PROMEDIO ===\n");

        int[] numeros = { 10, 20, 30, 40, 50 };
        int suma = 0;

        Console.WriteLine("Números a procesar: " + string.Join(", ", numeros));
        Console.WriteLine(new string('-', 30));

        for (int i = 0; i < numeros.Length; i++)
        {
            suma += numeros[i];
            Console.WriteLine($"Iteración {i}: Suma parcial = {suma}");
        }

        double promedio = (double)suma / numeros.Length;
        Console.WriteLine(new string('-', 30));
        Console.WriteLine($"Suma total: {suma}");
        Console.WriteLine($"Promedio: {promedio:F2}");
    }
}