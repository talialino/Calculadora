namespace geometria
{
    partial class cubo
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
            this.botaocubo = new System.Windows.Forms.Button();
            this.textocubo = new System.Windows.Forms.Label();
            this.caixacubo = new System.Windows.Forms.TextBox();
            this.textocubo2 = new System.Windows.Forms.Label();
            this.resultadocubo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botaocubo
            // 
            this.botaocubo.Location = new System.Drawing.Point(90, 97);
            this.botaocubo.Name = "botaocubo";
            this.botaocubo.Size = new System.Drawing.Size(98, 23);
            this.botaocubo.TabIndex = 0;
            this.botaocubo.Text = "Calcular volume";
            this.botaocubo.UseVisualStyleBackColor = true;
            this.botaocubo.Click += new System.EventHandler(this.botaocubo_Click);
            // 
            // textocubo
            // 
            this.textocubo.AutoSize = true;
            this.textocubo.Location = new System.Drawing.Point(74, 28);
            this.textocubo.Name = "textocubo";
            this.textocubo.Size = new System.Drawing.Size(130, 13);
            this.textocubo.TabIndex = 1;
            this.textocubo.Text = "Digite as arestas do cubo:";
            // 
            // caixacubo
            // 
            this.caixacubo.Location = new System.Drawing.Point(88, 61);
            this.caixacubo.Name = "caixacubo";
            this.caixacubo.Size = new System.Drawing.Size(100, 20);
            this.caixacubo.TabIndex = 2;
            // 
            // textocubo2
            // 
            this.textocubo2.AutoSize = true;
            this.textocubo2.Location = new System.Drawing.Point(141, 162);
            this.textocubo2.Name = "textocubo2";
            this.textocubo2.Size = new System.Drawing.Size(58, 13);
            this.textocubo2.TabIndex = 3;
            this.textocubo2.Text = "Resultado:";
            // 
            // resultadocubo
            // 
            this.resultadocubo.Location = new System.Drawing.Point(205, 159);
            this.resultadocubo.Name = "resultadocubo";
            this.resultadocubo.Size = new System.Drawing.Size(56, 20);
            this.resultadocubo.TabIndex = 4;
            // 
            // cubo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 179);
            this.Controls.Add(this.resultadocubo);
            this.Controls.Add(this.textocubo2);
            this.Controls.Add(this.caixacubo);
            this.Controls.Add(this.textocubo);
            this.Controls.Add(this.botaocubo);
            this.Name = "cubo";
            this.Text = "Volume do cubo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaocubo;
        private System.Windows.Forms.Label textocubo;
        private System.Windows.Forms.TextBox caixacubo;
        private System.Windows.Forms.Label textocubo2;
        private System.Windows.Forms.TextBox resultadocubo;
    }
}