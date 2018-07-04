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
            this.GB1 = new System.Windows.Forms.GroupBox();
            this.resistenceRB = new System.Windows.Forms.RadioButton();
            this.currentRB = new System.Windows.Forms.RadioButton();
            this.voltageRB = new System.Windows.Forms.RadioButton();
            this.VoltL1 = new System.Windows.Forms.Label();
            this.VoltageGB = new System.Windows.Forms.GroupBox();
            this.calcVoltage = new System.Windows.Forms.Button();
            this.voltageR = new System.Windows.Forms.TextBox();
            this.VoltL4 = new System.Windows.Forms.Label();
            this.VoltL3 = new System.Windows.Forms.Label();
            this.voltageI = new System.Windows.Forms.TextBox();
            this.VoltL2 = new System.Windows.Forms.Label();
            this.AnswerGB = new System.Windows.Forms.GroupBox();
            this.answerL = new System.Windows.Forms.Label();
            this.CurrentGB = new System.Windows.Forms.GroupBox();
            this.calcCurrent = new System.Windows.Forms.Button();
            this.currentR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.currentV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ResistenceGB = new System.Windows.Forms.GroupBox();
            this.calcResistence = new System.Windows.Forms.Button();
            this.resistenceI = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.resistenceV = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.GB1.SuspendLayout();
            this.VoltageGB.SuspendLayout();
            this.AnswerGB.SuspendLayout();
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
            // GB1
            // 
            this.GB1.Controls.Add(this.resistenceRB);
            this.GB1.Controls.Add(this.currentRB);
            this.GB1.Controls.Add(this.voltageRB);
            this.GB1.Location = new System.Drawing.Point(12, 78);
            this.GB1.Name = "GB1";
            this.GB1.Size = new System.Drawing.Size(265, 60);
            this.GB1.TabIndex = 1;
            this.GB1.TabStop = false;
            this.GB1.Text = "Calculate";
            // 
            // resistenceRB
            // 
            this.resistenceRB.AutoSize = true;
            this.resistenceRB.Location = new System.Drawing.Point(174, 20);
            this.resistenceRB.Name = "resistenceRB";
            this.resistenceRB.Size = new System.Drawing.Size(78, 17);
            this.resistenceRB.TabIndex = 2;
            this.resistenceRB.TabStop = true;
            this.resistenceRB.Text = "Resistence";
            this.resistenceRB.UseVisualStyleBackColor = true;
            this.resistenceRB.CheckedChanged += new System.EventHandler(this.ResistenceRBClicked);
            // 
            // currentRB
            // 
            this.currentRB.AutoSize = true;
            this.currentRB.Location = new System.Drawing.Point(87, 20);
            this.currentRB.Name = "currentRB";
            this.currentRB.Size = new System.Drawing.Size(59, 17);
            this.currentRB.TabIndex = 1;
            this.currentRB.TabStop = true;
            this.currentRB.Text = "Current";
            this.currentRB.UseVisualStyleBackColor = true;
            this.currentRB.CheckedChanged += new System.EventHandler(this.CurrentRBClicked);
            // 
            // voltageRB
            // 
            this.voltageRB.AutoSize = true;
            this.voltageRB.Location = new System.Drawing.Point(7, 20);
            this.voltageRB.Name = "voltageRB";
            this.voltageRB.Size = new System.Drawing.Size(61, 17);
            this.voltageRB.TabIndex = 0;
            this.voltageRB.TabStop = true;
            this.voltageRB.Text = "Voltage";
            this.voltageRB.UseVisualStyleBackColor = true;
            this.voltageRB.CheckedChanged += new System.EventHandler(this.VoltageRBClicked);
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
            this.VoltageGB.Controls.Add(this.calcVoltage);
            this.VoltageGB.Controls.Add(this.voltageR);
            this.VoltageGB.Controls.Add(this.VoltL4);
            this.VoltageGB.Controls.Add(this.VoltL3);
            this.VoltageGB.Controls.Add(this.voltageI);
            this.VoltageGB.Controls.Add(this.VoltL2);
            this.VoltageGB.Controls.Add(this.VoltL1);
            this.VoltageGB.Location = new System.Drawing.Point(300, 201);
            this.VoltageGB.Name = "VoltageGB";
            this.VoltageGB.Size = new System.Drawing.Size(265, 77);
            this.VoltageGB.TabIndex = 4;
            this.VoltageGB.TabStop = false;
            this.VoltageGB.Text = "Substitute for the Formula";
            // 
            // calcVoltage
            // 
            this.calcVoltage.Location = new System.Drawing.Point(191, 34);
            this.calcVoltage.Name = "calcVoltage";
            this.calcVoltage.Size = new System.Drawing.Size(71, 23);
            this.calcVoltage.TabIndex = 27;
            this.calcVoltage.Text = "Calculate";
            this.calcVoltage.UseVisualStyleBackColor = true;
            this.calcVoltage.Click += new System.EventHandler(this.calcVoltage_Click);
            // 
            // voltageR
            // 
            this.voltageR.Location = new System.Drawing.Point(134, 36);
            this.voltageR.Name = "voltageR";
            this.voltageR.Size = new System.Drawing.Size(32, 20);
            this.voltageR.TabIndex = 8;
            this.voltageR.Text = " ";
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
            // voltageI
            // 
            this.voltageI.Location = new System.Drawing.Point(74, 36);
            this.voltageI.Name = "voltageI";
            this.voltageI.Size = new System.Drawing.Size(32, 20);
            this.voltageI.TabIndex = 5;
            this.voltageI.Text = " ";
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
            // AnswerGB
            // 
            this.AnswerGB.Controls.Add(this.answerL);
            this.AnswerGB.Location = new System.Drawing.Point(12, 227);
            this.AnswerGB.Name = "AnswerGB";
            this.AnswerGB.Size = new System.Drawing.Size(265, 51);
            this.AnswerGB.TabIndex = 5;
            this.AnswerGB.TabStop = false;
            this.AnswerGB.Text = "Answer";
            // 
            // answerL
            // 
            this.answerL.AutoSize = true;
            this.answerL.Location = new System.Drawing.Point(15, 25);
            this.answerL.Name = "answerL";
            this.answerL.Size = new System.Drawing.Size(0, 13);
            this.answerL.TabIndex = 0;
            // 
            // CurrentGB
            // 
            this.CurrentGB.Controls.Add(this.calcCurrent);
            this.CurrentGB.Controls.Add(this.currentR);
            this.CurrentGB.Controls.Add(this.label6);
            this.CurrentGB.Controls.Add(this.label7);
            this.CurrentGB.Controls.Add(this.currentV);
            this.CurrentGB.Controls.Add(this.label8);
            this.CurrentGB.Controls.Add(this.label13);
            this.CurrentGB.Location = new System.Drawing.Point(299, 23);
            this.CurrentGB.Name = "CurrentGB";
            this.CurrentGB.Size = new System.Drawing.Size(265, 77);
            this.CurrentGB.TabIndex = 28;
            this.CurrentGB.TabStop = false;
            this.CurrentGB.Text = "Substitute for the Formula";
            // 
            // calcCurrent
            // 
            this.calcCurrent.Location = new System.Drawing.Point(191, 34);
            this.calcCurrent.Name = "calcCurrent";
            this.calcCurrent.Size = new System.Drawing.Size(71, 23);
            this.calcCurrent.TabIndex = 27;
            this.calcCurrent.Text = "Calculate";
            this.calcCurrent.UseVisualStyleBackColor = true;
            this.calcCurrent.Click += new System.EventHandler(this.calcCurrent_Click);
            // 
            // currentR
            // 
            this.currentR.Location = new System.Drawing.Point(74, 52);
            this.currentR.Name = "currentR";
            this.currentR.Size = new System.Drawing.Size(32, 20);
            this.currentR.TabIndex = 18;
            this.currentR.Text = " ";
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
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "(V)";
            // 
            // currentV
            // 
            this.currentV.Location = new System.Drawing.Point(74, 23);
            this.currentV.Name = "currentV";
            this.currentV.Size = new System.Drawing.Size(32, 20);
            this.currentV.TabIndex = 11;
            this.currentV.Text = " ";
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
            this.ResistenceGB.Controls.Add(this.calcResistence);
            this.ResistenceGB.Controls.Add(this.resistenceI);
            this.ResistenceGB.Controls.Add(this.label9);
            this.ResistenceGB.Controls.Add(this.label10);
            this.ResistenceGB.Controls.Add(this.resistenceV);
            this.ResistenceGB.Controls.Add(this.label11);
            this.ResistenceGB.Controls.Add(this.label12);
            this.ResistenceGB.Location = new System.Drawing.Point(299, 117);
            this.ResistenceGB.Name = "ResistenceGB";
            this.ResistenceGB.Size = new System.Drawing.Size(265, 77);
            this.ResistenceGB.TabIndex = 29;
            this.ResistenceGB.TabStop = false;
            this.ResistenceGB.Text = "Substitute for the Formula";
            // 
            // calcResistence
            // 
            this.calcResistence.Location = new System.Drawing.Point(191, 34);
            this.calcResistence.Name = "calcResistence";
            this.calcResistence.Size = new System.Drawing.Size(71, 23);
            this.calcResistence.TabIndex = 27;
            this.calcResistence.Text = "Calculate";
            this.calcResistence.UseVisualStyleBackColor = true;
            this.calcResistence.Click += new System.EventHandler(this.calcResistence_Click);
            // 
            // resistenceI
            // 
            this.resistenceI.Location = new System.Drawing.Point(93, 51);
            this.resistenceI.Name = "resistenceI";
            this.resistenceI.Size = new System.Drawing.Size(32, 20);
            this.resistenceI.TabIndex = 24;
            this.resistenceI.Text = " ";
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
            // resistenceV
            // 
            this.resistenceV.Location = new System.Drawing.Point(93, 22);
            this.resistenceV.Name = "resistenceV";
            this.resistenceV.Size = new System.Drawing.Size(32, 20);
            this.resistenceV.TabIndex = 20;
            this.resistenceV.Text = " ";
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
            this.ClientSize = new System.Drawing.Size(576, 284);
            this.Controls.Add(this.ResistenceGB);
            this.Controls.Add(this.CurrentGB);
            this.Controls.Add(this.AnswerGB);
            this.Controls.Add(this.VoltageGB);
            this.Controls.Add(this.GB1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Oms\' Law Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GB1.ResumeLayout(false);
            this.GB1.PerformLayout();
            this.VoltageGB.ResumeLayout(false);
            this.VoltageGB.PerformLayout();
            this.AnswerGB.ResumeLayout(false);
            this.AnswerGB.PerformLayout();
            this.CurrentGB.ResumeLayout(false);
            this.CurrentGB.PerformLayout();
            this.ResistenceGB.ResumeLayout(false);
            this.ResistenceGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GB1;
        private System.Windows.Forms.RadioButton resistenceRB;
        private System.Windows.Forms.RadioButton currentRB;
        private System.Windows.Forms.RadioButton voltageRB;
        private System.Windows.Forms.Label VoltL1;
        private System.Windows.Forms.GroupBox VoltageGB;
        private System.Windows.Forms.TextBox voltageR;
        private System.Windows.Forms.Label VoltL4;
        private System.Windows.Forms.Label VoltL3;
        private System.Windows.Forms.TextBox voltageI;
        private System.Windows.Forms.Label VoltL2;
        private System.Windows.Forms.GroupBox AnswerGB;
        private System.Windows.Forms.Label answerL;
        private System.Windows.Forms.Button calcVoltage;
        private System.Windows.Forms.GroupBox CurrentGB;
        private System.Windows.Forms.Button calcCurrent;
        private System.Windows.Forms.TextBox currentR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox currentV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox ResistenceGB;
        private System.Windows.Forms.Button calcResistence;
        private System.Windows.Forms.TextBox resistenceI;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox resistenceV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

