namespace geometria
{
    partial class esfera
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
            this.textoesfera = new System.Windows.Forms.Label();
            this.caixaesfera = new System.Windows.Forms.TextBox();
            this.botaoesfera = new System.Windows.Forms.Button();
            this.textoesfera2 = new System.Windows.Forms.Label();
            this.resultadoesfera = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textoesfera
            // 
            this.textoesfera.AutoSize = true;
            this.textoesfera.Location = new System.Drawing.Point(101, 58);
            this.textoesfera.Name = "textoesfera";
            this.textoesfera.Size = new System.Drawing.Size(66, 13);
            this.textoesfera.TabIndex = 0;
            this.textoesfera.Text = "Digite o raio:";
            // 
            // caixaesfera
            // 
            this.caixaesfera.Location = new System.Drawing.Point(86, 91);
            this.caixaesfera.Name = "caixaesfera";
            this.caixaesfera.Size = new System.Drawing.Size(100, 20);
            this.caixaesfera.TabIndex = 1;
            // 
            // botaoesfera
            // 
            this.botaoesfera.Location = new System.Drawing.Point(86, 140);
            this.botaoesfera.Name = "botaoesfera";
            this.botaoesfera.Size = new System.Drawing.Size(100, 23);
            this.botaoesfera.TabIndex = 2;
            this.botaoesfera.Text = "Calcular volume";
            this.botaoesfera.UseVisualStyleBackColor = true;
            this.botaoesfera.Click += new System.EventHandler(this.botaoesfera_Click);
            // 
            // textoesfera2
            // 
            this.textoesfera2.AutoSize = true;
            this.textoesfera2.Location = new System.Drawing.Point(143, 231);
            this.textoesfera2.Name = "textoesfera2";
            this.textoesfera2.Size = new System.Drawing.Size(55, 13);
            this.textoesfera2.TabIndex = 3;
            this.textoesfera2.Text = "Resultado";
            // 
            // resultadoesfera
            // 
            this.resultadoesfera.Location = new System.Drawing.Point(204, 228);
            this.resultadoesfera.Name = "resultadoesfera";
            this.resultadoesfera.Size = new System.Drawing.Size(51, 20);
            this.resultadoesfera.TabIndex = 4;
            // 
            // esfera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 260);
            this.Controls.Add(this.resultadoesfera);
            this.Controls.Add(this.textoesfera2);
            this.Controls.Add(this.botaoesfera);
            this.Controls.Add(this.caixaesfera);
            this.Controls.Add(this.textoesfera);
            this.Name = "esfera";
            this.Text = "Volume da esfera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textoesfera;
        private System.Windows.Forms.TextBox caixaesfera;
        private System.Windows.Forms.Button botaoesfera;
        private System.Windows.Forms.Label textoesfera2;
        private System.Windows.Forms.TextBox resultadoesfera;
    }
}