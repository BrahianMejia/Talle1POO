using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1POO
{
    class Cuadradaraiz
    {
        private Double numero1;
        public void setNumero1(double numero)
        {
            this.numero1 = numero;
        }

        public double getNumero1()
        {
            return this.numero1;
        }




        public double calcular()
        {
            return (Math.Sqrt(this.getNumero1()));
        }
    }
}
