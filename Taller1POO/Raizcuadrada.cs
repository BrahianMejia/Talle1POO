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
    public partial class Raizcuadrada : Form
    {
        Cuadradaraiz cuadradaraiz = new Cuadradaraiz();
        public Raizcuadrada()
        {
            InitializeComponent();
            lblresultado.Visible = false;
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            cuadradaraiz.setNumero1(double.Parse(txtnumero.Text));
            lblresultado.Text = cuadradaraiz.calcular().ToString();
            lblresultado.Visible = true;
            txtnumero.Text = "";
            txtnumero.Focus();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
