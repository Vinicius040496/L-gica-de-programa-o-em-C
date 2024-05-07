using System;

namespace Logica_de_programação_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Escreva um algoritmo para ler um valor, e escreva na tela o seu antecessor.

            Console.WriteLine(" Escreva um numero: ");
            int valor;
            valor = int.Parse(Console.ReadLine());
            int antecessor = valor - 1;
            Console.WriteLine(" O valor digitado é " + valor + (" Seu antecessor é ") + antecessor);
            Console.ReadLine();

        }
    }
}
