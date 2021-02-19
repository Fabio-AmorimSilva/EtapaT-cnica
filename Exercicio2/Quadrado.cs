namespace Exercicio2
{
    public class Quadrado : AreaCalculavel
    {

        private double lado{get; set;}

        public Quadrado(double lado){
            this.lado = lado;

        }


        public double Lado{
            get => this.lado;
            set => this.lado = value;

        }

        public double calculaAreaQ(){
            return System.Math.Pow(this.lado,2);

        }

        public double calculaAreaC(){
            return 0;

        }

        public double calculaAreaR(){
            return 0;

        }



        
    }
}