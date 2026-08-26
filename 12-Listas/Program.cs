/*
 * Tema: 12 - Colecciones
 * Descripción: Lista de tareas (To-Do List) usando List<string> con opciones para 
 *              agregar, eliminar por número, marcar como hecha ("[x]"), listar y salir.
 */

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> tareas = new List<string>();
        int opcion;

        do
        {
            Console.WriteLine("\n=== LISTA DE TAREAS (To-Do List) ===");
            Console.WriteLine("1. Agregar tarea");
            Console.WriteLine("2. Listar tareas");
            Console.WriteLine("3. Marcar tarea como hecha");
            Console.WriteLine("4. Eliminar tarea por número");
            Console.WriteLine("5. Salir");
            opcion = LeerEntero("Seleccione una opción: ");

            switch (opcion)
            {
                case 1:
                    AgregarTarea(tareas);
                    break;
                case 2:
                    ListarTareas(tareas);
                    break;
                case 3:
                    MarcarTareaHecha(tareas);
                    break;
                case 4:
                    EliminarTarea(tareas);
                    break;
                case 5:
                    Console.WriteLine("Saliendo del gestor de tareas...");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    break;
            }
        } while (opcion != 5);
    }

    // -----------------------------------------------------------------
    // MÉTODOS DE GESTIÓN DE TAREAS
    // -----------------------------------------------------------------

    static void AgregarTarea(List<string> tareas)
    {
        Console.WriteLine("\n-- Agregar Nueva Tarea --");
        Console.Write("Escriba la descripción de la tarea: ");
        string descripcion = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(descripcion))
        {
            tareas.Add(descripcion);
            Console.WriteLine("¡Tarea agregada con éxito!");
        }
        else
        {
            Console.WriteLine("Error: La tarea no puede estar vacía.");
        }
    }

    static void ListarTareas(List<string> tareas)
    {
        Console.WriteLine("\n-- Lista de Tareas --");
        if (tareas.Count == 0)
        {
            Console.WriteLine("No hay tareas registradas.");
            return;
        }

        for (int i = 0; i < tareas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tareas[i]}");
        }
    }

    static void MarcarTareaHecha(List<string> tareas)
    {
        Console.WriteLine("\n-- Marcar Tarea como Hecha --");
        if (tareas.Count == 0)
        {
            Console.WriteLine("No hay tareas para marcar.");
            return;
        }

        ListarTareas(tareas);
        int numero = LeerEntero("Ingrese el número de la tarea que completó: ");

        int indice = numero - 1;
        if (indice >= 0 && indice < tareas.Count)
        {
            // Evitar marcar dos veces si ya contiene "[x]"
            if (!tareas[indice].StartsWith("[x]"))
            {
                tareas[indice] = "[x] " + tareas[indice];
                Console.WriteLine("¡Tarea marcada como hecha!");
            }
            else
            {
                Console.WriteLine("Esta tarea ya estaba marcada como hecha.");
            }
        }
        else
        {
            Console.WriteLine("Error: Número de tarea inválido.");
        }
    }

    static void EliminarTarea(List<string> tareas)
    {
        Console.WriteLine("\n-- Eliminar Tarea --");
        if (tareas.Count == 0)
        {
            Console.WriteLine("No hay tareas para eliminar.");
            return;
        }

        ListarTareas(tareas);
        int numero = LeerEntero("Ingrese el número de la tarea que desea eliminar: ");

        int indice = numero - 1;
        if (indice >= 0 && indice < tareas.Count)
        {
            string tareaEliminada = tareas[indice];
            tareas.RemoveAt(indice);
            Console.WriteLine($"Tarea eliminada: '{tareaEliminada}'");
        }
        else
        {
            Console.WriteLine("Error: Número de tarea inválido.");
        }
    }

    // Método auxiliar de entrada validada
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
}