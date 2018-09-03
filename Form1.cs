using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace LearnToType
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        string connectionString;
        Thread th;

        private int correctTypedCounter;
        private int totalTypedCounter;
        Random rand = null;
        private int timeLeft = 0;
        private const int maxTime = 20;
        SoundPlayer mySound = null;
        
        public Form1()
        {
            InitializeComponent();
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Projects\\Visual Studio\\LearnToType\\LearnToType\\TypingData.mdf;Integrated Security=True";
            mySound = new SoundPlayer("C:\\Projects\\Visual Studio\\LearnToType\\keyBoardClick.mp3");
            rand = new Random();
            this.KeyPreview = true;
            headingLabel.Focus();
        }

        private void resetPage()
        {
            correctTypedCounter = 0;
            totalTypedCounter = 0;

            secondLeftCharacterBox.Text = "";
            firstLeftCharacterBox.Text = "";
            middleCharacterBox.Text = "";
            firstRightCharacterBox.Text = "";
            secondRightCharacterBox.Text = "";
            //middleCharacterBox.Text = createRandomCharacter().ToString();
            firstRightCharacterBox.Text = createRandomCharacter().ToString();
            secondRightCharacterBox.Text = createRandomCharacter().ToString();

            setTimeProperties();
            updateDisplayInformation();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resetPage();
        }

        private void updateDisplayInformation()
        {
            amountTotalTypedBox.Text = totalTypedCounter.ToString();
            amountCorrectTypedBox.Text = correctTypedCounter.ToString() + " / " + totalTypedCounter.ToString();
            percentageWrongTypedBox.Text = (Math.Round((((double)(totalTypedCounter - correctTypedCounter)) / ((double)totalTypedCounter)) * 100, 2)).ToString() + "%";

            secondLeftCharacterBox.Text = firstLeftCharacterBox.Text;
            firstLeftCharacterBox.Text = middleCharacterBox.Text;
            middleCharacterBox.Text = firstRightCharacterBox.Text;
            firstRightCharacterBox.Text = secondRightCharacterBox.Text;
            secondRightCharacterBox.Text = createRandomCharacter().ToString();
            
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM FingerPosition", connection))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    if (middleCharacterBox.Text.Equals(Convert.ToChar(dataRow["KeyBoardKey"]).ToString()))
                    {
                        fingerAdviceBox.Text = dataRow["Finger"].ToString();
                    }
                }
            }
        }
        
        private char createRandomCharacter()
        {
            int randInt = rand.Next(32,127);
            char nextChar = (char)randInt;
            if (nextChar.Equals((char)32))
            {
                nextChar = (char)65096;
            }
            return nextChar;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Enabled = true;
                timer1.Start();
            }
            totalTypedCounter++;
            
            if (e.KeyChar.ToString().Equals(middleCharacterBox.Text))
            {
                correctTypedCounter++;
            }
            if (middleCharacterBox.Text.Equals(((char)65096).ToString()))
            {
                if (e.KeyChar.ToString().Equals(((char)32).ToString()))
                {
                    correctTypedCounter++;
                }
            }
            mySound.playSound();
            updateDisplayInformation();
        }
        
        private void setTimeProperties()
        {
            timeLeft = maxTime;
            timeBox.Text = timeLeft + " s";
            //timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                // Display the new time left
                timeLeft = timeLeft - 1;
                timeBox.Text = timeLeft + " s";
            }
            else
            {
                timer1.Stop();
                timer1.Enabled = false;
                btnEvaluateTyping_Click(btnEvaluateTyping, EventArgs.Empty);
            }
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            resetPage();
            headingLabel.Focus();
        }

        private void openEvaluationPage(object obj)
        {
            EvaluationPage newPage = new EvaluationPage(correctTypedCounter,totalTypedCounter,maxTime-timeLeft);
            Application.Run(newPage);
        }

        private void btnEvaluateTyping_Click(object sender, EventArgs e)
        {
            th = new Thread(openEvaluationPage);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            timer1.Dispose();
        }
    }
}
