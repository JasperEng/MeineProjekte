namespace ParkhausProjekt
{
    partial class ParkautomatForms
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.parkDauerTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBetrag = new System.Windows.Forms.TextBox();
            this.textBoxAktuBetrag = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button20cent = new System.Windows.Forms.Button();
            this.button50cent = new System.Windows.Forms.Button();
            this.button1eur = new System.Windows.Forms.Button();
            this.button2eur = new System.Windows.Forms.Button();
            this.buttonRechnen = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parkdauer:";
            // 
            // parkDauerTextBox
            // 
            this.parkDauerTextBox.Location = new System.Drawing.Point(85, 6);
            this.parkDauerTextBox.Name = "parkDauerTextBox";
            this.parkDauerTextBox.Size = new System.Drawing.Size(100, 23);
            this.parkDauerTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kosten:";
            // 
            // textBoxBetrag
            // 
            this.textBoxBetrag.Location = new System.Drawing.Point(85, 38);
            this.textBoxBetrag.Name = "textBoxBetrag";
            this.textBoxBetrag.Size = new System.Drawing.Size(100, 23);
            this.textBoxBetrag.TabIndex = 3;
            // 
            // textBoxAktuBetrag
            // 
            this.textBoxAktuBetrag.Location = new System.Drawing.Point(62, 79);
            this.textBoxAktuBetrag.Name = "textBoxAktuBetrag";
            this.textBoxAktuBetrag.Size = new System.Drawing.Size(214, 23);
            this.textBoxAktuBetrag.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Betrag:";
            // 
            // button20cent
            // 
            this.button20cent.Location = new System.Drawing.Point(44, 202);
            this.button20cent.Name = "button20cent";
            this.button20cent.Size = new System.Drawing.Size(75, 23);
            this.button20cent.TabIndex = 8;
            this.button20cent.Text = "20 Cent";
            this.button20cent.UseVisualStyleBackColor = true;
            this.button20cent.Click += new System.EventHandler(this.button20cent_Click);
            // 
            // button50cent
            // 
            this.button50cent.Location = new System.Drawing.Point(155, 202);
            this.button50cent.Name = "button50cent";
            this.button50cent.Size = new System.Drawing.Size(75, 23);
            this.button50cent.TabIndex = 9;
            this.button50cent.Text = "50 Cent";
            this.button50cent.UseVisualStyleBackColor = true;
            this.button50cent.Click += new System.EventHandler(this.button50cent_Click);
            // 
            // button1eur
            // 
            this.button1eur.Location = new System.Drawing.Point(44, 259);
            this.button1eur.Name = "button1eur";
            this.button1eur.Size = new System.Drawing.Size(75, 23);
            this.button1eur.TabIndex = 10;
            this.button1eur.Text = "1€";
            this.button1eur.UseVisualStyleBackColor = true;
            this.button1eur.Click += new System.EventHandler(this.button1eur_Click);
            // 
            // button2eur
            // 
            this.button2eur.Location = new System.Drawing.Point(155, 259);
            this.button2eur.Name = "button2eur";
            this.button2eur.Size = new System.Drawing.Size(75, 23);
            this.button2eur.TabIndex = 11;
            this.button2eur.Text = "2€";
            this.button2eur.UseVisualStyleBackColor = true;
            this.button2eur.Click += new System.EventHandler(this.button2eur_Click);
            // 
            // buttonRechnen
            // 
            this.buttonRechnen.Location = new System.Drawing.Point(62, 158);
            this.buttonRechnen.Name = "buttonRechnen";
            this.buttonRechnen.Size = new System.Drawing.Size(152, 23);
            this.buttonRechnen.TabIndex = 12;
            this.buttonRechnen.Text = "Kosten berechnen";
            this.buttonRechnen.UseVisualStyleBackColor = true;
            this.buttonRechnen.Click += new System.EventHandler(this.buttonRechnen_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Geschäftskunde",
            "Privatkunde"});
            this.comboBox1.Location = new System.Drawing.Point(64, 118);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Kunde";
            // 
            // ParkautomatForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 355);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonRechnen);
            this.Controls.Add(this.button2eur);
            this.Controls.Add(this.button1eur);
            this.Controls.Add(this.button50cent);
            this.Controls.Add(this.button20cent);
            this.Controls.Add(this.textBoxAktuBetrag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxBetrag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.parkDauerTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ParkautomatForms";
            this.Text = "Automat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox parkDauerTextBox;
        private Label label2;
        private TextBox textBoxBetrag;
        private TextBox textBoxAktuBetrag;
        private Label label3;
        private Button button20cent;
        private Button button50cent;
        private Button button1eur;
        private Button button2eur;
        private Button buttonRechnen;
        private ComboBox comboBox1;
        private Label label4;
    }
}