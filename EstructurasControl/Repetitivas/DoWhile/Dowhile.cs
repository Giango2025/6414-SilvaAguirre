using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo 1: Sistema de intentos de login
            Console.WriteLine("=== SISTEMA DE LOGIN ===");
            LoginSystem();

            Console.WriteLine("\n" + new string('=', 40) + "\n");

            // Ejemplo 2: Menú interactivo
            Console.WriteLine("=== MENÚ INTERACTIVO ===");
            InteractiveMenu();
        }

        static void LoginSystem()
        {
            string usuarioCorrecto = "admin";
            string passwordCorrecto = "1234";
            int intentosMaximos = 3;
            int intentos = 0;
            bool accesoConcedido = false;

            do
            {
                Console.Clear();
                Console.WriteLine($"Intento {intentos + 1} de {intentosMaximos}");
                Console.Write("Usuario: ");
                string usuario = Console.ReadLine();

                Console.Write("Contraseña: ");
                string password = Console.ReadLine();

                if (usuario == usuarioCorrecto && password == passwordCorrecto)
                {
                    accesoConcedido = true;
                    Console.WriteLine("✅ ¡Acceso concedido! Bienvenido al sistema.");
                }
                else
                {
                    intentos++;
                    Console.WriteLine("❌ Credenciales incorrectas.");

                    if (intentos < intentosMaximos)
                    {
                        Console.WriteLine($"Te quedan {intentosMaximos - intentos} intentos.");
                        Console.WriteLine("Presiona cualquier tecla para continuar...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("🚫 Has excedido el número máximo de intentos.");
                    }
                }
            }
            while (!accesoConcedido && intentos < intentosMaximos);

            if (accesoConcedido)
            {
                Console.WriteLine("🎉 Iniciando sesión...");
            }
        }

        static void InteractiveMenu()
        {
            int opcion;
            double totalCompra = 0;

            do
            {
                Console.WriteLine("\n--- MENÚ PRINCIPAL ---");
                Console.WriteLine("1. Agregar producto ($10.99)");
                Console.WriteLine("2. Agregar producto ($15.50)");
                Console.WriteLine("3. Ver total de compra");
                Console.WriteLine("4. Finalizar compra");
                Console.WriteLine("5. Salir");
                Console.Write("Selecciona una opción: ");

                // Validación de entrada numérica
                while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 5)
                {
                    Console.Write("❌ Opción inválida. Ingresa un número del 1 al 5: ");
                }

                switch (opcion)
                {
                    case 1:
                        totalCompra += 10.99;
                        Console.WriteLine("✅ Producto de $10.99 agregado al carrito");
                        break;
                    case 2:
                        totalCompra += 15.50;
                        Console.WriteLine("✅ Producto de $15.50 agregado al carrito");
                        break;
                    case 3:
                        Console.WriteLine($"💰 Total actual: ${totalCompra:F2}");
                        break;
                    case 4:
                        if (totalCompra > 0)
                        {
                            Console.WriteLine($"🎊 Compra finalizada! Total a pagar: ${totalCompra:F2}");
                            totalCompra = 0; // Resetear carrito
                        }
                        else
                        {
                            Console.WriteLine("🛒 El carrito está vacío. Agrega productos primero.");
                        }
                        break;
                    case 5:
                        if (totalCompra > 0)
                        {
                            Console.WriteLine($"⚠️  Tienes productos en el carrito por ${totalCompra:F2}");
                            Console.Write("¿Estás seguro de que quieres salir? (s/n): ");
                            string confirmacion = Console.ReadLine().ToLower();

                            if (confirmacion != "s")
                            {
                                opcion = 0; // Continuar en el menú
                                Console.WriteLine("Continuando con la compra...");
                            }
                        }
                        break;
                }

                // Pequeña pausa para mejor UX
                if (opcion != 5)
                {
                    Console.WriteLine("Presiona cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (opcion != 5);

            Console.WriteLine("👋 ¡Gracias por usar nuestro sistema! Hasta pronto.");
        }
    }
}