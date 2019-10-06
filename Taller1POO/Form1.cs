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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnimc_Click(object sender, EventArgs e)
        {
            Indicemasac indicemasac = new Indicemasac();

            indicemasac.Show();
            this.Hide();
        }

        private void btnllamadas_Click(object sender, EventArgs e)
        {
            LLamadaempresa llamadaempresa = new LLamadaempresa();

            llamadaempresa.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Promedio promedio = new Promedio();
            promedio.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cajavolumen cajavolumen = new Cajavolumen();
            cajavolumen.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Raizcuadrada raizcuadrada = new Raizcuadrada();
            raizcuadrada.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Descuentrocompra descuentrocompra = new Descuentrocompra();
            descuentrocompra.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Vidaetapas vidaetapas = new Vidaetapas();
            vidaetapas.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Edadensegundos edadensegundos = new Edadensegundos();
            edadensegundos.Show();
            this.Hide();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Tringulorectangulo tringulorectangulo = new Tringulorectangulo();
            tringulorectangulo.Show();
            this.Hide();
        }
    }
}
