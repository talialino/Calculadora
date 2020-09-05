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
    public partial class piramide : Form
    {
        public piramide()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botaopiramide_Click(object sender, EventArgs e)
        {
            int area, altura, resultado;
            area = Convert.ToInt16(caixapiramide1.Text);
            altura = Convert.ToInt16(caixapiramide2.Text);
            resultado = (1 * area * altura) / 3;
            resultadopiramide.Text = resultado.ToString();
        }

        private void caixapiramide1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void caixapiramide2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
