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
    public partial class LLamadaempresa : Form
    {
        Empresallamadas empresallamadas = new Empresallamadas();
        public LLamadaempresa()
        {
            InitializeComponent();
            lbltotal.Visible = false;
        }

        private void LLamadaempresa_Load(object sender, EventArgs e)
        {
            cmbpais.Items.Add("Estados Unidos");
            cmbpais.Items.Add("Canadá");
            cmbpais.Items.Add("Europa");
            cmbpais.Items.Add("Resto del mundo");
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            empresallamadas.setdestino(cmbpais.Text);
            empresallamadas.setduracion(double.Parse(txtduracion.Text));
            lbltotal.Text = empresallamadas.totalapagar().ToString();
            lbltotal.Visible = true;
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
