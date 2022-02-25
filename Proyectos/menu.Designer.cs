namespace Proyectos
{
    partial class menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesAritméticasDeTresValoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promedioDeTresCalificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promedioDeCincoCalificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arreglosBidimencionalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilaListaDeMaterialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programasToolStripMenuItem
            // 
            this.programasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacionesAritméticasDeTresValoresToolStripMenuItem,
            this.promedioDeTresCalificacionesToolStripMenuItem,
            this.promedioDeCincoCalificacionesToolStripMenuItem,
            this.arreglosBidimencionalesToolStripMenuItem,
            this.calculadoraToolStripMenuItem,
            this.pilaListaDeMaterialesToolStripMenuItem});
            this.programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            this.programasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.programasToolStripMenuItem.Text = "Programas";
            // 
            // operacionesAritméticasDeTresValoresToolStripMenuItem
            // 
            this.operacionesAritméticasDeTresValoresToolStripMenuItem.Name = "operacionesAritméticasDeTresValoresToolStripMenuItem";
            this.operacionesAritméticasDeTresValoresToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.operacionesAritméticasDeTresValoresToolStripMenuItem.Text = "Operaciones aritméticas de tres valores";
            this.operacionesAritméticasDeTresValoresToolStripMenuItem.Click += new System.EventHandler(this.operacionesAritméticasDeTresValoresToolStripMenuItem_Click);
            // 
            // promedioDeTresCalificacionesToolStripMenuItem
            // 
            this.promedioDeTresCalificacionesToolStripMenuItem.Name = "promedioDeTresCalificacionesToolStripMenuItem";
            this.promedioDeTresCalificacionesToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.promedioDeTresCalificacionesToolStripMenuItem.Text = "Promedio de tres Calificaciones";
            this.promedioDeTresCalificacionesToolStripMenuItem.Click += new System.EventHandler(this.promedioDeTresCalificacionesToolStripMenuItem_Click);
            // 
            // promedioDeCincoCalificacionesToolStripMenuItem
            // 
            this.promedioDeCincoCalificacionesToolStripMenuItem.Name = "promedioDeCincoCalificacionesToolStripMenuItem";
            this.promedioDeCincoCalificacionesToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.promedioDeCincoCalificacionesToolStripMenuItem.Text = "Promedio de cinco calificaciones";
            this.promedioDeCincoCalificacionesToolStripMenuItem.Click += new System.EventHandler(this.promedioDeCincoCalificacionesToolStripMenuItem_Click);
            // 
            // arreglosBidimencionalesToolStripMenuItem
            // 
            this.arreglosBidimencionalesToolStripMenuItem.Name = "arreglosBidimencionalesToolStripMenuItem";
            this.arreglosBidimencionalesToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.arreglosBidimencionalesToolStripMenuItem.Text = "Arreglos bidimensionales";
            this.arreglosBidimencionalesToolStripMenuItem.Click += new System.EventHandler(this.arreglosBidimencionalesToolStripMenuItem_Click);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pilaListaDeMaterialesToolStripMenuItem
            // 
            this.pilaListaDeMaterialesToolStripMenuItem.Name = "pilaListaDeMaterialesToolStripMenuItem";
            this.pilaListaDeMaterialesToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.pilaListaDeMaterialesToolStripMenuItem.Text = "Pila (Lista de materiales)";
            this.pilaListaDeMaterialesToolStripMenuItem.Click += new System.EventHandler(this.pilaListaDeMaterialesToolStripMenuItem_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.Text = "Menú de Opciones Paradigmas de Programación";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesAritméticasDeTresValoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promedioDeTresCalificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promedioDeCincoCalificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arreglosBidimencionalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilaListaDeMaterialesToolStripMenuItem;
    }
}

