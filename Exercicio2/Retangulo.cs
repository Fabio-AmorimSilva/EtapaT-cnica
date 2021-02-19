namespace Exercicio2
{
    public class Retangulo : AreaCalculavel
    {

        private double lado{get; set;}

        private double altura{get; set;}

        public Retangulo(double lado, double altura){
            this.lado = lado;
            this.altura = altura;

        }

        public double calculaAreaR(){
            return this.lado * this.altura;

        }

        public double calculaAreaQ(){
            return this.lado;

        }

        public double calculaAreaC(){
            return this.lado;

        }
        
    }
}