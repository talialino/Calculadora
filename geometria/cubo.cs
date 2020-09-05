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
    public partial class cubo : Form
    {
        public cubo()
        {
            InitializeComponent();
        }

        private void botaocubo_Click(object sender, EventArgs e)
        {
            double arestas, resultado;
            arestas = Convert.ToInt16(caixacubo.Text);
            resultado = Math.Pow(arestas,3);
            resultadocubo.Text = resultado.ToString();
        }
    }
}
