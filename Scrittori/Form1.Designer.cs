namespace Scrittori
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.scelta_colore = new System.Windows.Forms.Button();
            this.corsivo = new System.Windows.Forms.CheckBox();
            this.sottolineato = new System.Windows.Forms.CheckBox();
            this.grassetto = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.scrivi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(754, 428);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // scelta_colore
            // 
            this.scelta_colore.Location = new System.Drawing.Point(625, 458);
            this.scelta_colore.Name = "scelta_colore";
            this.scelta_colore.Size = new System.Drawing.Size(141, 38);
            this.scelta_colore.TabIndex = 2;
            this.scelta_colore.Text = "scelta_colore";
            this.scelta_colore.UseVisualStyleBackColor = true;
            this.scelta_colore.Click += new System.EventHandler(this.scelta_colore_Click);
            // 
            // corsivo
            // 
            this.corsivo.AutoSize = true;
            this.corsivo.Location = new System.Drawing.Point(447, 466);
            this.corsivo.Name = "corsivo";
            this.corsivo.Size = new System.Drawing.Size(87, 24);
            this.corsivo.TabIndex = 3;
            this.corsivo.Text = "Corsivo";
            this.corsivo.UseVisualStyleBackColor = true;
            // 
            // sottolineato
            // 
            this.sottolineato.AutoSize = true;
            this.sottolineato.Location = new System.Drawing.Point(223, 466);
            this.sottolineato.Name = "sottolineato";
            this.sottolineato.Size = new System.Drawing.Size(121, 24);
            this.sottolineato.TabIndex = 4;
            this.sottolineato.Text = "Sottolineato";
            this.sottolineato.UseVisualStyleBackColor = true;
            // 
            // grassetto
            // 
            this.grassetto.AutoSize = true;
            this.grassetto.Location = new System.Drawing.Point(12, 466);
            this.grassetto.Name = "grassetto";
            this.grassetto.Size = new System.Drawing.Size(106, 24);
            this.grassetto.TabIndex = 5;
            this.grassetto.Text = "Grassetto";
            this.grassetto.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 515);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(754, 26);
            this.textBox1.TabIndex = 6;
            // 
            // scrivi
            // 
            this.scrivi.Location = new System.Drawing.Point(12, 563);
            this.scrivi.Name = "scrivi";
            this.scrivi.Size = new System.Drawing.Size(754, 38);
            this.scrivi.TabIndex = 7;
            this.scrivi.Text = "Scrivi";
            this.scrivi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 614);
            this.Controls.Add(this.scrivi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.grassetto);
            this.Controls.Add(this.sottolineato);
            this.Controls.Add(this.corsivo);
            this.Controls.Add(this.scelta_colore);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button scelta_colore;
        private System.Windows.Forms.CheckBox corsivo;
        private System.Windows.Forms.CheckBox sottolineato;
        private System.Windows.Forms.CheckBox grassetto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button scrivi;
    }
}

