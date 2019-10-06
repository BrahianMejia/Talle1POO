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
    public partial class Indicemasac : Form
    {
        Masacorporal masacorporal = new Masacorporal();
        public Indicemasac()
        {
            InitializeComponent();
            lblresultado.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            masacorporal.setAltura(double.Parse(txtaltura.Text));
            masacorporal.setPeso(double.Parse(txtpeso.Text));
            lblresultado.Text = masacorporal.calculo().ToString();
            lblresultado.Visible = true;
            txtaltura.Text = "";
            txtpeso.Text = "";
            txtpeso.Focus();

            if (masacorporal.calculo() < 18.5)
            {
                MessageBox.Show("Peso bajo");
            }
            else
            {
                if (masacorporal.calculo() < 24.9)
                {
                    MessageBox.Show("Peso normal");
                }
                else
                {
                    if (masacorporal.calculo() < 29.9)
                    {
                        MessageBox.Show("Sobrepeso");
                    }
                    else
                    {
                        if (masacorporal.calculo() < 34.9)
                        {
                            MessageBox.Show("Obesidad tipo 1");
                        }
                        else
                        {
                            if (masacorporal.calculo() < 39.9)
                            {
                                MessageBox.Show("Obesidad tipo 2");
                            }
                            else
                            {
                                if (masacorporal.calculo() >= 40)
                                {
                                    MessageBox.Show("Obesidad tipo 3");
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
