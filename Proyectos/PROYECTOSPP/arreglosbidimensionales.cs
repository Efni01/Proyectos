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
    public partial class arreglosbidimensionales : Form
    {
        public arreglosbidimensionales()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        int r; // renglon
        int C = 0; // columna
        int contador;
        private void button1_Click(object sender, EventArgs e)
        {
            contador++; // Incrementa el contador
            r++; // Incrementa el renglón 
            if (contador > (tamaño * 2)) MessageBox.Show("El arreglo está lleno");
            else
            {

                if (r > tamaño)
                {
                    r = 1;
                    C = 1;  // indica el número de la columna del arreglo
                }
                if (r <= tamaño)
                    arreglo[r - 1, C] = textvalores.Text;

            }

            // contador++; // contador = contador + 1;
            // int tamaño = 0;
            // tamaño = int.Parse(txttamaño.Text);
            // string[,] arreglo = new string[tamaño, 2];

            ////if (contador <= tamaño)
            // //   arreglo[contador - 1, 0] = txtvalor.Text;
        }
        int tamaño = 0;
        string[,] arreglo;

        private void txttamaño_TextChanged(object sender, EventArgs e)
        {

                tamaño = int.Parse(txttamaño.Text);
                arreglo = new string[tamaño, 2];
         }

        private void button2_Click(object sender, EventArgs e)
        {

            C = 0; //  Poner en 0 la columna
            int r = 0; // Poner en 0 el renglon
            DataGridViewRow row; // creamos el objeto renglón
            for (int rr = 0; rr < tamaño; rr++)
            //  while (r<tamaño) // Ciclo 
            {
                row = new DataGridViewRow();
                row.CreateCells(this.dataGridView1);
                for (int CC = 0; CC < 2; CC++)
                //  while (C < 2)
                {
                    row.Cells[CC].Value = arreglo[rr, CC];
                    C++;
                }
                this.dataGridView1.Rows.Add(row);
                C = 0;
                r++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            contador = 0;
            Array.Clear(arreglo, 0, arreglo.Length);
            dataGridView1.Rows.Clear();
        }
    }
}
