using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1POO
{
    class Volumencaja
    {
        private double Numeroalto;
        private double Numerolargo;
        private double Numeroancho;


        public void setNumeroalto(double alto)
        {
            this.Numeroalto = alto;
        }

        public double getNumeroalto()
        {
            return this.Numeroalto;
        }

        public void setNumerolargo(double largo)
        {
            this.Numerolargo = largo;
        }

        public double getNumerolargo()
        {
            return this.Numerolargo;
        }

        public void setNumeroancho(double ancho)
        {
            this.Numeroancho = ancho;
        }

        public double getNumeroancho()
        {
            return this.Numeroancho;
        }


        public double calcular()
        {
            return (this.getNumerolargo() * this.getNumeroancho() * this.getNumeroalto());
        }
    }
}
