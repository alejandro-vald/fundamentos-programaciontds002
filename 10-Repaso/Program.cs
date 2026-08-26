/*
 * Tema: 10 - Repaso Parcial
 * Descripción: Cajero automático con saldo inicial de 10,000, validación de PIN (máx 3 intentos), 
 *              menú modularizado (consultar, depositar, retirar con validación de fondos y múltiplos de 100).
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        // Configuración inicial
        decimal saldo = 10000.0m;
        string pinCorrecto = "1234"; 
        int intentosPin = 3;

        Console.WriteLine("=== BIENVENIDO AL BANCO ===");

        // Validación de PIN -Max 3 intentos
        bool accesoConcedido = false;
        while (intentosPin > 0)
        {
            Console.Write($"Ingrese su PIN de 4 dígitos (Intentos restantes: {intentosPin}): ");
            string pinIngresado = Console.ReadLine();

            if (pinIngresado == pinCorrecto)
            {
                accesoConcedido = true;
                break;
            }
            else
            {
                intentosPin--;
                Console.WriteLine("PIN incorrecto.");
            }
        }

        if (!accesoConcedido)
        {
            Console.WriteLine("\nTarjeta bloqueada por exceso de intentos fallidos. Saliendo...");
            return;
        }

        // Menú principal del cajero
        int opcion;
        do
        {
            MostrarMenuCajero();
            opcion = LeerEntero("Seleccione una opción: ");

            switch (opcion)
            {
                case 1:
                    ConsultarSaldo(saldo);
                    break;
                case 2:
                    saldo = DepositarDinero(saldo);
                    break;
                case 3:
                    saldo = RetirarDinero(saldo);
                    break;
                case 4:
                    Console.WriteLine("\nGracias por utilizar nuestro cajero automático. ¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("\nOpción inválida. Intente de nuevo.");
                    break;
            }
        } while (opcion != 4);
    }

    // -----------------------------------------------------------------
    // MÉTODOS DEL CAJERO AUTOMÁTICO
    // -----------------------------------------------------------------

    static void MostrarMenuCajero()
    {
        Console.WriteLine("\n=== CAJERO AUTOMÁTICO ===");
        Console.WriteLine("1. Consultar saldo");
        Console.WriteLine("2. Depositar dinero");
        Console.WriteLine("3. Retirar dinero");
        Console.WriteLine("4. Salir");
    }

    static void ConsultarSaldo(decimal saldoActual)
    {
        Console.WriteLine($"\nSu saldo actual es: ${saldoActual:N2}");
    }

    static decimal DepositarDinero(decimal saldoActual)
    {
        Console.WriteLine("\n-- Depósito de Dinero --");
        decimal monto = LeerDecimal("Ingrese la cantidad a depositar: $");

        if (monto <= 0)
        {
            Console.WriteLine("Error: El monto a depositar debe ser mayor a cero.");
            return saldoActual;
        }

        saldoActual += monto;
        Console.WriteLine($"Depósito exitoso. Su nuevo saldo es: ${saldoActual:N2}");
        return saldoActual;
    }

    static decimal RetirarDinero(decimal saldoActual)
    {
        Console.WriteLine("\n-- Retiro de Dinero --");
        decimal monto = LeerDecimal("Ingrese la cantidad a retirar (debe ser múltiplo de 100): $");

        // Validar que sea múltiplo de 100 y mayor a 0
        if (monto <= 0)
        {
            Console.WriteLine("Error: El monto debe ser mayor a cero.");
            return saldoActual;
        }

        if (monto % 100 != 0)
        {
            Console.WriteLine("Error: El cajero solo entrega billetes múltiplos de 100.");
            return saldoActual;
        }

        // Validar fondos suficientes
        if (monto > saldoActual)
        {
            Console.WriteLine("Error: Fondos insuficientes para realizar esta operación.");
            return saldoActual;
        }

        saldoActual -= monto;
        Console.WriteLine($"Retiro exitoso. Por favor retire su efectivo. Su nuevo saldo es: ${saldoActual:N2}");
        return saldoActual;
    }

    // -----------------------------------------------------------------
    // MÉTODOS DE ENTRADA BLINDADA
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

            Console.WriteLine("Error: Debe ingresar un número entero válido.");
        }
    }

    static decimal LeerDecimal(string mensaje)
    {
        decimal numero;
        while (true)
        {
            Console.Write(mensaje);
            string entrada = Console.ReadLine();

            if (decimal.TryParse(entrada, out numero))
            {
                return numero;
            }

            Console.WriteLine("Error: Debe ingresar una cantidad numérica válida.");
        }
    }
}