/*
 * Tema: 02 - Variables, tipos y operadores
 * Descripción: Resolución de ejercicios de ficha de datos, operadores y precedencia.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== EJERCICIO 1: FICHA DE DATOS ===");
        
        // Declaración de  las variables 
        string nombre = "Moises";
        int edad = 20;                  // int
        double estatura = 1.68;          // double
        float peso = 200.0f;             // float
        char inicialApellido = 'N';      // char
        bool estudianteActivo = true;    // bool

        // Imprimir el formato en una sola línea
        Console.WriteLine($"Nombre: {nombre}, Inicial: {inicialApellido}., Edad: {edad} años, Estatura: {estatura}m, Peso: {peso}lbs, Activo: {estudianteActivo}");

        Console.WriteLine("\n=== EJERCICIO 2: OPERADORES EN ACCIÓN ===");
        
        int num1 = 10;
        int num2 = 3;

        // Operaciones aritméticas
        Console.WriteLine($"Suma: {num1} + {num2} = {num1 + num2}");
        Console.WriteLine($"Resta: {num1} - {num2} = {num1 - num2}");
        Console.WriteLine($"Multiplicación: {num1} * {num2} = {num1 * num2}");
        Console.WriteLine($"División entera: {num1} / {num2} = {num1 / num2}");
        Console.WriteLine($"División real (con casting): {(double)num1} / {num2} = {(double)num1 / num2}");
        Console.WriteLine($"Módulo: {num1} % {num2} = {num1 % num2}");

        // Comparaciones relacionales
        Console.WriteLine($"¿{num1} > {num2}?: {num1 > num2}");
        Console.WriteLine($"¿{num1} == {num2}?: {num1 == num2}");
        Console.WriteLine($"¿{num1} != {num2}?: {num1 != num2}");

        // Operaciones lógicas
        bool condicion1 = true;
        bool condicion2 = false;
        Console.WriteLine($"AND lógico (true && false): {condicion1 && condicion2}");
        Console.WriteLine($"OR lógico (true || false): {condicion1 || condicion2}");

        Console.WriteLine("\n=== EJERCICIO 3: PRECEDENCIA ===");
        
        
        Console.WriteLine($"5 + 3 * 2 = {5 + 3 * 2}");

        Console.WriteLine($"10 / 4 = {10 / 4}");

        Console.WriteLine($"10 / 4.0 = {10 / 4.0}");

        Console.WriteLine($"10 % 4 = {10 % 4}");
    }
}