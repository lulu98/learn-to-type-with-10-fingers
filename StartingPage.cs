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
    public partial class StartingPage : Form
    {
        List<string> choices = null;
        Thread th;

        public StartingPage()
        {
            InitializeComponent();
        }

        private void StartingPage_Load(object sender, EventArgs e)
        {
            choices = new List<string>();
            choices.Add("15");
            choices.Add("30");
            choices.Add("45");
            choices.Add("60");
            choices.Add("75");
            choices.Add("90");
            choices.Add("105");
            choices.Add("120");
            dropDownList.Items.AddRange(choices.ToArray());
        }

        private void openTypingPage(object obj)
        {
            Form1 newPage = new Form1();
            newPage.setTime(Convert.ToInt32(dropDownList.SelectedItem));
            Application.Run(newPage);
        }

        private void btnStartTyping_Click(object sender, EventArgs e)
        {
            th = new Thread(openTypingPage);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        private void btnCloseApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
