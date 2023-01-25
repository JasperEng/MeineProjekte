namespace KontoProjekt
{
    partial class KontoForms
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
            this.kontostandLabel = new System.Windows.Forms.TextBox();
            this.betragLabel = new System.Windows.Forms.TextBox();
            this.einzahlenButton = new System.Windows.Forms.Button();
            this.auszahlenButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kontoNRLabel = new System.Windows.Forms.Label();
            this.KontoNrTextBox = new System.Windows.Forms.TextBox();
            this.auszugButton = new System.Windows.Forms.Button();
            this.auszugTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // kontostandLabel
            // 
            this.kontostandLabel.Location = new System.Drawing.Point(111, 33);
            this.kontostandLabel.Name = "kontostandLabel";
            this.kontostandLabel.Size = new System.Drawing.Size(100, 23);
            this.kontostandLabel.TabIndex = 1;
            // 
            // betragLabel
            // 
            this.betragLabel.Location = new System.Drawing.Point(111, 62);
            this.betragLabel.Name = "betragLabel";
            this.betragLabel.Size = new System.Drawing.Size(100, 23);
            this.betragLabel.TabIndex = 2;
            // 
            // einzahlenButton
            // 
            this.einzahlenButton.Location = new System.Drawing.Point(12, 120);
            this.einzahlenButton.Name = "einzahlenButton";
            this.einzahlenButton.Size = new System.Drawing.Size(75, 23);
            this.einzahlenButton.TabIndex = 3;
            this.einzahlenButton.Text = "Einzahlen";
            this.einzahlenButton.UseVisualStyleBackColor = true;
            this.einzahlenButton.Click += new System.EventHandler(this.einzahlenButton_Click);
            // 
            // auszahlenButton
            // 
            this.auszahlenButton.Location = new System.Drawing.Point(102, 120);
            this.auszahlenButton.Name = "auszahlenButton";
            this.auszahlenButton.Size = new System.Drawing.Size(75, 23);
            this.auszahlenButton.TabIndex = 4;
            this.auszahlenButton.Text = "Auszahlen";
            this.auszahlenButton.UseVisualStyleBackColor = true;
            this.auszahlenButton.Click += new System.EventHandler(this.auszahlenButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Betrag:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kontostand:";
            // 
            // kontoNRLabel
            // 
            this.kontoNRLabel.AutoSize = true;
            this.kontoNRLabel.Location = new System.Drawing.Point(12, 9);
            this.kontoNRLabel.Name = "kontoNRLabel";
            this.kontoNRLabel.Size = new System.Drawing.Size(93, 15);
            this.kontoNRLabel.TabIndex = 7;
            this.kontoNRLabel.Text = "Konto Nummer:";
            // 
            // KontoNrTextBox
            // 
            this.KontoNrTextBox.Location = new System.Drawing.Point(111, 6);
            this.KontoNrTextBox.Name = "KontoNrTextBox";
            this.KontoNrTextBox.Size = new System.Drawing.Size(100, 23);
            this.KontoNrTextBox.TabIndex = 6;
            // 
            // auszugButton
            // 
            this.auszugButton.Location = new System.Drawing.Point(192, 120);
            this.auszugButton.Name = "auszugButton";
            this.auszugButton.Size = new System.Drawing.Size(75, 23);
            this.auszugButton.TabIndex = 8;
            this.auszugButton.Text = "Auszug";
            this.auszugButton.UseVisualStyleBackColor = true;
            this.auszugButton.Click += new System.EventHandler(this.auszugButton_Click);
            // 
            // auszugTextBox
            // 
            this.auszugTextBox.Location = new System.Drawing.Point(5, 160);
            this.auszugTextBox.Name = "auszugTextBox";
            this.auszugTextBox.Size = new System.Drawing.Size(262, 23);
            this.auszugTextBox.TabIndex = 9;
            // 
            // KontoForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 192);
            this.Controls.Add(this.auszugTextBox);
            this.Controls.Add(this.auszugButton);
            this.Controls.Add(this.kontoNRLabel);
            this.Controls.Add(this.KontoNrTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.auszahlenButton);
            this.Controls.Add(this.einzahlenButton);
            this.Controls.Add(this.betragLabel);
            this.Controls.Add(this.kontostandLabel);
            this.Controls.Add(this.label1);
            this.Name = "KontoForms";
            this.Text = "Konto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox kontostandLabel;
        private TextBox betragLabel;
        private Button einzahlenButton;
        private Button auszahlenButton;
        private Label label2;
        private Label label1;
        private Label kontoNRLabel;
        private TextBox KontoNrTextBox;
        private Button auszugButton;
        private TextBox auszugTextBox;
    }
}