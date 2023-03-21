using System;

class Program
{
    static void Main()
    {
        double num1, num2, result;
        char op;

        Console.Write("Masukkan bilangan pertama: ");
        num1 = double.Parse(Console.ReadLine());

        Console.Write("Masukkan bilangan kedua: ");
        num2 = double.Parse(Console.ReadLine());

        Console.Write("Masukkan operator (+, -, *, /): ");
        op = char.Parse(Console.ReadLine());

        switch (op)
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine($"{num1} + {num2} = {result}");
                break;

            case '-':
                result = num1 - num2;
                Console.WriteLine($"{num1} - {num2} = {result}");
                break;

            case '*':
                result = num1 * num2;
                Console.WriteLine($"{num1} * {num2} = {result}");
                break;

            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine("Error: division by zero");
                }
                else
                {
                    result = num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = {result}");
                }
                break;

            default:
                Console.WriteLine("Error: invalid operator");
                break;
        }

        Console.ReadKey();
    }
}