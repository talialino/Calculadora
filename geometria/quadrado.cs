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
    public partial class quadrado : Form
    {
        public quadrado()
        {
            InitializeComponent();
        }

        private void quadrado_Load(object sender, EventArgs e)
        {

        }

        private void botaoquadrado_Click(object sender, EventArgs e)
        {
            double lados, resultado;
            lados = Convert.ToInt16(caixaquadrado.Text);
            resultado = Math.Pow(lados,2);
            resultadoquadrado.Text = resultado.ToString();
        }
    }
}
