/*
 * Tema: 08 - Métodos (void, return y sobrecarga)
 * Descripción: Biblioteca matemática con Factorial, EsPrimo, Mcd y Potencia (sin Math.Pow), además de sobrecarga de métodos Area.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        // -----------------------------------------------------------------
        // 1. PRUEBA DE LA BIBLIOTECA MATEMÁTICA (Menú)
        // -----------------------------------------------------------------
        Console.WriteLine("=== 1. BIBLIOTECA MATEMÁTICA ===");
        
        // Probar Factorial
        Console.Write("Ingrese un número entero para calcular su factorial: ");
        int numFact = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Factorial de {numFact} = {Factorial(numFact)}");

        // Probar EsPrimo
        Console.Write("\nIngrese un número entero para verificar si es primo: ");
        int numPrimoCheck = Convert.ToInt32(Console.ReadLine());
        if (EsPrimo(numPrimoCheck))
            Console.WriteLine($"El número {numPrimoCheck} SÍ es primo.");
        else
            Console.WriteLine($"El número {numPrimoCheck} NO es primo.");

        // Probar Mcd (Máximo Común Divisor)
        Console.WriteLine("\nCálculo del Máximo Común Divisor (MCD):");
        Console.Write("Ingrese el primer número: ");
        int aMcd = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        int bMcd = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"MCD de {aMcd} y {bMcd} = {Mcd(aMcd, bMcd)}");

        // Probar Potencia (sin Math.Pow)
        Console.WriteLine("\nCálculo de Potencia (base^exponente):");
        Console.Write("Ingrese la base (double): ");
        double baseVal = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el exponente (int): ");
        int expVal = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Resultado de {baseVal}^{expVal} = {Potencia(baseVal, expVal)}");


        // -----------------------------------------------------------------
        // 2. PRUEBA DE SOBRECARGA DE MÉTODOS (ÁREA)
        // -----------------------------------------------------------------
        Console.WriteLine("\n=== 2. SOBRECARGA DE MÉTODOS (ÁREAS) ===");
        
        // Cuadrado
        Console.Write("Ingrese el lado del cuadrado: ");
        double ladoCuadrado = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Área del cuadrado = {Area(ladoCuadrado):F2}");

        // Rectángulo
        Console.Write("\nIngrese la base del rectángulo: ");
        double baseRect = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese la altura del rectángulo: ");
        double alturaRect = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Área del rectángulo = {Area(baseRect, alturaRect):F2}");

        // Triángulo (Fórmula de Herón)
        Console.WriteLine("\nÁrea del triángulo usando los tres lados (Fórmula de Herón):");
        Console.Write("Ingrese el lado A: ");
        double ladoA = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el lado B: ");
        double ladoB = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el lado C: ");
        double ladoC = Convert.ToDouble(Console.ReadLine());

        // Validar si forman triángulo antes de calcular Herón
        if ((ladoA + ladoB > ladoC) && (ladoA + ladoC > ladoB) && (ladoB + ladoC > ladoA))
        {
            Console.WriteLine($"Área del triángulo = {Area(ladoA, ladoB, ladoC):F2}");
        }
        else
        {
            Console.WriteLine("Error: Los tres lados ingresados no forman un triángulo válido.");
        }
    }


    // =====================================================================
    // MÉTODOS DE LA BIBLIOTECA MATEMÁTICA
    // =====================================================================

    // Método Factorial
    static long Factorial(int n)
    {
        if (n < 0) return 0;
        long resultado = 1;
        for (int i = 1; i <= n; i++)
        {
            resultado *= i;
        }
        return resultado;
    }

    // Método EsPrimo
    static bool EsPrimo(int n)
    {
        if (n <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    // Método Mcd 
    static int Mcd(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Método Potencia 
    static double Potencia(double baseNum, int exponente)
    {
        if (exponente == 0) return 1;
        
        double resultado = 1;
        int expAbs = Math.Abs(exponente);

        for (int i = 0; i < expAbs; i++)
        {
            resultado *= baseNum;
        }

        // Si el exponente es negativo, se invierte el resultado (1 / base^exp)
        if (exponente < 0)
        {
            return 1 / resultado;
        }

        return resultado;
    }


    // =====================================================================
    // MÉTODOS SOBRECARGADOS PARA CÁLCULO DE ÁREAS
    // =====================================================================

    // 1. Área del cuadrado 
    static double Area(double lado)
    {
        return lado * lado;
    }

    // 2. Área del rectángulo (dos parámetros: base y altura)
    static double Area(double b, double h)
    {
        return b * h;
    }

    // 3. Área del triángulo usando la fórmula de Herón 
    static double Area(double a, double b, double c)
    {
        // Semiperímetro (s)
        double s = (a + b + c) / 2.0;
        // Fórmula de Herón: Raíz cuadrada de s * (s - a) * (s - b) * (s - c)
        double areaHeron = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        return areaHeron;
    }
}