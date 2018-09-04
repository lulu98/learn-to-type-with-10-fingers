using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LearnToType
{
    public partial class EvaluationPage : Form
    {
        Thread th;

        private int correctTypedCounter;
        private int totalTypedCounter;
        private int time;

        public EvaluationPage(int ctc, int ttc, int time)
        {
            InitializeComponent();
            this.correctTypedCounter = ctc;
            this.totalTypedCounter = ttc;
            this.time = time;
        }

        private void EvaluationPage_Load(object sender, EventArgs e)
        {
            setTextBox();
            setChart();
        }

        private void setTextBox()
        {
            string finalData = "Total amount of Characters:\t\t" + totalTypedCounter +
                "\nCorrect Typed Characters:\t\t" + correctTypedCounter +
                "\nWrong Typed Characters:\t\t" + (totalTypedCounter - correctTypedCounter) +
                "\nFailure Rate:\t\t\t" + (Math.Round((((double)(totalTypedCounter - correctTypedCounter)) / ((double)totalTypedCounter)) * 100, 2)).ToString() + " %" +
                "\nTime:\t\t\t\t" + time + " s";
            typingDataBox.Text = finalData;
        }

        private void setChart()
        {
            typingDataChart.Series["TypingData"].Points.AddXY("Total",totalTypedCounter);
            typingDataChart.Series["TypingData"].Points.AddXY("Correct", correctTypedCounter);
            typingDataChart.Series["TypingData"].Points.AddXY("Wrong", (totalTypedCounter - correctTypedCounter));
        }

        private void openTypingChallengePage(object obj)
        {
            Application.Run(new Form1());
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            th = new Thread(openTypingChallengePage);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        private void openStartingPage(object obj)
        {
            Application.Run(new StartingPage());
        }

        private void btnReturnToMainMenu_Click(object sender, EventArgs e)
        {
            th = new Thread(openStartingPage);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }
    }
}
