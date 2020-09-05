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
    public partial class triangulo : Form
    {
        public triangulo()
        {
            InitializeComponent();
        }

        private void botaotriangulo_Click(object sender, EventArgs e)
        {
            int basetri, altura, resultado;
            basetri = Convert.ToInt16(caixatriangulo1.Text);
            altura = Convert.ToInt16(caixatriangulo2.Text);
            resultado = (basetri * altura)/2;
            resultadotriangulo.Text = resultado.ToString();
        }
    }
}
