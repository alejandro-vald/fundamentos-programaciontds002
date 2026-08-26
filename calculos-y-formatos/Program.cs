/*
 * Tema: 04 - Cálculos y Facturación
 * Descripción: Factura de colmado con formato, nómina simple con deducciones de ley y conversor de segundos a reloj.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        // -----------------------------------------------------------------
        // 1. FACTURA DE COLMADO
        // -----------------------------------------------------------------
        Console.WriteLine("=== 1. FACTURA DE COLMADO ===");
        Console.Write("Ingrese el nombre del cliente: ");
        string cliente = Console.ReadLine();

        // Producto 1
        Console.Write("Nombre del producto 1: ");
        string p1Nombre = Console.ReadLine();
        Console.Write("Precio de " + p1Nombre + ": ");
        double p1Precio = Convert.ToDouble(Console.ReadLine());
        Console.Write("Cantidad de " + p1Nombre + ": ");
        int p1Cantidad = Convert.ToInt32(Console.ReadLine());

        // Producto 2
        Console.Write("Nombre del producto 2: ");
        string p2Nombre = Console.ReadLine();
        Console.Write("Precio de " + p2Nombre + ": ");
        double p2Precio = Convert.ToDouble(Console.ReadLine());
        Console.Write("Cantidad de " + p2Nombre + ": ");
        int p2Cantidad = Convert.ToInt32(Console.ReadLine());

        // Producto 3
        Console.Write("Nombre del producto 3: ");
        string p3Nombre = Console.ReadLine();
        Console.Write("Precio de " + p3Nombre + ": ");
        double p3Precio = Convert.ToDouble(Console.ReadLine());
        Console.Write("Cantidad de " + p3Nombre + ": ");
        int p3Cantidad = Convert.ToInt32(Console.ReadLine());

        // Cálculos
        double subtotal1 = p1Precio * p1Cantidad;
        double subtotal2 = p2Precio * p2Cantidad;
        double subtotal3 = p3Precio * p3Cantidad;
        double subtotalGeneral = subtotal1 + subtotal2 + subtotal3;
        double itbis = subtotalGeneral * 0.18;
        double total = subtotalGeneral + itbis;

        // Impresión de factura formateada
        Console.WriteLine("\n========================================");
        Console.WriteLine($" CLIENTE: {cliente}");
        Console.WriteLine("========================================");
        Console.WriteLine("Cant  Producto          Precio   Subtotal");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"{p1Cantidad,-5} {p1Nombre,-15} {p1Precio,6:C} {subtotal1,9:C}");
        Console.WriteLine($"{p2Cantidad,-5} {p2Nombre,-15} {p2Precio,6:C} {subtotal2,9:C}");
        Console.WriteLine($"{p3Cantidad,-5} {p3Nombre,-15} {p3Precio,6:C} {subtotal3,9:C}");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"SUBTOTAL:                  {subtotalGeneral,12:C}");
        Console.WriteLine($"ITBIS (18%):               {itbis,12:C}");
        Console.WriteLine($"TOTAL A PAGAR:             {total,12:C}");
        Console.WriteLine("========================================");


        // -----------------------------------------------------------------
        // 2. NÓMINA SIMPLE
        // -----------------------------------------------------------------
        Console.WriteLine("\n=== 2. NÓMINA SIMPLE ===");
        Console.Write("Ingrese las horas trabajadas: ");
        double horasTrabajadas = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Ingrese la tarifa por hora: ");
        double tarifaHora = Convert.ToDouble(Console.ReadLine());

        double salarioBruto = horasTrabajadas * tarifaHora;
        double descuentoAfp = salarioBruto * 0.0287; // 2.87%
        double descuentoSfs = salarioBruto * 0.0304; // 3.04%
        double salarioNeto = salarioBruto - (descuentoAfp + descuentoSfs);

        Console.WriteLine($"Salario Bruto: {salarioBruto:C}");
        Console.WriteLine($"Descuento AFP (2.87%): {descuentoAfp:C}");
        Console.WriteLine($"Descuento SFS (3.04%): {descuentoSfs:C}");
        Console.WriteLine($"Salario Neto: {salarioNeto:C}");


        // -----------------------------------------------------------------
        // 3. RELOJ (Segundos a Horas, Minutos y Segundos)
        // -----------------------------------------------------------------
        Console.WriteLine("\n=== 3. CONVERSOR DE TIEMPO (RELOJ) ===");
        Console.Write("Ingrese la cantidad total de segundos: ");
        int totalSegundos = Convert.ToInt32(Console.ReadLine());

        int horas = totalSegundos / 3600;
        int segundosRestantes = totalSegundos % 3600;
        int minutos = segundosRestantes / 60;
        int segundos = segundosRestantes % 60;

        Console.WriteLine($"Equivalente: {horas} hora(s), {minutos} minuto(s) y {segundos} segundo(s).");
    }
}