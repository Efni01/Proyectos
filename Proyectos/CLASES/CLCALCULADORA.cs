using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectos.CLASES
{
    internal class CLCALCULADORA
    {
        private double valor1;
        private double valor2;

        public CLCALCULADORA(double valor1, double valor2)
        {
            this.valor1 = valor1;
            this.valor2 = valor2;
        }

        public double suma()
        {
            return (valor1 + valor2);
        }

        public double resta()
        {
            return (valor1 - valor2);
        }

        public double multiplicacion()
        {
            return (valor1 * valor2);
        }

        public double division()
        {
            return (valor1 / valor2);
        }

        public double porciento()
        {
            return (valor2 *(valor1 / 100));
        }
        public double raiz(double valor3)
        {
            return (Math.Sqrt(valor3));
        }
    }
}
