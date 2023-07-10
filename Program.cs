using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Multiplicacao();
        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine()); //Readline sempre retorna uma string. Caso queira um float, use Parse.

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"O resultado da soma é {v1 + v2}."); // Ao usar o cifrão($), denomina-se interpolação de strings.
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine()); //Readline sempre retorna uma string. Caso queira um float, use Parse.

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"O resultado da subtração é {v1 - v2}."); // Ao usar o cifrão($), denomina-se interpolação de strings.
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"O resultado da divisão é {v1 / v2}.");
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro lavor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"O resultado da multiplicação é: {v1 * v2}");
        }
    }
}