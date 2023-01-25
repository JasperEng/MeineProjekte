namespace NummernAnzeige
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Stopplabel = new System.Windows.Forms.Label();
            this.uhrLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonZeit = new System.Windows.Forms.Button();
            this.textBoxSetzeZeit = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAlarmAus = new System.Windows.Forms.Button();
            this.buttonWeckerAnAus = new System.Windows.Forms.Button();
            this.buttonSchlummer = new System.Windows.Forms.Button();
            this.buttonSetzeWecker = new System.Windows.Forms.Button();
            this.textBoxWecker = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonStoppReset = new System.Windows.Forms.Button();
            this.buttonStoppAnAus = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Stopplabel);
            this.groupBox1.Controls.Add(this.uhrLabel);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uhr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(131, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Uhr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(504, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stopp Uhr";
            // 
            // Stopplabel
            // 
            this.Stopplabel.AutoSize = true;
            this.Stopplabel.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Stopplabel.Location = new System.Drawing.Point(425, 45);
            this.Stopplabel.Name = "Stopplabel";
            this.Stopplabel.Size = new System.Drawing.Size(288, 72);
            this.Stopplabel.TabIndex = 1;
            this.Stopplabel.Text = "00 : 00 : 00";
            // 
            // uhrLabel
            // 
            this.uhrLabel.AutoSize = true;
            this.uhrLabel.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uhrLabel.Location = new System.Drawing.Point(21, 45);
            this.uhrLabel.Name = "uhrLabel";
            this.uhrLabel.Size = new System.Drawing.Size(288, 72);
            this.uhrLabel.TabIndex = 0;
            this.uhrLabel.Text = "00 : 00 : 00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Alarm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonZeit);
            this.groupBox2.Controls.Add(this.textBoxSetzeZeit);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(12, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 132);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Uhr einstellen";
            // 
            // buttonZeit
            // 
            this.buttonZeit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonZeit.Location = new System.Drawing.Point(175, 22);
            this.buttonZeit.Name = "buttonZeit";
            this.buttonZeit.Size = new System.Drawing.Size(75, 23);
            this.buttonZeit.TabIndex = 1;
            this.buttonZeit.Text = "Setze Zeit";
            this.buttonZeit.UseVisualStyleBackColor = true;
            this.buttonZeit.Click += new System.EventHandler(this.buttonZeit_Click);
            // 
            // textBoxSetzeZeit
            // 
            this.textBoxSetzeZeit.Location = new System.Drawing.Point(6, 23);
            this.textBoxSetzeZeit.Name = "textBoxSetzeZeit";
            this.textBoxSetzeZeit.Size = new System.Drawing.Size(148, 23);
            this.textBoxSetzeZeit.TabIndex = 0;
            this.textBoxSetzeZeit.Text = "00:00:00";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.buttonAlarmAus);
            this.groupBox3.Controls.Add(this.buttonWeckerAnAus);
            this.groupBox3.Controls.Add(this.buttonSchlummer);
            this.groupBox3.Controls.Add(this.buttonSetzeWecker);
            this.groupBox3.Controls.Add(this.textBoxWecker);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(447, 193);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 233);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wecker";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Wecker ist aus";
            // 
            // buttonAlarmAus
            // 
            this.buttonAlarmAus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAlarmAus.Location = new System.Drawing.Point(221, 68);
            this.buttonAlarmAus.Name = "buttonAlarmAus";
            this.buttonAlarmAus.Size = new System.Drawing.Size(92, 58);
            this.buttonAlarmAus.TabIndex = 4;
            this.buttonAlarmAus.Text = "Alarm Aus";
            this.buttonAlarmAus.UseVisualStyleBackColor = true;
            this.buttonAlarmAus.Click += new System.EventHandler(this.buttonAlarmAus_Click);
            // 
            // buttonWeckerAnAus
            // 
            this.buttonWeckerAnAus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWeckerAnAus.Location = new System.Drawing.Point(114, 68);
            this.buttonWeckerAnAus.Name = "buttonWeckerAnAus";
            this.buttonWeckerAnAus.Size = new System.Drawing.Size(92, 58);
            this.buttonWeckerAnAus.TabIndex = 3;
            this.buttonWeckerAnAus.Text = "Wecker An/Aus";
            this.buttonWeckerAnAus.UseVisualStyleBackColor = true;
            this.buttonWeckerAnAus.Click += new System.EventHandler(this.buttonWeckerAnAus_Click);
            // 
            // buttonSchlummer
            // 
            this.buttonSchlummer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSchlummer.Location = new System.Drawing.Point(6, 68);
            this.buttonSchlummer.Name = "buttonSchlummer";
            this.buttonSchlummer.Size = new System.Drawing.Size(92, 58);
            this.buttonSchlummer.TabIndex = 2;
            this.buttonSchlummer.Text = "Schlummer";
            this.buttonSchlummer.UseVisualStyleBackColor = true;
            this.buttonSchlummer.Click += new System.EventHandler(this.buttonSchlummer_Click);
            // 
            // buttonSetzeWecker
            // 
            this.buttonSetzeWecker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSetzeWecker.Location = new System.Drawing.Point(175, 22);
            this.buttonSetzeWecker.Name = "buttonSetzeWecker";
            this.buttonSetzeWecker.Size = new System.Drawing.Size(103, 23);
            this.buttonSetzeWecker.TabIndex = 1;
            this.buttonSetzeWecker.Text = "Setze Wecker";
            this.buttonSetzeWecker.UseVisualStyleBackColor = true;
            this.buttonSetzeWecker.Click += new System.EventHandler(this.buttonSetzeWecker_Click);
            // 
            // textBoxWecker
            // 
            this.textBoxWecker.Location = new System.Drawing.Point(6, 23);
            this.textBoxWecker.Name = "textBoxWecker";
            this.textBoxWecker.Size = new System.Drawing.Size(148, 23);
            this.textBoxWecker.TabIndex = 0;
            this.textBoxWecker.Text = "00:00:00";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonStoppReset);
            this.groupBox4.Controls.Add(this.buttonStoppAnAus);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox4.Location = new System.Drawing.Point(12, 331);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(274, 107);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Stopp Uhr";
            // 
            // buttonStoppReset
            // 
            this.buttonStoppReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStoppReset.Location = new System.Drawing.Point(133, 33);
            this.buttonStoppReset.Name = "buttonStoppReset";
            this.buttonStoppReset.Size = new System.Drawing.Size(117, 54);
            this.buttonStoppReset.TabIndex = 2;
            this.buttonStoppReset.Text = "reset";
            this.buttonStoppReset.UseVisualStyleBackColor = true;
            this.buttonStoppReset.Click += new System.EventHandler(this.buttonStoppReset_Click);
            // 
            // buttonStoppAnAus
            // 
            this.buttonStoppAnAus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStoppAnAus.Location = new System.Drawing.Point(6, 33);
            this.buttonStoppAnAus.Name = "buttonStoppAnAus";
            this.buttonStoppAnAus.Size = new System.Drawing.Size(117, 54);
            this.buttonStoppAnAus.TabIndex = 1;
            this.buttonStoppAnAus.Text = "Stopp Uhr An/Aus";
            this.buttonStoppAnAus.UseVisualStyleBackColor = true;
            this.buttonStoppAnAus.Click += new System.EventHandler(this.buttonStoppAnAus_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Uhr";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label uhrLabel;
        private GroupBox groupBox2;
        private Button buttonZeit;
        private TextBox textBoxSetzeZeit;
        private GroupBox groupBox3;
        private Button buttonSetzeWecker;
        private TextBox textBoxWecker;
        private Label label3;
        private Label label2;
        private Label Stopplabel;
        private Button buttonAlarmAus;
        private Button buttonWeckerAnAus;
        private Button buttonSchlummer;
        private GroupBox groupBox4;
        private Button buttonStoppAnAus;
        private Button buttonStoppReset;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label4;
    }
}