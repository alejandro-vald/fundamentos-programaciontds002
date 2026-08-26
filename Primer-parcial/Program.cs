/*
 * Tema: 05 - Repaso (Calculadora de viaje)
 * Descripción: Calcula el costo total de combustible de un viaje y divide el gasto entre los pasajeros.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== CALCULADORA DE VIAJE ===");
        
        // 1. Lectura de datos
        Console.Write("Ingrese la distancia total del viaje en km: ");
        double distancia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el consumo del vehículo (km por galón): ");
        double consumoKmPorGalon = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el precio actual del galón de combustible: ");
        double precioGalon = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el número total de pasajeros: ");
        int pasajeros = Convert.ToInt32(Console.ReadLine());

        // 2. Cálculos
        // Cuántos galones se necesitan en total
        double galonesTotales = distancia / consumoKmPorGalon;
        
        // Costo total del combustible
        double costoTotal = galonesTotales * precioGalon;

        // Cuánto le toca pagar a cada pasajero
        double costoPorPasajero = pasajeros > 0 ? costoTotal / pasajeros : costoTotal;

        // 3. Resultados formateados
        Console.WriteLine("\n----------------------------------------");
        Console.WriteLine($" Galones de combustible necesarios: {galonesTotales:F2} gal");
        Console.WriteLine($" Costo total del combustible:       {costoTotal:C}");
        Console.WriteLine($" Cantidad de pasajeros:             {pasajeros}");
        Console.WriteLine($" A pagar por cada pasajero:         {costoPorPasajero:C}");
        Console.WriteLine("----------------------------------------");
    }
}