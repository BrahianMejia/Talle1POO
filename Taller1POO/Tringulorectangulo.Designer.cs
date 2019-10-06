namespace Taller1POO
{
    partial class Tringulorectangulo
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
            this.btncalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtladoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtladob = new System.Windows.Forms.TextBox();
            this.txtladoa = new System.Windows.Forms.TextBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.btnregresar = new System.Windows.Forms.Button();
            this.lblarea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(448, 200);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 0;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lado A:";
            // 
            // txtladoc
            // 
            this.txtladoc.Location = new System.Drawing.Point(287, 235);
            this.txtladoc.Name = "txtladoc";
            this.txtladoc.Size = new System.Drawing.Size(100, 20);
            this.txtladoc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lado B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lado C:";
            // 
            // txtladob
            // 
            this.txtladob.Location = new System.Drawing.Point(287, 202);
            this.txtladob.Name = "txtladob";
            this.txtladob.Size = new System.Drawing.Size(100, 20);
            this.txtladob.TabIndex = 5;
            // 
            // txtladoa
            // 
            this.txtladoa.Location = new System.Drawing.Point(287, 162);
            this.txtladoa.Name = "txtladoa";
            this.txtladoa.Size = new System.Drawing.Size(100, 20);
            this.txtladoa.TabIndex = 6;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(377, 343);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(35, 13);
            this.lblresultado.TabIndex = 7;
            this.lblresultado.Text = "label4";
            // 
            // btnregresar
            // 
            this.btnregresar.Location = new System.Drawing.Point(700, 410);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(75, 23);
            this.btnregresar.TabIndex = 8;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // lblarea
            // 
            this.lblarea.AutoSize = true;
            this.lblarea.Location = new System.Drawing.Point(377, 380);
            this.lblarea.Name = "lblarea";
            this.lblarea.Size = new System.Drawing.Size(35, 13);
            this.lblarea.TabIndex = 9;
            this.lblarea.Text = "label4";
            this.lblarea.Click += new System.EventHandler(this.lblarea_Click);
            // 
            // Tringulorectangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblarea);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.txtladoa);
            this.Controls.Add(this.txtladob);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtladoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncalcular);
            this.Name = "Tringulorectangulo";
            this.Text = "Tringulorectangulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtladoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtladob;
        private System.Windows.Forms.TextBox txtladoa;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.Label lblarea;
    }
}