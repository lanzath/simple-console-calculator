using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Sum()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"O resultado da soma é {v1 + v2}");
            Menu();
        }

        static void Subtraction()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"O resultado da subtração é {v1 - v2}");
            Menu();
        }

        static void Multiplication()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"O resultado da multiplicação é {v1 * v2}");
            Menu();
        }

        static void Division()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            if (v2 == 0)
            {
                Console.WriteLine("Digite um valor diferente de 0: ");
                v2 = float.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine($"O resultado da divisão é {v1 / v2}");
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer ?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("---------------");

            Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Sum(); break;
                case 2: Subtraction(); break;
                case 3: Multiplication(); break;
                case 4: Division(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
    }
}
