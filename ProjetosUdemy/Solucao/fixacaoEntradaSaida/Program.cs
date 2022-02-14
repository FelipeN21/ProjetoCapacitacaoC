
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _fixacaoEntradaSaida
{
    class Program
    {

        static void Main(string[] args)
        {

            string idade, nome;

            Console.WriteLine("Digite sua idade : ");
            idade = Console.ReadLine();



            Console.WriteLine("Digite seu nome : ");
            nome = Console.ReadLine();


            int novoA = int.Parse(idade);
            int anoNascimento = 2022 - novoA;


            Console.WriteLine("Seu Nome : " + nome + "\n");
            Console.WriteLine("Seu ano de Nascimento : " + anoNascimento + "\n");



            Console.ReadKey();
        }
    }

}