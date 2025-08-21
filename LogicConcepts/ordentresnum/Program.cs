using System;

while (true) 
{
    Console.WriteLine("Ingrese 3 números diferentes...");

    Console.Write("Ingrese primer número: ");
    var a = int.Parse(Console.ReadLine());

    Console.Write("Ingrese segundo número: ");
    var b = int.Parse(Console.ReadLine());

    Console.Write("Ingrese tercer número: ");
    var c = int.Parse(Console.ReadLine());

    if (a == b || a == c || b == c)
    {
        Console.WriteLine("❌ Los números deben ser diferentes, vuelva a intentarlo...");
        continue;
    }

    if (a > b && a > c)
    {
        if (b > c)
            Console.WriteLine($"El mayor es {a}, el medio es {b}, el menor es {c}");
        else
            Console.WriteLine($"El mayor es {a}, el medio es {c}, el menor es {b}");
    }
    else if (b > a && b > c)
    {
        if (a > c)
            Console.WriteLine($"El mayor es {b}, el medio es {a}, el menor es {c}");
        else
            Console.WriteLine($"El mayor es {b}, el medio es {c}, el menor es {a}");
    }
    else
    {
        if (a > b)
            Console.WriteLine($"El mayor es {c}, el medio es {a}, el menor es {b}");
        else
            Console.WriteLine($"El mayor es {c}, el medio es {b}, el menor es {a}");
    }
}

