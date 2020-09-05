namespace geometria
{
    partial class quadrado
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
            this.botaoquadrado = new System.Windows.Forms.Button();
            this.textoquadrado = new System.Windows.Forms.Label();
            this.caixaquadrado = new System.Windows.Forms.TextBox();
            this.resultadoquadrado = new System.Windows.Forms.TextBox();
            this.textoquadrado2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botaoquadrado
            // 
            this.botaoquadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoquadrado.Location = new System.Drawing.Point(57, 92);
            this.botaoquadrado.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.botaoquadrado.Name = "botaoquadrado";
            this.botaoquadrado.Size = new System.Drawing.Size(180, 31);
            this.botaoquadrado.TabIndex = 0;
            this.botaoquadrado.Text = "Calcular área";
            this.botaoquadrado.UseVisualStyleBackColor = true;
            this.botaoquadrado.Click += new System.EventHandler(this.botaoquadrado_Click);
            // 
            // textoquadrado
            // 
            this.textoquadrado.AutoSize = true;
            this.textoquadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoquadrado.Location = new System.Drawing.Point(85, 23);
            this.textoquadrado.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.textoquadrado.Name = "textoquadrado";
            this.textoquadrado.Size = new System.Drawing.Size(123, 13);
            this.textoquadrado.TabIndex = 1;
            this.textoquadrado.Text = "Digite lado do quadrado:";
            // 
            // caixaquadrado
            // 
            this.caixaquadrado.Location = new System.Drawing.Point(57, 42);
            this.caixaquadrado.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.caixaquadrado.Name = "caixaquadrado";
            this.caixaquadrado.Size = new System.Drawing.Size(180, 29);
            this.caixaquadrado.TabIndex = 2;
            // 
            // resultadoquadrado
            // 
            this.resultadoquadrado.Location = new System.Drawing.Point(224, 158);
            this.resultadoquadrado.Name = "resultadoquadrado";
            this.resultadoquadrado.Size = new System.Drawing.Size(65, 29);
            this.resultadoquadrado.TabIndex = 3;
            // 
            // textoquadrado2
            // 
            this.textoquadrado2.AutoSize = true;
            this.textoquadrado2.Location = new System.Drawing.Point(119, 161);
            this.textoquadrado2.Name = "textoquadrado2";
            this.textoquadrado2.Size = new System.Drawing.Size(99, 24);
            this.textoquadrado2.TabIndex = 4;
            this.textoquadrado2.Text = "Resultado:";
            // 
            // quadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 190);
            this.Controls.Add(this.textoquadrado2);
            this.Controls.Add(this.resultadoquadrado);
            this.Controls.Add(this.caixaquadrado);
            this.Controls.Add(this.textoquadrado);
            this.Controls.Add(this.botaoquadrado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "quadrado";
            this.Text = "Área do quadrado";
            this.Load += new System.EventHandler(this.quadrado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoquadrado;
        private System.Windows.Forms.Label textoquadrado;
        private System.Windows.Forms.TextBox caixaquadrado;
        private System.Windows.Forms.TextBox resultadoquadrado;
        private System.Windows.Forms.Label textoquadrado2;
    }
}