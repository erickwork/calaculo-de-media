using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoMedia
{
    public partial class CalcMedia : Form
    {
        public CalcMedia()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void calcular_Click(object sender, EventArgs e)
        {
            double pnp1, pnp2, ppim, resultado;
            

            pnp1 = Convert.ToInt32(np1.Text);
            pnp2 = Convert.ToInt32(np2.Text);
            ppim = Convert.ToInt32(pim.Text);

            resultado = pnp1 * 0.4 +  pnp2 * 0.4 + ppim * 0.2;

            media.Text = resultado.ToString();

            zerar.Enabled = true;
        }

        private void np1_TextChanged(object sender, EventArgs e)
        {

        }

        private void zerar_Click(object sender, EventArgs e)
        {
            media.Text = "";
            pim.Text = "";
            np1.Text = "";
            np2.Text = "";


            zerar.Enabled = false;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
