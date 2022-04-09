using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjCalculadoraGeométrica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double raio = Convert.ToDouble(txtRaio.Text);
            if (rbPerimetro.Checked == true)
            {
                double p = Math.PI * 2 * raio;
                lblResposta.Text = p.ToString("N3") + " cm";
            }
            if (rbArea.Checked == true)
            {
                double a = Math.PI * Math.Pow(raio, 2);
                lblResposta.Text = a.ToString("N3") + " cm";
            }
            if (rbVolume.Checked == true)
            {
                double v = 2f / 3f * Math.PI * Math.Pow(raio, 3);
                lblResposta.Text = v.ToString("N3") + " cm";
            }

            if (chkbDesenhar.Checked == true)
            {
                DesenhoCirculo();
            }
        }

        private void DesenhoCirculo()
        {
            // throw new NotImplementedException();
            Graphics tela = pn.CreateGraphics(); // cria area de desenho
            Pen caneta = new Pen(Color.Red, 2); // cria a caneta

            int x = pn.Width / 2;
            int y = pn.Height / 2;

            double raio = Convert.ToDouble(txtRaio.Text);

            tela.DrawEllipse(caneta, x - (int)raio / 2,
                y - (int)raio / 2, (int)raio, (int)raio);

            tela.DrawLine(caneta, 0, y, pn.Width, y);

            tela.DrawLine(caneta, x, 0, x, pn.Height);

            tela.DrawRectangle(caneta, x - (int)raio / 2, y - (int)raio / 2,
                (int)raio, (int)raio);

           
        }

        private void chkbDesenhar_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkbDesenhar.Checked)
            {
                Graphics tela = pn.CreateGraphics();
                tela.Clear(Color.White);
            }
        }
    }
   
}
