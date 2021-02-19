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

        public double Lado{
            get => this.lado;
            set => this.lado = value;

        }

        public double Altura{
            get => this.altura;
            set => this.altura = value;

        }


        public double calculaAreaR(){
            return this.lado * this.altura;

        }

        public double calculaAreaQ(){
            return 0;

        }

        public double calculaAreaC(){
            return 0;

        }
        
    }
}