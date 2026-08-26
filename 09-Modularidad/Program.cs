/*
 * Tema: 09 - Modularidad
 * Descripción: Refactor del menú interactivo usando métodos independientes y el método LeerEntero con validación (int.TryParse).
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion;
        do
        {
            MostrarMenu();
            opcion = LeerEntero("Seleccione una opción: ");

            switch (opcion)
            {
                case 1:
                    SumarDosNumeros();
                    break;
                case 2:
                    VerificarPrimo();
                    break;
                case 3:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    break;
            }
        } while (opcion != 3);
    }

    // -----------------------------------------------------------------
    // MÉTODOS DE SOPORTE Y ENTRADA BLINDADA
    // -----------------------------------------------------------------

    static int LeerEntero(string mensaje)
    {
        int numero;
        while (true)
        {
            Console.Write(mensaje);
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out numero))
            {
                return numero;
            }

            Console.WriteLine("Error: Debe ingresar un número entero válido. Intente de nuevo.");
        }
    }

    static void MostrarMenu()
    {
        Console.WriteLine("\n=== MENÚ INTERACTIVO (Modularizado) ===");
        Console.WriteLine("1. Sumar dos números");
        Console.WriteLine("2. Verificar si un número es primo");
        Console.WriteLine("3. Salir");
    }

    // -----------------------------------------------------------------
    // MÉTODOS DE LAS OPCIONES DEL MENÚ
    // -----------------------------------------------------------------

    static void SumarDosNumeros()
    {
        Console.WriteLine("\n-- Sumar dos números --");
        int n1 = LeerEntero("Ingrese el primer número: ");
        int n2 = LeerEntero("Ingrese el segundo número: ");
        Console.WriteLine($"Resultado de la suma: {n1 + n2}");
    }

    static void VerificarPrimo()
    {
        Console.WriteLine("\n-- Verificar número primo --");
        int numPrimo = LeerEntero("Ingrese un número entero: ");
        bool esPrimo = true;

        if (numPrimo <= 1)
        {
            esPrimo = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(numPrimo); i++)
            {
                if (numPrimo % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }
        }

        if (esPrimo)
            Console.WriteLine($"El número {numPrimo} SÍ es primo.");
        else
            Console.WriteLine($"El número {numPrimo} NO es primo.");
    }
}