namespace geometria
{
    partial class piramide
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
            this.textopiramide1 = new System.Windows.Forms.Label();
            this.textopiramide2 = new System.Windows.Forms.Label();
            this.caixapiramide1 = new System.Windows.Forms.TextBox();
            this.caixapiramide2 = new System.Windows.Forms.TextBox();
            this.botaopiramide = new System.Windows.Forms.Button();
            this.resultadopiramide = new System.Windows.Forms.TextBox();
            this.textopiramide3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textopiramide1
            // 
            this.textopiramide1.AutoSize = true;
            this.textopiramide1.Location = new System.Drawing.Point(73, 44);
            this.textopiramide1.Name = "textopiramide1";
            this.textopiramide1.Size = new System.Drawing.Size(140, 13);
            this.textopiramide1.TabIndex = 0;
            this.textopiramide1.Text = "Digite valor da área da base";
            this.textopiramide1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textopiramide2
            // 
            this.textopiramide2.AutoSize = true;
            this.textopiramide2.Location = new System.Drawing.Point(90, 109);
            this.textopiramide2.Name = "textopiramide2";
            this.textopiramide2.Size = new System.Drawing.Size(104, 13);
            this.textopiramide2.TabIndex = 1;
            this.textopiramide2.Text = "Digite valor da altura";
            // 
            // caixapiramide1
            // 
            this.caixapiramide1.Location = new System.Drawing.Point(93, 74);
            this.caixapiramide1.Name = "caixapiramide1";
            this.caixapiramide1.Size = new System.Drawing.Size(100, 20);
            this.caixapiramide1.TabIndex = 2;
            this.caixapiramide1.TextChanged += new System.EventHandler(this.caixapiramide1_TextChanged);
            // 
            // caixapiramide2
            // 
            this.caixapiramide2.Location = new System.Drawing.Point(93, 136);
            this.caixapiramide2.Name = "caixapiramide2";
            this.caixapiramide2.Size = new System.Drawing.Size(100, 20);
            this.caixapiramide2.TabIndex = 3;
            this.caixapiramide2.TextChanged += new System.EventHandler(this.caixapiramide2_TextChanged);
            // 
            // botaopiramide
            // 
            this.botaopiramide.Location = new System.Drawing.Point(93, 188);
            this.botaopiramide.Name = "botaopiramide";
            this.botaopiramide.Size = new System.Drawing.Size(101, 23);
            this.botaopiramide.TabIndex = 4;
            this.botaopiramide.Text = "Calcular volume";
            this.botaopiramide.UseVisualStyleBackColor = true;
            this.botaopiramide.Click += new System.EventHandler(this.botaopiramide_Click);
            // 
            // resultadopiramide
            // 
            this.resultadopiramide.Location = new System.Drawing.Point(212, 237);
            this.resultadopiramide.Name = "resultadopiramide";
            this.resultadopiramide.Size = new System.Drawing.Size(46, 20);
            this.resultadopiramide.TabIndex = 5;
            // 
            // textopiramide3
            // 
            this.textopiramide3.AutoSize = true;
            this.textopiramide3.Location = new System.Drawing.Point(148, 240);
            this.textopiramide3.Name = "textopiramide3";
            this.textopiramide3.Size = new System.Drawing.Size(58, 13);
            this.textopiramide3.TabIndex = 6;
            this.textopiramide3.Text = "Resultado:";
            // 
            // piramide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 260);
            this.Controls.Add(this.textopiramide3);
            this.Controls.Add(this.resultadopiramide);
            this.Controls.Add(this.botaopiramide);
            this.Controls.Add(this.caixapiramide2);
            this.Controls.Add(this.caixapiramide1);
            this.Controls.Add(this.textopiramide2);
            this.Controls.Add(this.textopiramide1);
            this.Name = "piramide";
            this.Text = "Volume da piramide";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textopiramide1;
        private System.Windows.Forms.Label textopiramide2;
        private System.Windows.Forms.TextBox caixapiramide1;
        private System.Windows.Forms.TextBox caixapiramide2;
        private System.Windows.Forms.Button botaopiramide;
        private System.Windows.Forms.TextBox resultadopiramide;
        private System.Windows.Forms.Label textopiramide3;
    }
}