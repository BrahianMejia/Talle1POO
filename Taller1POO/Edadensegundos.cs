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
    public partial class Edadensegundos : Form
    {
        edadenaños edadenaños = new edadenaños();
        public Edadensegundos()
        {
            InitializeComponent();
            lblresultado.Visible = false;
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {

            edadenaños.setEdad(double.Parse(txtedad.Text));
            lblresultado.Text = edadenaños.calcular().ToString();
            lblresultado.Visible = true;
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
