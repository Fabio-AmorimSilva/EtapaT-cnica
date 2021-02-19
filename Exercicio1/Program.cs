using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int inicio;
            int fim;

            Console.WriteLine("Digite o multiplicando: ");
            numero = int.Parse(Console.ReadLine());

            if(numero < 0 || numero > 3000){
                Console.WriteLine("O multiplicando não pode ser menor que zero ou maior que 3000.");
                Console.WriteLine("Tente novamente.");
                return;

            }

            Console.WriteLine("Digite o início do intervaldo de multiplicação: ");
            inicio = int.Parse(Console.ReadLine());

            if(inicio < 0 || inicio > 3000){
                Console.WriteLine("O inicio não pode ser menor que zero ou maior que 3000.");
                Console.WriteLine("Tente novamente.");
                return;
              

            }

            
            Console.WriteLine("Digite o fim do intervaldo de multiplicação: ");
            fim = int.Parse(Console.ReadLine());

            if(fim < 0 || fim > 3000){
                Console.WriteLine("O fim não pode ser menor que zero ou maior que 3000.");
                Console.WriteLine("Tente novamente.");
                return;

            }

            if(inicio > fim){
                Console.WriteLine("O inicio do intervalo não pode ser maior que o final do mesmo.");
                Console.WriteLine("Tente novamente");
                return;

            }else if(fim - inicio >= 10){
                Console.WriteLine("O intervalor de multiplicação não pode ser maior que ou igual a 10.");
                Console.WriteLine("Tente novamente");
                return;
            }


            for(int i = inicio; i <= fim; i++){
                Console.WriteLine(" " + numero + " x " + i + " = " + numero * i);


            }

            Console.WriteLine("Fim do intervalo");


        }
    }
}
