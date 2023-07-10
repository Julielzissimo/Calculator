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
            float v1;

            if (!float.TryParse(Console.ReadLine(), out v1))
            {
                Console.WriteLine("O primeiro valor inserido não é um número válido.");
                Console.ReadKey();
                Menu();
                return;
            } // Validação de dado através de negação por TryParse.

            Console.WriteLine("Segundo valor:");
            float v2;

            if (!float.TryParse(Console.ReadLine(), out v2))
            {
                Console.WriteLine("O segundo valor inserido não é um número válido.");
                Console.ReadKey();
                Menu();
                return;
            }

            Console.WriteLine("");
            Console.WriteLine($"O resultado da soma é {v1 + v2}.");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.WriteLine("Primeiro valor:");
            float v1;

            if (!float.TryParse(Console.ReadLine(), out v1))
            {
                Console.WriteLine("O primeiro valor inserido não é um número válido.");
                Console.ReadKey();
                Menu();
                return;
            }

            Console.WriteLine("Segundo valor:");
            float v2;

            if (!float.TryParse(Console.ReadLine(), out v2))
            {
                Console.WriteLine("O segundo valor inserido não é um número válido.");
                Console.ReadKey();
                Menu();
                return;
            }

            Console.WriteLine("");
            Console.WriteLine($"O resultado da subtração é {v1 - v2}.");
            Console.ReadKey();
            Menu();
        }


        static void Divisao()
        {
            Console.WriteLine("Primeiro valor:");
            float v1;

            if (!float.TryParse(Console.ReadLine(), out v1))
            {
                Console.WriteLine("O primeiro valor inserido não é um número válido.");
                Console.ReadKey();
                Menu();
                return;
            }

            Console.WriteLine("Segundo valor:");
            float v2;

            if (!float.TryParse(Console.ReadLine(), out v2) || v2 == 0)
            {
                Console.WriteLine("O segundo valor inserido não é um número válido ou é igual a zero.");
                Console.ReadKey();
                Menu();
                return;
            }

            Console.WriteLine("");
            Console.WriteLine($"O resultado da divisão é {v1 / v2}.");
            Console.ReadKey();
            Menu();
        }


        static void Multiplicacao()
        {
            Console.WriteLine("Primeiro valor:");
            float v1;

            if (!float.TryParse(Console.ReadLine(), out v1))
            {
                Console.WriteLine("O primeiro valor inserido não é um número válido.");
                Console.ReadKey();
                Menu();
                return;
            }

            Console.WriteLine("Segundo valor:");
            float v2;

            if (!float.TryParse(Console.ReadLine(), out v2))
            {
                Console.WriteLine("O segundo valor inserido não é um número válido.");
                Console.ReadKey();
                Menu();
                return;
            }

            Console.WriteLine("");
            Console.WriteLine($"O resultado da multiplicação é {v1 * v2}.");
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