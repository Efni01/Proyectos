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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void operacionesAritméticasDeTresValoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calculooperaciones calculooperaciones = new calculooperaciones();
            calculooperaciones.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close(); // sirve para cerrar el programa eso es lo que hace el close()
        }

        private void promedioDeTresCalificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PROYECTOSPP.promedio elnombreqiequieras = new PROYECTOSPP.promedio ();
            elnombreqiequieras.Show();
        }

        private void promedioDeCincoCalificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PROYECTOSPP.Promediodecincocalificaciones promedios = new PROYECTOSPP.Promediodecincocalificaciones();
            promedios.Show();
        }

        private void arreglosBidimencionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PROYECTOSPP.arreglosbidimensionales Arreglo = new PROYECTOSPP.arreglosbidimensionales();
            Arreglo.Show();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PROYECTOSPP.calculadora calculadora = new PROYECTOSPP.calculadora();
            calculadora.Show();
        }

        private void pilaListaDeMaterialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PROYECTOSPP.Pila p = new PROYECTOSPP.Pila();
            p.Show();
        }
    }
}
