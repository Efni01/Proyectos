using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectos.CLASES
{
    internal class clpromedio
    {
        // primero los campos
        // son las tres calificaciones
        private double calificacion1;
        private double calificacion2;
        private double calificacion3;

        public clpromedio(double calificacion1, double calificacion2, double calificacion3)
        {
            this.calificacion1 = calificacion1;
            this.calificacion2 = calificacion2;
            this.calificacion3 = calificacion3;
        }
        public double promedio()
        {
            return ((calificacion1 + calificacion2 + calificacion3)/3);
        }
    }
    
}
