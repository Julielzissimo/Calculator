using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Substração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("");
            Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Sair(); break;
                default: Menu(); break;
            }
        }

        static void Soma()
        {
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine()); //Readline sempre retorna uma string. Caso queira um float, use Parse.

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"O resultado da soma é {v1 + v2}."); // Ao usar o cifrão($), denomina-se interpolação de strings.

            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine()); //Readline sempre retorna uma string. Caso queira um float, use Parse.

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"O resultado da subtração é {v1 - v2}."); // Ao usar o cifrão($), denomina-se interpolação de strings.

            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"O resultado da divisão é {v1 / v2}.");

            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Primeiro lavor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"O resultado da multiplicação é: {v1 * v2}");

            Console.ReadKey();
            Menu();
        }

        static void Sair()
        {
            Console.WriteLine("");

            Console.WriteLine("Você escolheu sair. Obrigado por usar este sistema!");
            System.Environment.Exit(0); //Zero significa que saiu com sucesso.
        }
    }
}