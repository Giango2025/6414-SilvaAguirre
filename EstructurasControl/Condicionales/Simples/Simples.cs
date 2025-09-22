using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMPLE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULO DE IMPUESTO A LA RENTA");
            Console.WriteLine("==============================");

            double UIT = 5050;

            Console.Write("Ingrese su renta anual: S/ ");
            double renta = Convert.ToDouble(Console.ReadLine());

            double uits = renta / UIT;
            Console.WriteLine($"Su renta equivale a: {uits:F1} UITs");

            if (uits > 0)
            {
                if (uits <= 7)
                {
                    Console.WriteLine("\nNO PAGA IMPUESTO");
                    Console.WriteLine("Renta exonerada");
                }
                else
                {
                    if (uits <= 15)
                    {
                        double excedente = renta - (7 * UIT);
                        double impuesto = excedente * 0.05;
                        Console.WriteLine("\nPAGA IMPUESTO - Primera Categoria");
                        Console.WriteLine($"Excedente: S/ {excedente:F2}");
                        Console.WriteLine($"Impuesto 5%: S/ {impuesto:F2}");
                    }
                    else
                    {
                        if (uits <= 30)
                        {
                            double excedente = renta - (7 * UIT);
                            double impuesto = excedente * 0.05;
                            Console.WriteLine("\nPAGA IMPUESTO - Segunda Categoria");
                            Console.WriteLine($"Excedente: S/ {excedente:F2}");
                            Console.WriteLine($"Impuesto 5%: S/ {impuesto:F2}");
                        }
                        else
                        {
                            double excedente = renta - (7 * UIT);
                            double impuesto = excedente * 0.05;
                            Console.WriteLine("\nPAGA IMPUESTO - Tercera Categoria");
                            Console.WriteLine($"Excedente: S/ {excedente:F2}");
                            Console.WriteLine($"Impuesto 5%: S/ {impuesto:F2}");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("\nERROR: Renta no válida");
            }

            Console.WriteLine("\n========================");
            Console.WriteLine($"Valor UIT: S/ {UIT}");
            Console.WriteLine("Exonerado hasta 7 UITs");
            Console.ReadKey();
        }
    }
}