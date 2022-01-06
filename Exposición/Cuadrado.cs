using System;
using System.Collections.Generic;
using System.Text;

namespace Exposición
{
    class Cuadrado
    {
        int medida;
        public Cuadrado(int medida)
        {
            this.medida = medida;
        }
        public int getmedida()
        {
            return this.medida;
        }
        public void setmedida(int medida)
        {
            this.medida = medida;
        }
        public double getArea()
        {
            return Math.Pow(medida, 2);
        }
    }
}
