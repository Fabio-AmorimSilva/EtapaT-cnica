using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args){
            
            //Declaração de variáveis
            double num1; 
            double num2;

            //Instanciação de objetos
            Soma soma = new Soma();
            Subtracao subtracao = new Subtracao();
            Multiplicacao multiplicacao = new Multiplicacao();
            Divisao divisao = new Divisao();

            Console.WriteLine("Digite o número 1 e número 2 para realizar as quatro opeações fundamentais ->");
            Console.WriteLine("Soma, Subtração, Multiplicação e Divisão.");
            num1 = double.Parse(Console.ReadLine());
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Resultados das opeações.");
            Console.WriteLine("Soma: " + soma.efetuarOperacao(num1,num2));
            Console.WriteLine("Subtração: " + subtracao.efetuarOperacao(num1,num2));
            Console.WriteLine("Multiplicação: " + multiplicacao.efetuarOperacao(num1,num2));
            Console.WriteLine("Divisão: " + divisao.efetuarOperacao(num1,num2));




        }
    }
}
