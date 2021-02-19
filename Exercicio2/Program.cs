using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadrado = new Quadrado(8);
            Circulo circulo = new Circulo(2);
            Retangulo retangulo = new Retangulo(2,8);

            Console.WriteLine("Apresentando os valores das áreas das figuras ->");
            Console.WriteLine("Quadrado ->");
            Console.WriteLine("Área: " + quadrado.calculaAreaQ());
            Console.WriteLine();

            Console.WriteLine("Retângulo ->");
            Console.WriteLine("Área: " + retangulo.calculaAreaR());
            Console.WriteLine();

            Console.WriteLine("Círculo ->");
            Console.WriteLine("Área: " + circulo.calculaAreaC());

        }
    }
}
