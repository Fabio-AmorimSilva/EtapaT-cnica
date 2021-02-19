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
            Console.WriteLine("O números serão calculados na sequência. (num1 + num2), (num1 - num2), (num1 * num2) e (num1 / num2)");
            num1 = double.Parse(Console.ReadLine());
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Resultados das opeações.");
            Console.WriteLine("Soma: " + String.Format("{0:00.00}", soma.efetuarOperacao(num1,num2)));
            Console.WriteLine("Subtração: " + String.Format("{0:00.00}", subtracao.efetuarOperacao(num1,num2)));
            Console.WriteLine("Multiplicação: " + String.Format("{0:00.00}", multiplicacao.efetuarOperacao(num1,num2)));
            Console.WriteLine("Divisão: " + String.Format("{0:00.00}", divisao.efetuarOperacao(num1,num2)));




        }
    }
}
