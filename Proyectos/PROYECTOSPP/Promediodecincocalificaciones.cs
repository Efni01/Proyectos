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
    public partial class Promediodecincocalificaciones : Form
    {
        public Promediodecincocalificaciones()
        {
            InitializeComponent();
        }

        private void calificacion1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CLASES.clpromedios opromedios = new CLASES.clpromedios(double.Parse(calificacion1.Text), double.Parse(calificacion2.Text), double.Parse(calificacion3.Text), double.Parse(calificacion4.Text), double.Parse(calificacion5.Text));
            resultado.Text = opromedios.promedios().ToString();
        }
    }
}
