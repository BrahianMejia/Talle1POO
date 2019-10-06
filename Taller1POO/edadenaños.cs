using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1POO
{
    class edadenaños
    {
        private double edad;

        public void setEdad(double alto)
        {
            this.edad = alto;
        }

        public double getEdad()
        {
            return this.edad;
        }

        public double calcular()
        {
            return (this.getEdad() * 31536000);
        }
    }
}
