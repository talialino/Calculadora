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
    public partial class esfera : Form
    {
        public esfera()
        {
            InitializeComponent();
        }

        private void botaoesfera_Click(object sender, EventArgs e)
        {
            double raio, resultado;
            raio = Convert.ToInt16(caixaesfera.Text);            
            resultado = (4*3.14*Math.Pow(raio,3))/3;
            resultadoesfera.Text = resultado.ToString();
        }
    }
}
