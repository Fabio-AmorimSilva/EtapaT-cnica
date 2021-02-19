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
            return this.lado * this.lado;

        }

        public double calculaAreaC(){
            return this.lado;

        }

        public double calculaAreaR(){
            return this.lado;

        }



        
    }
}