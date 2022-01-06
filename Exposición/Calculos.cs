using System;
using System.Collections.Generic;
using System.Text;

namespace Exposición
{
    class Calculos
        //Ahora la clase Calculos solo queda responsable de realizar los calculos 
    {
        public double sumaAreas(Cuadrado cuadrado,Circulo circulo)    
        {
            return cuadrado.getArea() + circulo.getArea();
        }
        public double restaAreas(Cuadrado cuadrado,Circulo circulo)
        {
            return cuadrado.getArea() - circulo.getArea();
        }
    }
} 
