using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string answer;
        var options = new List<string> { "s", "n" };

        do
        {
            Console.WriteLine("Ingrese 3 números diferentes");

            var a = ConsoleExtension.GetInt("Ingrese primer número: ");
            var b = ConsoleExtension.GetInt("Ingrese segundo número: ");
            var c = ConsoleExtension.GetInt("Ingrese tercer número: ");

            if (a > b && a > c)
            {
                Console.WriteLine($"El número mayor es: {a}");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine($"El número mayor es: {b}");
            }
            else
            {
                Console.WriteLine($"El número mayor es: {c}");
            }

            // Preguntar si desea continuar
            answer = ConsoleExtension.GetValidOptions(
                "¿Deseas continuar? [s/n]: ", options
            );

        } while (answer == "s");
    }
}
