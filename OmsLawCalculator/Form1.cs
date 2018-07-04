using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OmsLawCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RBAutoCheckFalse();
            HideComponents();
        }
        
        private void HideComponents()
        {
            VoltageGB.Hide();
            CurrentGB.Hide();
            ResistenceGB.Hide();
            AnswerGB.Hide();
            RBAutoCheckTrue();
            this.Size = new Size(305, 181);
        }

        private void CurrentRBClicked(object sender, EventArgs e)
        {
            VoltageGB.Hide();
            ResistenceGB.Hide();
            CurrentGB.Location = new Point(12, 144);
            CurrentGB.Show();
            this.Size = new Size(305, 267);
        }

        private void ResistenceRBClicked(object sender, EventArgs e)
        {
            VoltageGB.Hide();
            CurrentGB.Hide();
            ResistenceGB.Location = new Point(12, 144);
            ResistenceGB.Show();
            this.Size = new Size(305, 267);
        }

        private void VoltageRBClicked(object sender, EventArgs e)
        {
            CurrentGB.Hide();
            ResistenceGB.Hide();
            VoltageGB.Location = new Point(12, 144);
            VoltageGB.Show();
            this.Size = new Size(305, 267);
        }

        private void RBAutoCheckTrue()
        {
            voltageRB.AutoCheck = true;
            resistenceRB.AutoCheck = true;
            currentRB.AutoCheck = true;
        }

        private void RBAutoCheckFalse()
        {
            voltageRB.AutoCheck = false;
            resistenceRB.AutoCheck = false;
            currentRB.AutoCheck = false;
        }

        private void calcCurrent_Click(object sender, EventArgs e)
        {
            Double answer;
            Double voltage;
            Double resistence;

            voltage = Convert.ToDouble(currentV.Text);
            resistence = Convert.ToDouble(currentR.Text);

            answer = voltage / resistence;
            string displayAns = "Current = " + answer.ToString("N3") + "A";
            ShowAnswerGB(displayAns);
            Console.WriteLine(answer);
        }

        private void calcVoltage_Click(object sender, EventArgs e)
        {
            Double answer;
            Double current;
            Double resistence;

            current = Convert.ToDouble(voltageI.Text);
            resistence = Convert.ToDouble(voltageR.Text);

            answer = current * resistence;
            answer.ToString("n3");
            string displayAns = "Voltage = " + answer.ToString("N3") + "V";
            ShowAnswerGB(displayAns);
            Console.WriteLine(answer);
        }

        private void calcResistence_Click(object sender, EventArgs e)
        {
            Double answer;
            Double voltage;
            Double current;

            voltage = Convert.ToDouble(resistenceV.Text);
            current = Convert.ToDouble(resistenceI.Text);

            answer = voltage / current;
            answer.ToString("n2");
            string displayAns = "Resistence = " + answer.ToString("N3") + "Ω";
            ShowAnswerGB(displayAns);
            Console.WriteLine(answer);
        }

        private void ShowAnswerGB(String vir)
        {
            AnswerGB.Show();
            this.Size = new Size(305, 323);
            answerL.Text = vir;
        }
    }
}
