/*
 * Tema: 03 - Programas secuenciales con fórmulas
 * Descripción: Conversor de temperatura, áreas/perímetros, cambio de moneda y saludo personalizado.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        // -----------------------------------------------------------------
        // 1. CONVERSOR DE TEMPERATURA
        // -----------------------------------------------------------------
        Console.WriteLine("=== 1. CONVERSOR DE TEMPERATURA ===");
        Console.Write("Ingrese los grados Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = (celsius * 9.0 / 5.0) + 32;
        double kelvin = celsius + 273.15;

        Console.WriteLine($"Fahrenheit: {fahrenheit:F2}°F");
        Console.WriteLine($"Kelvin: {kelvin:F2}K");


        // -----------------------------------------------------------------
        // 2. ÁREA Y PERÍMETRO
        // -----------------------------------------------------------------
        Console.WriteLine("\n=== 2. ÁREA Y PERÍMETRO (Círculo y Rectángulo) ===");
        
        // Círculo
        Console.Write("Ingrese el radio del círculo: ");
        double radio = Convert.ToDouble(Console.ReadLine());
        double areaCirculo = Math.PI * Math.Pow(radio, 2);
        double perimetroCirculo = 2 * Math.PI * radio;
        Console.WriteLine($"Círculo -> Área: {areaCirculo:F2}, Perímetro: {perimetroCirculo:F2}");

        // Rectángulo
        Console.Write("Ingrese la base del rectángulo: ");
        double baseRect = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese la altura del rectángulo: ");
        double alturaRect = Convert.ToDouble(Console.ReadLine());
        double areaRectangulo = baseRect * alturaRect;
        double perimetroRectangulo = 2 * (baseRect + alturaRect);
        Console.WriteLine($"Rectángulo -> Área: {areaRectangulo:F2}, Perímetro: {perimetroRectangulo:F2}");


        // -----------------------------------------------------------------
        // 3. CAMBIO DE MONEDA
        // -----------------------------------------------------------------
        Console.WriteLine("\n=== 3. CAMBIO DE MONEDA ===");
        Console.Write("Ingrese el monto en pesos dominicanos (DOP): ");
        double pesos = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Ingrese la tasa de cambio actual del dólar (USD): ");
        double tasaDolar = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Ingrese la tasa de cambio actual del euro (EUR): ");
        double tasaEuro = Convert.ToDouble(Console.ReadLine());

        double dolares = pesos / tasaDolar;
        double euros = pesos / tasaEuro;

        Console.WriteLine($"Equivalente en Dólares: ${dolares:F2} USD");
        Console.WriteLine($"Equivalente en Euros: €{euros:F2} EUR");


        // -----------------------------------------------------------------
        // 4. SALUDO PERSONALIZADO
        // -----------------------------------------------------------------
        Console.WriteLine("\n=== 4. SALUDO PERSONALIZADO ===");
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();
        
        Console.Write("Ingrese su apellido: ");
        string apellido = Console.ReadLine();

        string nombreCompleto = $"{nombre} {apellido}";
        string nombreMayusculas = nombreCompleto.ToUpper();
        int cantidadLetras = nombreCompleto.Replace(" ", "").Length;
        string iniciales = $"{nombre.Substring(0, 1)}{apellido.Substring(0, 1)}".ToUpper();

        Console.WriteLine($"Nombre completo en mayúsculas: {nombreMayusculas}");
        Console.WriteLine($"Cantidad de letras (sin espacios): {cantidadLetras}");
        Console.WriteLine($"Iniciales: {iniciales}");
    }
}