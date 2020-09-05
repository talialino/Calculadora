namespace geometria
{
    partial class Formgeo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.geometriaPlanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quadradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trianguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geometriaEspacialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pirâmideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esferaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // geometriaPlanaToolStripMenuItem
            // 
            this.geometriaPlanaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quadradoToolStripMenuItem,
            this.trianguloToolStripMenuItem,
            this.circuloToolStripMenuItem});
            this.geometriaPlanaToolStripMenuItem.Name = "geometriaPlanaToolStripMenuItem";
            this.geometriaPlanaToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.geometriaPlanaToolStripMenuItem.Text = "Geometria Plana";
            this.geometriaPlanaToolStripMenuItem.Click += new System.EventHandler(this.plana);
            // 
            // quadradoToolStripMenuItem
            // 
            this.quadradoToolStripMenuItem.Name = "quadradoToolStripMenuItem";
            this.quadradoToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.quadradoToolStripMenuItem.Text = "Quadrado";
            this.quadradoToolStripMenuItem.Click += new System.EventHandler(this.quadrado);
            // 
            // trianguloToolStripMenuItem
            // 
            this.trianguloToolStripMenuItem.Name = "trianguloToolStripMenuItem";
            this.trianguloToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.trianguloToolStripMenuItem.Text = "Triângulo";
            this.trianguloToolStripMenuItem.Click += new System.EventHandler(this.triangulo);
            // 
            // circuloToolStripMenuItem
            // 
            this.circuloToolStripMenuItem.Name = "circuloToolStripMenuItem";
            this.circuloToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.circuloToolStripMenuItem.Text = "Círculo";
            this.circuloToolStripMenuItem.Click += new System.EventHandler(this.circulo);
            // 
            // geometriaEspacialToolStripMenuItem
            // 
            this.geometriaEspacialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuboToolStripMenuItem,
            this.pirâmideToolStripMenuItem,
            this.esferaToolStripMenuItem});
            this.geometriaEspacialToolStripMenuItem.Name = "geometriaEspacialToolStripMenuItem";
            this.geometriaEspacialToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.geometriaEspacialToolStripMenuItem.Text = "Geometria Espacial";
            this.geometriaEspacialToolStripMenuItem.Click += new System.EventHandler(this.espacial);
            // 
            // cuboToolStripMenuItem
            // 
            this.cuboToolStripMenuItem.Name = "cuboToolStripMenuItem";
            this.cuboToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.cuboToolStripMenuItem.Text = "Cubo";
            this.cuboToolStripMenuItem.Click += new System.EventHandler(this.cubo);
            // 
            // pirâmideToolStripMenuItem
            // 
            this.pirâmideToolStripMenuItem.Name = "pirâmideToolStripMenuItem";
            this.pirâmideToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.pirâmideToolStripMenuItem.Text = "Pirâmide";
            this.pirâmideToolStripMenuItem.Click += new System.EventHandler(this.piramide);
            // 
            // esferaToolStripMenuItem
            // 
            this.esferaToolStripMenuItem.Name = "esferaToolStripMenuItem";
            this.esferaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.esferaToolStripMenuItem.Text = "Esfera";
            this.esferaToolStripMenuItem.Click += new System.EventHandler(this.esfera);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sair);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geometriaPlanaToolStripMenuItem,
            this.geometriaEspacialToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(681, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Formgeo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(681, 408);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Formgeo";
            this.Text = "Geometria";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem geometriaPlanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quadradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trianguloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geometriaEspacialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuboToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pirâmideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esferaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;

    }
}

