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
    public partial class Vidaetapas : Form
    {
        Etapasvida etapasvida = new Etapasvida();
        public Vidaetapas()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {

            etapasvida.setNumeroedad(int.Parse(txtedad.Text));
            txtedad.Focus();
            txtedad.Text = "";
            if (etapasvida.getNumeroedad() <= 10)
            {
                MessageBox.Show("Es un niño.");
            }
            else
            {
                if (etapasvida.getNumeroedad() <= 14)
                {
                    MessageBox.Show("Es un pre-adolescente.");
                }
                else
                {
                    if (etapasvida.getNumeroedad() <= 18)
                    {
                        MessageBox.Show("Es un adolescente.");
                    }
                    else
                    {
                        if (etapasvida.getNumeroedad() <= 25)
                        {
                            MessageBox.Show("Es un joven.");
                        }
                        else
                        {
                            if (etapasvida.getNumeroedad() <= 65)
                            {
                                MessageBox.Show("es un adulto.");
                            }
                            else
                            {
                                if (etapasvida.getNumeroedad() > 65)
                                {
                                    MessageBox.Show("Es un anciano.");
                                }

                            }
                        }

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
