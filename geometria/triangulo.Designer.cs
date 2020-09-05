namespace geometria
{
    partial class triangulo
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
            this.botaotriangulo = new System.Windows.Forms.Button();
            this.textotriangulo1 = new System.Windows.Forms.Label();
            this.textotriangulo2 = new System.Windows.Forms.Label();
            this.caixatriangulo1 = new System.Windows.Forms.TextBox();
            this.caixatriangulo2 = new System.Windows.Forms.TextBox();
            this.textotriangulo3 = new System.Windows.Forms.Label();
            this.resultadotriangulo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botaotriangulo
            // 
            this.botaotriangulo.Location = new System.Drawing.Point(88, 174);
            this.botaotriangulo.Name = "botaotriangulo";
            this.botaotriangulo.Size = new System.Drawing.Size(101, 23);
            this.botaotriangulo.TabIndex = 0;
            this.botaotriangulo.Text = "Calcular área";
            this.botaotriangulo.UseVisualStyleBackColor = true;
            this.botaotriangulo.Click += new System.EventHandler(this.botaotriangulo_Click);
            // 
            // textotriangulo1
            // 
            this.textotriangulo1.AutoSize = true;
            this.textotriangulo1.Location = new System.Drawing.Point(85, 38);
            this.textotriangulo1.Name = "textotriangulo1";
            this.textotriangulo1.Size = new System.Drawing.Size(104, 13);
            this.textotriangulo1.TabIndex = 1;
            this.textotriangulo1.Text = "Digite valor da base:";
            // 
            // textotriangulo2
            // 
            this.textotriangulo2.AutoSize = true;
            this.textotriangulo2.Location = new System.Drawing.Point(85, 109);
            this.textotriangulo2.Name = "textotriangulo2";
            this.textotriangulo2.Size = new System.Drawing.Size(107, 13);
            this.textotriangulo2.TabIndex = 2;
            this.textotriangulo2.Text = "Digite valor da altura:";
            // 
            // caixatriangulo1
            // 
            this.caixatriangulo1.Location = new System.Drawing.Point(88, 70);
            this.caixatriangulo1.Name = "caixatriangulo1";
            this.caixatriangulo1.Size = new System.Drawing.Size(100, 20);
            this.caixatriangulo1.TabIndex = 3;
            // 
            // caixatriangulo2
            // 
            this.caixatriangulo2.Location = new System.Drawing.Point(89, 135);
            this.caixatriangulo2.Name = "caixatriangulo2";
            this.caixatriangulo2.Size = new System.Drawing.Size(100, 20);
            this.caixatriangulo2.TabIndex = 4;
            // 
            // textotriangulo3
            // 
            this.textotriangulo3.AutoSize = true;
            this.textotriangulo3.Location = new System.Drawing.Point(155, 238);
            this.textotriangulo3.Name = "textotriangulo3";
            this.textotriangulo3.Size = new System.Drawing.Size(58, 13);
            this.textotriangulo3.TabIndex = 5;
            this.textotriangulo3.Text = "Resultado:";
            // 
            // resultadotriangulo
            // 
            this.resultadotriangulo.Location = new System.Drawing.Point(219, 235);
            this.resultadotriangulo.Name = "resultadotriangulo";
            this.resultadotriangulo.Size = new System.Drawing.Size(48, 20);
            this.resultadotriangulo.TabIndex = 6;
            // 
            // triangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 260);
            this.Controls.Add(this.resultadotriangulo);
            this.Controls.Add(this.textotriangulo3);
            this.Controls.Add(this.caixatriangulo2);
            this.Controls.Add(this.caixatriangulo1);
            this.Controls.Add(this.textotriangulo2);
            this.Controls.Add(this.textotriangulo1);
            this.Controls.Add(this.botaotriangulo);
            this.Name = "triangulo";
            this.Text = "Área do triangulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaotriangulo;
        private System.Windows.Forms.Label textotriangulo1;
        private System.Windows.Forms.Label textotriangulo2;
        private System.Windows.Forms.TextBox caixatriangulo1;
        private System.Windows.Forms.TextBox caixatriangulo2;
        private System.Windows.Forms.Label textotriangulo3;
        private System.Windows.Forms.TextBox resultadotriangulo;
    }
}