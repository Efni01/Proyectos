using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectos // tiene que ser el espacio de nombre de este proyecto

{
    internal class CLCALCULA
    {
        // CON dos diagonales pones lineas de codigo para comentar algo
        // primero creas las variables estas van a ser generalmente las cajas de texto que tu pusiste en el diseño pero solo en las que capturas los valores de los números

        // te explico
        // private se le llama asi porque solo se puede usar en la clase CLCALCULA
        // DOUBLE es el tipo de dato es como si dijeras tipo de color de ojos cafe, negros, azules, verdes
        // esos son los tipos de datos de este lenguaje el DOUBLE acepta numeros enteros y decimales
        // estos son los CAMPOS
        private double numero1;
        private double numero2;
        private double numero3;
        // ESTE METODO ES EL CONSTRUCTOR
        // GENERALMENTE TODAS LAS CLASES TIENEN
        //Y sirve para recibir los valores que capturaste en las cajas de texto en el diseño
        // lo que acabas de hacer

        public CLCALCULA(double numero1, double numero2, double numero3) // eso que está entre parentesis se le llaman parámetros y estos no son mas que varibles del mismo tipo de los campos
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
            this.numero3 = numero3;
        }
        // ahora los métodos
        // los métodos generalmente serán públicos
        // o sea los puedes ver desde otra parte del proyecto fuera de esta clase
        // la manera en que se crean es de esta manera public(modificador de acceso) double (el tipo de valor que va a retornar) y suma( el nombre que va a tener la funcion.

        public double suma()
        {
            return (numero1 + numero2 + numero3);
            // el return es obligatorio cuando el método es una funcion
            // lo que esta entre parentesis es la operación aritmética
        }
        // intenta hacer el metodo de la resta 

       
        public double resta()
        {
            return (numero1 - numero2 - numero3);
        }

        public double Division()
        {
            return (numero1 / numero2 / numero3);
        }

        public double multiplicacion()
        {
            return (numero1 * numero2 * numero3);
        }

    }
}
