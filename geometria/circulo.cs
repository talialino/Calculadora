using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace geometria
{
    public partial class circulo : Form
    {
        public circulo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double raio, resultado;
            raio = Convert.ToInt16(caixacirculo.Text);
            resultado = 3.14*Math.Pow(raio,2);
            resultadocirculo.Text = resultado.ToString();
        }
    }
}
