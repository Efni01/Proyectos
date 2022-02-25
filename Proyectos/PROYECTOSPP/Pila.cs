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
    public partial class Pila : Form
    {
        public Pila()
        {
            InitializeComponent();
        }
        Stack<string> pila = new Stack<string>();
        int c = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            pila.Push(txtproducto.Text);
            c++;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pila.Count != 0)
            {


                DataGridViewRow row; 
                for (int p = 0; p < c; p++)
                {
                    row = new DataGridViewRow();
                    row.CreateCells(this.dataGridView1);
                    row.Cells[0].Value = pila.Pop();
                    this.dataGridView1.Rows.Add(row);
                }
            }
            else
                MessageBox.Show("Aún no hay materiales ingresados para comprar");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por su compra!");
            dataGridView1.Rows.Clear();
        }
    }
    
}
