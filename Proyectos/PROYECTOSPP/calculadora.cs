using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectos.PROYECTOSPP
{
    public partial class calculadora : Form
    {
        public calculadora()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar == '.'))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }
        double valor1;
        double valor2;
        string operador;
        private void button6_Click(object sender, EventArgs e)
        {
            txtvalores.Text = txtvalores.Text + "7";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtvalores.Text = txtvalores.Text + "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtvalores.Text = txtvalores.Text + "8";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtvalores.Text = txtvalores.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtvalores.Text = txtvalores.Text + "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtvalores.Text = txtvalores.Text + "6";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtvalores.Text = txtvalores.Text + "1";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtvalores.Text = txtvalores.Text + "2";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtvalores.Text = txtvalores.Text + "3";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtvalores.Text = txtvalores.Text + "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtvalores.Text = txtvalores.Text + ".";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtvalores.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            operador = "+";
            primervalor();

        }

        private void primervalor()
        {
        valor1 = double.Parse(txtvalores.Text);
        txtvalores.Clear();
         }
        private void button19_Click(object sender, EventArgs e)
        {
            if (txtvalores.Text != "" || operador == "√")
            {

                if (!string.IsNullOrEmpty(txtvalores.Text))
                    valor2 = double.Parse(txtvalores.Text);
                if (operador != "")
                    txtvalores.Clear();

                CLASES.CLCALCULADORA ooperacion = new CLASES.CLCALCULADORA(valor1, valor2);

                switch (operador)
                {
                    case "+":
                        // code block
                        txtvalores.Text = ooperacion.suma().ToString();
                        break;
                    case "-":
                        txtvalores.Text = ooperacion.resta().ToString();
                        // code block
                        break;
                    case "/":
                        // code block
                        txtvalores.Text = ooperacion.division().ToString();
                        break;
                    case "*":
                        txtvalores.Text = ooperacion.multiplicacion().ToString();
                        // code block
                        break;
                    case "√":
                        txtvalores.Text =
                ooperacion.raiz(valor1).ToString();

                        break;
                    case "%":
                        txtvalores.Text = ooperacion.porciento().ToString();
                        break;


                    default:

                        // code block
                        break;
                }
            }
            else
            {
                MessageBox.Show("Introduzca valor");



            }














        }

        private void button3_Click(object sender, EventArgs e)
        {
            operador = "-";
            primervalor();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operador = "*";
            primervalor();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            operador = "√";
            primervalor();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            operador = "%";
            primervalor();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            operador = "/";
            primervalor();
        }
    }
}
