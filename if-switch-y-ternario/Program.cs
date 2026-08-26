/*
 * Tema: 06 - Estructuras de Decisión (Condicionales)
 * Descripción: Calificación ITLA, Menú de cafetería con switch, Tipos de triángulo, Operador ternario y Año bisiesto.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        // -----------------------------------------------------------------
        // 1. CALIFICACIÓN ITLA
        // -----------------------------------------------------------------
        Console.WriteLine("=== 1. CALIFICACIÓN ITLA ===");
        Console.Write("Ingrese la nota (0 - 100): ");
        int nota = Convert.ToInt32(Console.ReadLine());

        if (nota < 0 || nota > 100)
        {
            Console.WriteLine("Error: La nota ingresada está fuera del rango válido (0-100).");
        }
        else
        {
            string letra = "";
            if (nota >= 90)
                letra = "A";
            else if (nota >= 80)
                letra = "B";
            else if (nota >= 70)
                letra = "C";
            else
                letra = "F";

            string estado = nota >= 70 ? "Aprobado" : "Reprobado";
            Console.WriteLine($"Calificación: {letra} | Estado: {estado} (Mínimo 70)");
        }


        // -----------------------------------------------------------------
        // 2. MENÚ DE CAFETERÍA
        // -----------------------------------------------------------------
        Console.WriteLine("\n=== 2. MENÚ DE CAFETERÍA ===");
        Console.WriteLine("1. Mangú con los tres golpes - $150.00");
        Console.WriteLine("2. Empanada de pollo        - $60.00");
        Console.WriteLine("3. Jugo de chinola natural  - $80.00");
        Console.WriteLine("4. Café espresso            - $50.00");
        Console.WriteLine("5. Pastelito de yuca        - $70.00");
        Console.Write("Seleccione una opción (1-5): ");
        int opcion = Convert.ToInt32(Console.ReadLine());

        double precio = 0;
        string producto = "";
        bool opcionValida = true;

        switch (opcion)
        {
            case 1:
                producto = "Mangú con los tres golpes";
                precio = 150.00;
                break;
            case 2:
                producto = "Empanada de pollo";
                precio = 60.00;
                break;
            case 3:
                producto = "Jugo de chinola natural";
                precio = 80.00;
                break;
            case 4:
                producto = "Café espresso";
                precio = 50.00;
                break;
            case 5:
                producto = "Pastelito de yuca";
                precio = 70.00;
                break;
            default:
                opcionValida = false;
                Console.WriteLine("Error: Opción de menú inválida.");
                break;
        }

        if (opcionValida)
        {
            Console.Write($"Ingrese la cantidad de '{producto}': ");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            double totalPagar = precio * cantidad;
            Console.WriteLine($"Producto: {producto} | Cantidad: {cantidad} | Total a pagar: {totalPagar:C}");
        }


        // -----------------------------------------------------------------
        // 3. TRIÁNGULO
        // -----------------------------------------------------------------
        Console.WriteLine("\n=== 3. TIPOS DE TRIÁNGULO ===");
        Console.Write("Ingrese el lado A: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el lado B: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el lado C: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Validar si forman un triángulo (la suma de dos lados debe ser mayor que el tercero)
        if ((a + b > c) && (a + c > b) && (b + c > a))
        {
            Console.WriteLine("¡Sí forman un triángulo válido!");
            if (a == b && b == c)
            {
                Console.WriteLine("Tipo: Equilátero (todos los lados iguales).");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("Tipo: Isósceles (dos lados iguales).");
            }
            else
            {
                Console.WriteLine("Tipo: Escaleno (todos los lados diferentes).");
            }
        }
        else
        {
            Console.WriteLine("Los valores ingresados NO forman un triángulo válido.");
        }


        // -----------------------------------------------------------------
        // 4. PAR O IMPAR / POSITIVO, NEGATIVO O CERO 
        // -----------------------------------------------------------------
        Console.WriteLine("\n=== 4. OPERADOR TERNARIO ===");
        Console.Write("Ingrese un número entero: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        // Par o impar 
        string parImpar = (numero % 2 == 0) ? "par" : "impar";
        Console.WriteLine($"El número {numero} es {parImpar}.");

        // Ampliación: positivo, negativo o cero 
        string signo = (numero > 0) ? "positivo" : (numero < 0) ? "negativo" : "cero";
        Console.WriteLine($"El número {numero} es {signo}.");


        // -----------------------------------------------------------------
        // 5. AÑO BISIESTO
        // -----------------------------------------------------------------
        Console.WriteLine("\n=== 5. AÑO BISIESTO ===");
        Console.Write("Ingrese un año: ");
        int anio = Convert.ToInt32(Console.ReadLine());

        // Condición compuesta 
        if ((anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0))
        {
            Console.WriteLine($"El año {anio} ES bisiesto.");
        }
        else
        {
            Console.WriteLine($"El año {anio} NO es bisiesto.");
        }
    }
}