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
    public partial class Tringulorectangulo : Form
    {
        Ladostriangulo ladostriangulo = new Ladostriangulo();
        public Tringulorectangulo()
        {
            InitializeComponent();
            lblresultado.Visible = false;
            lblarea.Visible = false;
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            ladostriangulo.setLadoa(double.Parse(txtladoa.Text));
            ladostriangulo.setLadob(double.Parse(txtladob.Text));
            ladostriangulo.setLadoc(double.Parse(txtladoc.Text));


            if (ladostriangulo.calcular() == ladostriangulo.ladoc)
            {
                lblresultado.Text = "El triángulo es rectángulo.";

                lblarea.Text = ladostriangulo.resultado.ToString();
                lblarea.Visible = true;
            }
            else
            {
                lblresultado.Text = "El triángulo no es rectángulo.";
            }
            lblresultado.Visible = true;
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void lblarea_Click(object sender, EventArgs e)
        {

        }
    }
}
