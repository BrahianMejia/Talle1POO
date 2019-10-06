using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller1POO
{
    public partial class Promedio : Form
    {

        Calcularpromedio calcularpromedio = new Calcularpromedio();
        public Promedio()
        {
            InitializeComponent();
            lblresultado.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            calcularpromedio.setNota1(double.Parse(txtnota1.Text));
            calcularpromedio.setNota2(double.Parse(txtnota2.Text));
            calcularpromedio.setNota3(double.Parse(txtnota3.Text));
            calcularpromedio.setNota4(double.Parse(txtnota4.Text));

            lblresultado.Text = calcularpromedio.resultado().ToString();
            lblresultado.Visible = true;
            txtnota1.Text = "";
            txtnota2.Text = "";
            txtnota3.Text = "";
            txtnota4.Text = "";

            txtnota1.Focus();

            if (calcularpromedio.resultado() < 2.99)
            {

                MessageBox.Show(" Nota Deficiente");
            }
            else
            {

                if (calcularpromedio.resultado() < 3.99)
                {

                    MessageBox.Show("Nota Buena");
                }
                else
                {

                    if (calcularpromedio.resultado() >= 4 && (calcularpromedio.resultado() <= 5))
                    {

                        MessageBox.Show("Nota Excelente");
                    }

                }
            }
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
