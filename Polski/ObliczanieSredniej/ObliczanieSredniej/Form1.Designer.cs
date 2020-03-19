namespace ObliczanieSredniej
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MatematykaBox = new System.Windows.Forms.TextBox();
            this.SredniaBox = new System.Windows.Forms.TextBox();
            this.DeutschBox = new System.Windows.Forms.TextBox();
            this.PolskiBox = new System.Windows.Forms.TextBox();
            this.AngielskiBox = new System.Windows.Forms.TextBox();
            this.InformatykaBox = new System.Windows.Forms.TextBox();
            this.PrzeliczButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matematyka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Informatyka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Angielski";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Polski";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Niemiecki";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Średnia";
            // 
            // MatematykaBox
            // 
            this.MatematykaBox.Location = new System.Drawing.Point(151, 44);
            this.MatematykaBox.Name = "MatematykaBox";
            this.MatematykaBox.Size = new System.Drawing.Size(100, 20);
            this.MatematykaBox.TabIndex = 6;
            this.MatematykaBox.TextChanged += new System.EventHandler(this.MatematykaBox_TextChanged);
            // 
            // SredniaBox
            // 
            this.SredniaBox.Location = new System.Drawing.Point(151, 280);
            this.SredniaBox.Name = "SredniaBox";
            this.SredniaBox.Size = new System.Drawing.Size(100, 20);
            this.SredniaBox.TabIndex = 7;
            this.SredniaBox.TextChanged += new System.EventHandler(this.SredniaBox_TextChanged);
            // 
            // DeutschBox
            // 
            this.DeutschBox.Location = new System.Drawing.Point(151, 215);
            this.DeutschBox.Name = "DeutschBox";
            this.DeutschBox.Size = new System.Drawing.Size(100, 20);
            this.DeutschBox.TabIndex = 8;
            // 
            // PolskiBox
            // 
            this.PolskiBox.Location = new System.Drawing.Point(151, 172);
            this.PolskiBox.Name = "PolskiBox";
            this.PolskiBox.Size = new System.Drawing.Size(100, 20);
            this.PolskiBox.TabIndex = 9;
            // 
            // AngielskiBox
            // 
            this.AngielskiBox.Location = new System.Drawing.Point(151, 126);
            this.AngielskiBox.Name = "AngielskiBox";
            this.AngielskiBox.Size = new System.Drawing.Size(100, 20);
            this.AngielskiBox.TabIndex = 10;
            // 
            // InformatykaBox
            // 
            this.InformatykaBox.Location = new System.Drawing.Point(151, 84);
            this.InformatykaBox.Name = "InformatykaBox";
            this.InformatykaBox.Size = new System.Drawing.Size(100, 20);
            this.InformatykaBox.TabIndex = 11;
            // 
            // PrzeliczButton
            // 
            this.PrzeliczButton.Location = new System.Drawing.Point(151, 251);
            this.PrzeliczButton.Name = "PrzeliczButton";
            this.PrzeliczButton.Size = new System.Drawing.Size(100, 23);
            this.PrzeliczButton.TabIndex = 12;
            this.PrzeliczButton.Text = "Przelicz Średnią";
            this.PrzeliczButton.UseVisualStyleBackColor = true;
            this.PrzeliczButton.Click += new System.EventHandler(this.PrzeliczButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PrzeliczButton);
            this.Controls.Add(this.InformatykaBox);
            this.Controls.Add(this.AngielskiBox);
            this.Controls.Add(this.PolskiBox);
            this.Controls.Add(this.DeutschBox);
            this.Controls.Add(this.SredniaBox);
            this.Controls.Add(this.MatematykaBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MatematykaBox;
        private System.Windows.Forms.TextBox SredniaBox;
        private System.Windows.Forms.TextBox DeutschBox;
        private System.Windows.Forms.TextBox PolskiBox;
        private System.Windows.Forms.TextBox AngielskiBox;
        private System.Windows.Forms.TextBox InformatykaBox;
        private System.Windows.Forms.Button PrzeliczButton;
    }
}

