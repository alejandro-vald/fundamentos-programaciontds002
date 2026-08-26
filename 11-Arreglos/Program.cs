/*
 * Tema: 11 - Arreglos
 * Descripción: 1. Estadísticas de 10 notas (promedio, mayor, menor, notas por encima del promedio).
 *              2. Búsqueda lineal de un nombre en un arreglo de 8 elementos.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        // -----------------------------------------------------------------
        // 1. ESTADÍSTICAS DE 10 NOTAS
        // -----------------------------------------------------------------
        Console.WriteLine("=== 1. ESTADÍSTICAS DE 10 NOTAS ===");
        double[] notas = new double[10];
        double suma = 0;

        // Leer las 10 notas
        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write($"Ingrese la nota #{i + 1}: ");
            notas[i] = Convert.ToDouble(Console.ReadLine());
            suma += notas[i];
        }

        // Calcular promedio
        double promedio = suma / notas.Length;

        // Encontrar mayor y menor
        double notaMayor = notas[0];
        double notaMenor = notas[0];

        for (int i = 1; i < notas.Length; i++)
        {
            if (notas[i] > notaMayor)
            {
                notaMayor = notas[i];
            }
            if (notas[i] < notaMenor)
            {
                notaMenor = notas[i];
            }
        }

        // Contar cuántas están por encima del promedio
        int contadorEncimaPromedio = 0;
        foreach (double nota in notas)
        {
            if (nota > promedio)
            {
                contadorEncimaPromedio++;
            }
        }

        // Mostrar resultados
        Console.WriteLine("\n--- Resultados Estadísticos ---");
        Console.WriteLine($"Promedio general: {promedio:F2}");
        Console.WriteLine($"Nota más alta: {notaMayor}");
        Console.WriteLine($"Nota más baja: {notaMenor}");
        Console.WriteLine($"Cantidad de notas por encima del promedio: {contadorEncimaPromedio}");


        // -----------------------------------------------------------------
        // 2. BÚSQUEDA LINEAL DE UN NOMBRE (Arreglo de 8 nombres)
        // -----------------------------------------------------------------
        Console.WriteLine("\n=== 2. BÚSQUEDA DE NOMBRES ===");
        string[] nombres = new string[8];

        Console.WriteLine("Ingrese 8 nombres para el registro:");
        for (int i = 0; i < nombres.Length; i++)
        {
            Console.Write($"Nombre #{i + 1}: ");
            nombres[i] = Console.ReadLine();
        }

        Console.Write("\nIngrese el nombre que desea buscar: ");
        string nombreBusqueda = Console.ReadLine();

        int posicionEncontrada = -1;

        // Búsqueda lineal con for
        for (int i = 0; i < nombres.Length; i++)
        {
            // Comparamos ignorando mayúsculas/minúsculas para mayor comodida :)
            if (nombres[i].Equals(nombreBusqueda, StringComparison.OrdinalIgnoreCase))
            {
                posicionEncontrada = i;
                break; 
            }
        }

        // Mostrar resultado de la búsqueda
        if (posicionEncontrada != -1)
        {
            Console.WriteLine($"¡Encontrado! El nombre '{nombreBusqueda}' está en la posición {posicionEncontrada} (índice del arreglo) / Posición real #{posicionEncontrada + 1}.");
        }
        else
        {
            Console.WriteLine($"El nombre '{nombreBusqueda}' no existe en el arreglo.");
        }
    }
}