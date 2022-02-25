using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectos
{
    public partial class calculooperaciones : Form
    {
        public calculooperaciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // primero creamos los objetos o el objeto para que pueda sumar
            // hay que tener cuidado cuando ponemos los nombres de las varibles porque este lenguaje reconoce como diferente una palabra en mayúscula o minúscula
            // en inglés le llaman case Sensitive- sensible a mayúsculas minúsculas
            // bueno lo que se hace en esa linea es lo siguiente
            // se crea un objeto (osuma) de la clase CLCALCULA y se le asigna ( = ) a ese objeto(osuma)
            // los valores que captures en las dos primeras cajas de texto y se le pasan al constructor de la clase /CLCALCULA
            CLCALCULA osuma = new CLCALCULA(double.Parse(numero1.Text), double.Parse(numero2.Text), double.Parse(numero3.Text));
            // Ya que haces esto ahora si puedes usar los métodos de la clase o sea el que hace en este caso es una suma
            resultado.Text= osuma.suma().ToString(); // 
            // con eso ya puedes calcular la suma
            // pero requieres mostrar ese resultado
            // y para eso tienes la caja de resultado OJO CON ESTO
            // Cuando las arrastraste al formulario
            // las dejaste revueltas
            // y la caja de texto1 quedó como si fuera el resultado
            // vamos a ponerles nombre mejor
            // ahora si ya tenemos orden en los valores que recibirá cada caja de texto



        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

           
        }

        private void button4_Click(object sender, EventArgs e)
        {

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // los valores que captures en las dos primeras cajas de texto y se le pasan al constructor de la clase /CLCALCULA
            CLCALCULA osuma = new CLCALCULA(double.Parse(numero1.Text), double.Parse(numero2.Text), double.Parse(numero3.Text));
            // Ya que haces esto ahora si puedes usar los métodos de la clase o sea el que hace en este caso es una suma
            resultado.Text = osuma.suma().ToString(); // 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CLCALCULA oresta = new CLCALCULA(double.Parse(numero1.Text), double.Parse(numero2.Text), double.Parse(numero3.Text));

            resultado.Text = oresta.resta().ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CLCALCULA omultiplicacion = new CLCALCULA(double.Parse(numero1.Text), double.Parse(numero2.Text), double.Parse(numero3.Text));

            resultado.Text = omultiplicacion.multiplicacion().ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CLCALCULA odivision = new CLCALCULA(double.Parse(numero1.Text), double.Parse(numero2.Text), double.Parse(numero3.Text));

            resultado.Text = odivision.Division().ToString();
        }
    }
}
