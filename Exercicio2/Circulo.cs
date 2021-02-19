namespace Exercicio2
{
    public class Circulo : AreaCalculavel
    {

        private double raio{get; set;}

        public Circulo(double raio){
            this.raio = raio;

        }

        public double Raio{
            get => this.raio;
            set => this.raio = value;

        }

        public double calculaAreaC(){
            return System.Math.PI * System.Math.Pow(this.raio,2);

        }

        public double calculaAreaQ(){
            return 0;

        }

        public double calculaAreaR(){
            return 0;

        }



        
    }
}