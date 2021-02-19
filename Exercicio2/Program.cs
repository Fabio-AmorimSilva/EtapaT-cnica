using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadrado = new Quadrado(8);
            Circulo circulo = new Circulo(5);
            Retangulo retangulo = new Retangulo(2,8);

            Console.WriteLine("Apresentando os valores das áreas das figuras ->");
            Console.WriteLine("Quadrado ->");
            Console.WriteLine("Área: " + String.Format("{0:00.00}",quadrado.calculaAreaQ()));
            Console.WriteLine();

            Console.WriteLine("Retângulo ->");
            Console.WriteLine("Área: " + String.Format("{0:00.00}", retangulo.calculaAreaR()));
            Console.WriteLine();

            Console.WriteLine("Círculo ->");
            Console.WriteLine("Área: " + String.Format("{0:00.00}", circulo.calculaAreaC()));

        }
    }
}
