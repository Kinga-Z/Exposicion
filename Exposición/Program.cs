using System;

namespace Exposición
{
    class Program
    {
        //En la clase Program se utilizan los dos servicios, con la posibilidad de reutilizar
        //el resultado para otros cálculos o crear nuevos métodos para Imprimir en distintos
        //formatos
        static void Main(string[] args)
        {
            Calculos calculo = new Calculos();
            Imprimir imprimir = new Imprimir();

            Circulo circulo = new Circulo(5);
            Cuadrado cuadrado = new Cuadrado(6);

            double result = calculo.sumaAreas(cuadrado, circulo);
            imprimir.printResult(result);
        }
    }
}
