using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CalculadoraLogicLayer
{
    public class Calcular
    {
        public double sumar(double digito1, double digito2)
        {
            return digito1 + digito2;
        }

        public double restar(double digito1, double digito2)
        {
            return digito1 - digito2;
        }

        public double dividir(double digito1, double digito2)
        {
            return digito1 / digito2;
        }

        public double multiplicar(double digito1, double digito2)
        {
            return digito1 * digito2;
        }

    }
}
