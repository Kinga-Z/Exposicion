using System;
using System.Collections.Generic;
using System.Text;

namespace Exposición
{
    class Circulo
    {
        int radio;
        public Circulo(int radio)
        {
            this.radio = radio;
        }
        public int getRadio()
        {
            return this.radio;
        }
        public void setRadio(int radio)
        {
            this.radio = radio;
        }
        public double getArea()
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}
