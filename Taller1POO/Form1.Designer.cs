namespace Taller1POO
{
    partial class Form1
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
            this.btnimc = new System.Windows.Forms.Button();
            this.btnllamadas = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnimc
            // 
            this.btnimc.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnimc.Location = new System.Drawing.Point(281, 80);
            this.btnimc.Name = "btnimc";
            this.btnimc.Size = new System.Drawing.Size(87, 49);
            this.btnimc.TabIndex = 0;
            this.btnimc.Text = "IMC";
            this.btnimc.UseVisualStyleBackColor = true;
            this.btnimc.Click += new System.EventHandler(this.btnimc_Click);
            // 
            // btnllamadas
            // 
            this.btnllamadas.Location = new System.Drawing.Point(281, 135);
            this.btnllamadas.Name = "btnllamadas";
            this.btnllamadas.Size = new System.Drawing.Size(87, 49);
            this.btnllamadas.TabIndex = 1;
            this.btnllamadas.Text = "LLamadas";
            this.btnllamadas.UseVisualStyleBackColor = true;
            this.btnllamadas.Click += new System.EventHandler(this.btnllamadas_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(281, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 49);
            this.button3.TabIndex = 2;
            this.button3.Text = "Promedio Notas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(281, 245);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 49);
            this.button4.TabIndex = 3;
            this.button4.Text = "Volumen Caja";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(428, 80);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 49);
            this.button5.TabIndex = 4;
            this.button5.Text = "Raiz Cuadrada";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(428, 135);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 49);
            this.button6.TabIndex = 5;
            this.button6.Text = "Descuento";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(428, 190);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(87, 49);
            this.button7.TabIndex = 6;
            this.button7.Text = "Etapas De Vida";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(428, 245);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(87, 49);
            this.button8.TabIndex = 7;
            this.button8.Text = "Edad En Segundos";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(354, 323);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(87, 49);
            this.button9.TabIndex = 8;
            this.button9.Text = "Triángulo Rectángulo";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(698, 415);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 9;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnllamadas);
            this.Controls.Add(this.btnimc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnimc;
        private System.Windows.Forms.Button btnllamadas;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnsalir;
    }
}

