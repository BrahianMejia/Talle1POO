using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1POO
{
    class Masacorporal
    {
        private double altura;
        private double peso;

        public void setAltura(double altura)
        {

            this.altura = altura;
        }


        public double getAltura()
        {
            return this.altura;
        }

        public void setPeso(double peso)
        {

            this.peso = peso;
        }


        public double getPeso()
        {
            return this.peso;
        }


        public double calculo()
        {
            return (this.getPeso() / (this.getAltura() * this.getAltura()));

        }
    }
}
