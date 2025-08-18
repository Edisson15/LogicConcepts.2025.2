using System;

class Program
{
    static void Main()
    {
        // Pedir números al usuario
        Console.Write("Ingrese primer número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese tercer número: ");
        int num3 = int.Parse(Console.ReadLine());

        // Determinar el mayor
        int mayor;

        if (num1 >= num2 && num1 >= num3)
        {
            mayor = num1;
        }
        else if (num2 >= num1 && num2 >= num3)
        {
            mayor = num2;
        }
        else
        {
            mayor = num3;
        }

        // Mostrar resultado
        Console.WriteLine($"El número mayor es: {mayor}");
    }
}