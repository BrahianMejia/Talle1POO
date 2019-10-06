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
    public partial class Cajavolumen : Form
    {
        Volumencaja volumencaja = new Volumencaja();
        public Cajavolumen()
        {
            InitializeComponent();
            lblresultado.Visible = false;
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            volumencaja.setNumeroalto(double.Parse(txtaltura.Text));
            volumencaja.setNumeroancho(double.Parse(txtancho.Text));
            volumencaja.setNumerolargo(double.Parse(txtlargo.Text));
            lblresultado.Text = volumencaja.calcular().ToString();
            lblresultado.Visible = true;
            txtaltura.Focus();
            txtaltura.Text = "";
            txtancho.Text = "";
            txtlargo.Text = "";
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
