namespace OmsLawCalculator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.VoltL1 = new System.Windows.Forms.Label();
            this.VoltageGB = new System.Windows.Forms.GroupBox();
            this.VoltTB2 = new System.Windows.Forms.TextBox();
            this.VoltL4 = new System.Windows.Forms.Label();
            this.VoltL3 = new System.Windows.Forms.Label();
            this.VoltTB1 = new System.Windows.Forms.TextBox();
            this.VoltL2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.CurrentGB = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ResistenceGB = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.VoltageGB.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.CurrentGB.SuspendLayout();
            this.ResistenceGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Formula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "V = IR         V=Voltage  I=Current  R=Resistence";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(12, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 60);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculate";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(174, 20);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(78, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Resistence";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(87, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Current";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Voltage";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // VoltL1
            // 
            this.VoltL1.AutoSize = true;
            this.VoltL1.Location = new System.Drawing.Point(15, 40);
            this.VoltL1.Name = "VoltL1";
            this.VoltL1.Size = new System.Drawing.Size(52, 13);
            this.VoltL1.TabIndex = 3;
            this.VoltL1.Text = "Voltage =";
            // 
            // VoltageGB
            // 
            this.VoltageGB.Controls.Add(this.CalculateBtn);
            this.VoltageGB.Controls.Add(this.VoltTB2);
            this.VoltageGB.Controls.Add(this.VoltL4);
            this.VoltageGB.Controls.Add(this.VoltL3);
            this.VoltageGB.Controls.Add(this.VoltTB1);
            this.VoltageGB.Controls.Add(this.VoltL2);
            this.VoltageGB.Controls.Add(this.VoltL1);
            this.VoltageGB.Location = new System.Drawing.Point(12, 144);
            this.VoltageGB.Name = "VoltageGB";
            this.VoltageGB.Size = new System.Drawing.Size(265, 77);
            this.VoltageGB.TabIndex = 4;
            this.VoltageGB.TabStop = false;
            this.VoltageGB.Text = "Substitute for the Formula";
            // 
            // VoltTB2
            // 
            this.VoltTB2.Location = new System.Drawing.Point(134, 36);
            this.VoltTB2.Name = "VoltTB2";
            this.VoltTB2.Size = new System.Drawing.Size(32, 20);
            this.VoltTB2.TabIndex = 8;
            this.VoltTB2.Text = " ";
            // 
            // VoltL4
            // 
            this.VoltL4.AutoSize = true;
            this.VoltL4.Location = new System.Drawing.Point(166, 40);
            this.VoltL4.Name = "VoltL4";
            this.VoltL4.Size = new System.Drawing.Size(21, 13);
            this.VoltL4.TabIndex = 7;
            this.VoltL4.Text = "(R)";
            // 
            // VoltL3
            // 
            this.VoltL3.AutoSize = true;
            this.VoltL3.Location = new System.Drawing.Point(118, 41);
            this.VoltL3.Name = "VoltL3";
            this.VoltL3.Size = new System.Drawing.Size(14, 13);
            this.VoltL3.TabIndex = 6;
            this.VoltL3.Text = "X";
            // 
            // VoltTB1
            // 
            this.VoltTB1.Location = new System.Drawing.Point(74, 36);
            this.VoltTB1.Name = "VoltTB1";
            this.VoltTB1.Size = new System.Drawing.Size(32, 20);
            this.VoltTB1.TabIndex = 5;
            this.VoltTB1.Text = " ";
            // 
            // VoltL2
            // 
            this.VoltL2.AutoSize = true;
            this.VoltL2.Location = new System.Drawing.Point(106, 40);
            this.VoltL2.Name = "VoltL2";
            this.VoltL2.Size = new System.Drawing.Size(16, 13);
            this.VoltL2.TabIndex = 4;
            this.VoltL2.Text = "(I)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(12, 227);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(265, 51);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Answer";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "label14";
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(192, 34);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(71, 23);
            this.CalculateBtn.TabIndex = 27;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            // 
            // CurrentGB
            // 
            this.CurrentGB.Controls.Add(this.button1);
            this.CurrentGB.Controls.Add(this.textBox3);
            this.CurrentGB.Controls.Add(this.label6);
            this.CurrentGB.Controls.Add(this.label7);
            this.CurrentGB.Controls.Add(this.textBox4);
            this.CurrentGB.Controls.Add(this.label8);
            this.CurrentGB.Controls.Add(this.label13);
            this.CurrentGB.Location = new System.Drawing.Point(283, 23);
            this.CurrentGB.Name = "CurrentGB";
            this.CurrentGB.Size = new System.Drawing.Size(265, 77);
            this.CurrentGB.TabIndex = 28;
            this.CurrentGB.TabStop = false;
            this.CurrentGB.Text = "Substitute for the Formula";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(74, 52);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(32, 20);
            this.textBox3.TabIndex = 18;
            this.textBox3.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "(R)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "(I)";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(74, 23);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(32, 20);
            this.textBox4.TabIndex = 11;
            this.textBox4.Text = " ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Current =";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(66, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "_______";
            // 
            // ResistenceGB
            // 
            this.ResistenceGB.Controls.Add(this.button2);
            this.ResistenceGB.Controls.Add(this.textBox5);
            this.ResistenceGB.Controls.Add(this.label9);
            this.ResistenceGB.Controls.Add(this.label10);
            this.ResistenceGB.Controls.Add(this.textBox6);
            this.ResistenceGB.Controls.Add(this.label11);
            this.ResistenceGB.Controls.Add(this.label12);
            this.ResistenceGB.Location = new System.Drawing.Point(283, 117);
            this.ResistenceGB.Name = "ResistenceGB";
            this.ResistenceGB.Size = new System.Drawing.Size(265, 77);
            this.ResistenceGB.TabIndex = 29;
            this.ResistenceGB.TabStop = false;
            this.ResistenceGB.Text = "Substitute for the Formula";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(156, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(93, 51);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(32, 20);
            this.textBox5.TabIndex = 24;
            this.textBox5.Text = " ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(125, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "(I)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(125, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "(V)";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(93, 22);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(32, 20);
            this.textBox6.TabIndex = 20;
            this.textBox6.Text = " ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Resistence =";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(85, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "_______";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 285);
            this.Controls.Add(this.ResistenceGB);
            this.Controls.Add(this.CurrentGB);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.VoltageGB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Oms\' Law Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.VoltageGB.ResumeLayout(false);
            this.VoltageGB.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.CurrentGB.ResumeLayout(false);
            this.CurrentGB.PerformLayout();
            this.ResistenceGB.ResumeLayout(false);
            this.ResistenceGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label VoltL1;
        private System.Windows.Forms.GroupBox VoltageGB;
        private System.Windows.Forms.TextBox VoltTB2;
        private System.Windows.Forms.Label VoltL4;
        private System.Windows.Forms.Label VoltL3;
        private System.Windows.Forms.TextBox VoltTB1;
        private System.Windows.Forms.Label VoltL2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.GroupBox CurrentGB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox ResistenceGB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

