using System;

namespace Exercicio3
{
    public class Divisao : Operacao{

        public override double efetuarOperacao(double x, double y){
            
            if(y == 0){
                Console.WriteLine("Não é possível realizar divisão por 0. O resultado dessa conta será 0.");
                return 0;

            }else{
                return x / y;
                
            }

        }

    }
}