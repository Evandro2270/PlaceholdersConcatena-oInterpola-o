using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;
                char genero = 'F';
                int idade = 32;
                double saldo = 10.35784;
                string nome = "Maria";

                Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo); // placeholders
                Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais"); //interpolação 
                Console.WriteLine(nome + " tem " + idade + "anos e tem saldo igual a " + saldo.ToString("F2" ,CI) + "reais"); //concatenação 


            }
        }
    }
}