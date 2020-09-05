namespace geometria
{
    partial class circulo
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
            this.caixacirculo = new System.Windows.Forms.TextBox();
            this.textocirculo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.resultadocirculo = new System.Windows.Forms.TextBox();
            this.textocirculo2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // caixacirculo
            // 
            this.caixacirculo.Location = new System.Drawing.Point(74, 56);
            this.caixacirculo.Name = "caixacirculo";
            this.caixacirculo.Size = new System.Drawing.Size(100, 20);
            this.caixacirculo.TabIndex = 0;
            // 
            // textocirculo
            // 
            this.textocirculo.AutoSize = true;
            this.textocirculo.Location = new System.Drawing.Point(93, 40);
            this.textocirculo.Name = "textocirculo";
            this.textocirculo.Size = new System.Drawing.Size(66, 13);
            this.textocirculo.TabIndex = 1;
            this.textocirculo.Text = "Digite o raio:";
            this.textocirculo.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calcular área";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultadocirculo
            // 
            this.resultadocirculo.Location = new System.Drawing.Point(192, 181);
            this.resultadocirculo.Name = "resultadocirculo";
            this.resultadocirculo.Size = new System.Drawing.Size(43, 20);
            this.resultadocirculo.TabIndex = 3;
            // 
            // textocirculo2
            // 
            this.textocirculo2.AutoSize = true;
            this.textocirculo2.Location = new System.Drawing.Point(128, 184);
            this.textocirculo2.Name = "textocirculo2";
            this.textocirculo2.Size = new System.Drawing.Size(58, 13);
            this.textocirculo2.TabIndex = 4;
            this.textocirculo2.Text = "Resultado:";
            // 
            // circulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 203);
            this.Controls.Add(this.textocirculo2);
            this.Controls.Add(this.resultadocirculo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textocirculo);
            this.Controls.Add(this.caixacirculo);
            this.Name = "circulo";
            this.Text = "Área do círculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox caixacirculo;
        private System.Windows.Forms.Label textocirculo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox resultadocirculo;
        private System.Windows.Forms.Label textocirculo2;
    }
}