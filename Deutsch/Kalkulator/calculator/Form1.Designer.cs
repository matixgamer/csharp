namespace calculator
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dodaj = new System.Windows.Forms.Button();
            this.Odejmnij = new System.Windows.Forms.Button();
            this.Pomnóż = new System.Windows.Forms.Button();
            this.Podziel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Wynik = new System.Windows.Forms.Label();
            this.potega = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(89, 35);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(177, 20);
            this.numericUpDown1.TabIndex = 0;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(89, 91);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(177, 20);
            this.numericUpDown2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Erste Nummer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zweite Nummer";
            // 
            // Dodaj
            // 
            this.Dodaj.Location = new System.Drawing.Point(8, 138);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(75, 23);
            this.Dodaj.TabIndex = 4;
            this.Dodaj.Text = "Addieren";
            this.Dodaj.UseVisualStyleBackColor = true;
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // Odejmnij
            // 
            this.Odejmnij.Location = new System.Drawing.Point(89, 138);
            this.Odejmnij.Name = "Odejmnij";
            this.Odejmnij.Size = new System.Drawing.Size(100, 23);
            this.Odejmnij.TabIndex = 5;
            this.Odejmnij.Text = "Subtrahiert von";
            this.Odejmnij.UseVisualStyleBackColor = true;
            this.Odejmnij.Click += new System.EventHandler(this.Odejmnij_Click);
            // 
            // Pomnóż
            // 
            this.Pomnóż.Location = new System.Drawing.Point(8, 191);
            this.Pomnóż.Name = "Pomnóż";
            this.Pomnóż.Size = new System.Drawing.Size(75, 23);
            this.Pomnóż.TabIndex = 6;
            this.Pomnóż.Text = "Mal";
            this.Pomnóż.UseVisualStyleBackColor = true;
            this.Pomnóż.Click += new System.EventHandler(this.Pomnóż_Click);
            // 
            // Podziel
            // 
            this.Podziel.Location = new System.Drawing.Point(100, 191);
            this.Podziel.Name = "Podziel";
            this.Podziel.Size = new System.Drawing.Size(75, 23);
            this.Podziel.TabIndex = 7;
            this.Podziel.Text = "Geteilt durch";
            this.Podziel.UseVisualStyleBackColor = true;
            this.Podziel.Click += new System.EventHandler(this.Podziel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 240);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // Wynik
            // 
            this.Wynik.AutoSize = true;
            this.Wynik.Location = new System.Drawing.Point(18, 243);
            this.Wynik.Name = "Wynik";
            this.Wynik.Size = new System.Drawing.Size(37, 13);
            this.Wynik.TabIndex = 9;
            this.Wynik.Text = "Gleich";
            // 
            // potega
            // 
            this.potega.Location = new System.Drawing.Point(199, 138);
            this.potega.Name = "potega";
            this.potega.Size = new System.Drawing.Size(85, 23);
            this.potega.TabIndex = 10;
            this.potega.Text = "Hoch";
            this.potega.UseVisualStyleBackColor = true;
            this.potega.Click += new System.EventHandler(this.Potega_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 302);
            this.Controls.Add(this.potega);
            this.Controls.Add(this.Wynik);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Podziel);
            this.Controls.Add(this.Pomnóż);
            this.Controls.Add(this.Odejmnij);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.Button Odejmnij;
        private System.Windows.Forms.Button Pomnóż;
        private System.Windows.Forms.Button Podziel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Wynik;
        private System.Windows.Forms.Button potega;
    }
}

