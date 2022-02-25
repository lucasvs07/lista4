using System;

namespace questao4Lista4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Desenvolver um algoritmo que leia 5 valores inteiros e 
              calcule e escreva a média aritmética dos valores lidos, 
              a quantidade de valores positivos e a quantidade de valores negativos.
            */


            double soma = 0, contPositivos = 0, contNegativos = 0;
            double[] conjuntoNumeros = new double[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite um número inteiro");
                double num = Convert.ToDouble(Console.ReadLine());
                conjuntoNumeros[i] = num;
                soma = soma + conjuntoNumeros[i];
                if (conjuntoNumeros[i] < 0)
                    contNegativos++;
                else if (conjuntoNumeros[i] >= 0)
                    contPositivos++;

            }

            double media = soma / 5;


            Console.Write("\n\nA média aritmética é: " + media + "\n");
            Console.WriteLine("A quantidade de valores positivos é: " + contPositivos);
            Console.WriteLine("A quantidade de valores negativos é: " + contNegativos);

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();

        }
    }
}
