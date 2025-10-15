
using System;

class Program
{

    static void Main()
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();

        System.Console.WriteLine("===CALCULADORA===");
        System.Console.WriteLine("O que deseja fazer?");
        System.Console.WriteLine("1- Soma");
        System.Console.WriteLine("2- Subtração");
        System.Console.WriteLine("3- Divisão");
        System.Console.WriteLine("4- Multiplicação");
        System.Console.WriteLine("5- Sair");

        System.Console.WriteLine("------------------");
        System.Console.WriteLine("Escolha uma opção:");
        var esc = Convert.ToDouble(Console.ReadLine());

        switch (esc)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break;
            case 5: System.Environment.Exit(0); break;
            default: Menu(); break;

        }
    }

    static void Soma()
    {
        Console.Clear();

        System.Console.WriteLine("Primeiro valor: ");
        var V1 = Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine("Segundo valor: ");
        var V2 = Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine("");

        double soma = V1 + V2;
        System.Console.WriteLine($"O resultado da soma é: {soma}");

        Console.ReadKey();
        Menu();

    }

    static void Subtracao()
    {
        Console.Clear();
        System.Console.WriteLine("Primeiro valor: ");
        var V1 = Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine("Segundo valor: ");
        var V2 = Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine("");
        double sub = V1 - V2;
        System.Console.WriteLine($"O resultado da subtração é: {sub}");

        Console.ReadKey();
        Menu();
    }

    static void Divisao()
    {
        Console.Clear();
        System.Console.WriteLine("Primeiro valor: ");
        var V1 = Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine("Segundo valor: ");
        var V2 = Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine("");

        double div = V1 / V2;
        System.Console.WriteLine($"O resultado da divisão é: {div}");

        Console.ReadKey();
        Menu();
    }

    static void Multiplicacao()
    {
        Console.Clear();
        System.Console.WriteLine("Primeiro valor: ");
        var V1 = Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine("Segundo valor: ");
        var V2 = Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine("");

        double mult = V1 * V2;
        System.Console.WriteLine($"O resultado da multiplicação é: {mult}");

        Console.ReadKey();
        Menu();
    }
}