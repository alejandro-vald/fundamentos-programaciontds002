/*
 * Tema: 07 - Ciclos (while, do-while y for)
 * Descripción: Tabla de multiplicar, menú interactivo con do-while y juego Adivina el número.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        // -----------------------------------------------------------------
        // 1. TABLA DE MULTIPLICAR (usando for)
        // -----------------------------------------------------------------
        Console.WriteLine("=== 1. TABLA DE MULTIPLICAR ===");
        Console.Write("Ingrese un número para ver su tabla: ");
        int numeroTabla = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"\nTabla del {numeroTabla}:");
        for (int i = 1; i <= 12; i++)
        {
            Console.WriteLine($"{numeroTabla} x {i} = {numeroTabla * i}");
        }


        // -----------------------------------------------------------------
        // 2. MENÚ QUE NO MUERE (usando do-while)
        // -----------------------------------------------------------------
        int opcionMenu;
        do
        {
            Console.WriteLine("\n=== 2. MENÚ INTERACTIVO (do-while) ===");
            Console.WriteLine("1. Sumar dos números");
            Console.WriteLine("2. Verificar si un número es primo");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            opcionMenu = Convert.ToInt32(Console.ReadLine());

            switch (opcionMenu)
            {
                case 1:
                    Console.Write("Ingrese el primer número: ");
                    double n1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese el segundo número: ");
                    double n2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Resultado de la suma: {n1 + n2}");
                    break;

                case 2:
                    Console.Write("Ingrese un número entero para comprobar si es primo: ");
                    int numPrimo = Convert.ToInt32(Console.ReadLine());
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
                    break;

                case 3:
                    Console.WriteLine("Saliendo del menú...");
                    break;

                default:
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    break;
            }
        } while (opcionMenu != 3);


        // -----------------------------------------------------------------
        // 3. ADIVINA EL NÚMERO (con contador de intentos y volver a jugar)
        // -----------------------------------------------------------------
        string jugarDeNuevo = "s";
        Random random = new Random();

        while (jugarDeNuevo.ToLower() == "s")
        {
            Console.WriteLine("\n=== 3. JUEGO: ADIVINA EL NÚMERO ===");
            int numeroSecreto = random.Next(1, 21); // Número aleatorio entre 1 y 20
            int intento = 0;
            int contadorIntentos = 0;

            Console.WriteLine("¡He pensado un número del 1 al 20! Adivínalo.");

            while (intento != numeroSecreto)
            {
                Console.Write("Ingresa tu suposición: ");
                intento = Convert.ToInt32(Console.ReadLine());
                contadorIntentos++;

                if (intento < numeroSecreto)
                {
                    Console.WriteLine("Demasiado bajo. Sube un poco.");
                }
                else if (intento > numeroSecreto)
                {
                    Console.WriteLine("Demasiado alto. Baja un poco.");
                }
                else
                {
                    Console.WriteLine($"¡Felicidades! Adivinaste el número en {contadorIntentos} intento(s).");
                }
            }

            Console.Write("¿Deseas volver a jugar? (s/n): ");
            jugarDeNuevo = Console.ReadLine();
        }
    }
}