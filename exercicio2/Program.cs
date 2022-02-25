using System;

namespace questao2Lista4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Desenhe um retângulo com asteriscos, onde as forem linhas pares,
               escreva "A" e as linhas ímpares escreva "B"*/

            Console.WriteLine("Qual a altura do retângulo?");
            int altura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual a largura do retângulo?");
            int largura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for(int i = 1; i <= altura; i++)
            {
                for (int j =1; j <= largura; j++)
                {
                    if (i % 2 == 0)
                        Console.Write("A");
                    else
                        Console.Write("B");
                }
                Console.Write("\n");
            }

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}
