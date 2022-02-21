using System;

namespace questao1Lista4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Desenhe um retângulo com asteriscos, 
               considere que o primeiro input é a largura do retângulo, 
               e o segundo input é a altura.
            */

            Console.WriteLine("Qual a altura do retângulo?");
            int altura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual a largura do retangulo?");
            int largura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= altura; i++)
            {

                for (int j = 1; j <= largura; j++)
                {

                    Console.Write("*");
                        
                }

                Console.Write("\n");

            }

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}
