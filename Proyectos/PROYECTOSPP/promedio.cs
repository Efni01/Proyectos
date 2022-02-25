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
    public partial class promedio : Form
    {
        public promedio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           CLASES.clpromedio opromedio = new CLASES. clpromedio (double.Parse(calificacion1.Text), double.Parse(calificacion2.Text), double.Parse(calificacion3.Text));
                   resultado.Text = opromedio.promedio().ToString();
        }
    }
 }

