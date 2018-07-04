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
            float answer;
            //int voltage = Convert.ToInt32(currentV.Text);
            //int resistence = Convert.ToInt32(currentR.Text);

            //answer = voltage / resistence;
            //answer.ToString("n3");
            ShowAnswerGB();
        }

        private void ShowAnswerGB()
        {
            AnswerGB.Show();
            this.Size = new Size(305, 323);
        }
    }
}
