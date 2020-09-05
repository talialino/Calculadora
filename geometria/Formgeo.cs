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
    public partial class Formgeo : Form
    {
        public Formgeo()
        {
            InitializeComponent();
        }

        private void plana(object sender, EventArgs e)
        {

        }

        private void quadrado(object sender, EventArgs e)
        {
            quadrado objq = new quadrado();
            objq.ShowDialog();
        }

        private void triangulo(object sender, EventArgs e)
        {
            triangulo objt = new triangulo();
            objt.ShowDialog();
        }

        private void circulo(object sender, EventArgs e)
        {
            circulo objc = new circulo();
            objc.ShowDialog();
        }

        private void espacial(object sender, EventArgs e)
        {

        }

        private void cubo(object sender, EventArgs e)
        {
            cubo objcu = new cubo();
            objcu.ShowDialog();
        }

        private void piramide(object sender, EventArgs e)
        {
            piramide objp = new piramide();
            objp.ShowDialog();
        }

        private void esfera(object sender, EventArgs e)
        {
            esfera obje = new esfera();
            obje.ShowDialog();
        }

        private void sair(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
