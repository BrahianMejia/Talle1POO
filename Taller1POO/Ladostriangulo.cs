using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1POO
{
    class Ladostriangulo
    {
        public double ladoa;
        public double ladob;
        public double ladoc;
        public double resultado;

        public void setLadoa(double ladoa)
        {
            this.ladoa = ladoa;
        }

        public double getLadoa()
        {
            return this.ladoa;
        }

        public void setLadob(double ladob)
        {
            this.ladob = ladob;
        }

        public double getLadob()
        {
            return this.ladob;
        }

        public void setLadoc(double ladoc)
        {
            this.ladoc = ladoc;
        }

        public double getLadoc()
        {
            return this.ladoa;
        }

        public double calcular()
        {
            ladoc = ladoc * ladoc;
            resultado = (ladoa * ladob) / 2;
            return (Math.Pow(getLadoa(), 2) + Math.Pow(getLadob(), 2));
        }
    }

}

