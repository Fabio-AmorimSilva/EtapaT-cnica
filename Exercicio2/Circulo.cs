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
            return 3.14 * (this.raio * this.raio);

        }

        public double calculaAreaQ(){
            return this.raio;

        }

        public double calculaAreaR(){
            return this.raio;

        }



        
    }
}