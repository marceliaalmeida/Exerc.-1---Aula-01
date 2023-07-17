using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_Aula_01
{
    internal class Program
    {
        static void Main(string[] args)
        { /* Exercício 1: Escreva um programa que faça a leitura do nome do usuário e imprima uma saudação no
console usando o nome digitado.*/
            String nome = "";
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("O nome digitado foi: ");
            Console.WriteLine(nome);


            Console.ReadLine(); 

        }
    }
}
