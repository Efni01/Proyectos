namespace Proyectos.PROYECTOSPP
{
    partial class Promediodecincocalificaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.calificacion1 = new System.Windows.Forms.TextBox();
            this.calificacion2 = new System.Windows.Forms.TextBox();
            this.calificacion3 = new System.Windows.Forms.TextBox();
            this.calificacion4 = new System.Windows.Forms.TextBox();
            this.calificacion5 = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calificacion1
            // 
            this.calificacion1.Location = new System.Drawing.Point(286, 25);
            this.calificacion1.Name = "calificacion1";
            this.calificacion1.Size = new System.Drawing.Size(100, 20);
            this.calificacion1.TabIndex = 0;
            this.calificacion1.TextChanged += new System.EventHandler(this.calificacion1_TextChanged);
            // 
            // calificacion2
            // 
            this.calificacion2.Location = new System.Drawing.Point(286, 61);
            this.calificacion2.Name = "calificacion2";
            this.calificacion2.Size = new System.Drawing.Size(100, 20);
            this.calificacion2.TabIndex = 1;
            // 
            // calificacion3
            // 
            this.calificacion3.Location = new System.Drawing.Point(286, 100);
            this.calificacion3.Name = "calificacion3";
            this.calificacion3.Size = new System.Drawing.Size(100, 20);
            this.calificacion3.TabIndex = 2;
            // 
            // calificacion4
            // 
            this.calificacion4.Location = new System.Drawing.Point(286, 137);
            this.calificacion4.Name = "calificacion4";
            this.calificacion4.Size = new System.Drawing.Size(100, 20);
            this.calificacion4.TabIndex = 3;
            // 
            // calificacion5
            // 
            this.calificacion5.Location = new System.Drawing.Point(286, 174);
            this.calificacion5.Name = "calificacion5";
            this.calificacion5.Size = new System.Drawing.Size(100, 20);
            this.calificacion5.TabIndex = 4;
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(286, 210);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(100, 20);
            this.resultado.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Calificacion 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Calificacion 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Calificacion 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Calificacion 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Calificacion 5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Promedio";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "CALCULAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Promediodecincocalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.calificacion5);
            this.Controls.Add(this.calificacion4);
            this.Controls.Add(this.calificacion3);
            this.Controls.Add(this.calificacion2);
            this.Controls.Add(this.calificacion1);
            this.Name = "Promediodecincocalificaciones";
            this.Text = "Promedio de cinco calificaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox calificacion1;
        private System.Windows.Forms.TextBox calificacion2;
        private System.Windows.Forms.TextBox calificacion3;
        private System.Windows.Forms.TextBox calificacion4;
        private System.Windows.Forms.TextBox calificacion5;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}