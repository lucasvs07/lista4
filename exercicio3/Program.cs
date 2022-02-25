using System;

namespace questao3Lista4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Escreva um programa que contenha uma variável: horaAtual; 
             * Essa variável deverá conter a hora do dia e três mensagens deverão ser 
                impressas na tela de acordo com a hora: 
                “Bom dia”, “Boa tarde” ou “Boa noite”.
            */
            DateTime agora = DateTime.Now;

            int horaAtual = agora.Hour;

            Console.WriteLine(horaAtual + " horas.");

            if (horaAtual <= 12)
                Console.WriteLine("Bom dia!");

            else if (horaAtual >=13 && horaAtual <=18)
                Console.WriteLine("Boa tarde!");

            else if (horaAtual >= 19 && horaAtual <=23)
                Console.WriteLine("Boa noite!");

            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();

        }
    }
}
