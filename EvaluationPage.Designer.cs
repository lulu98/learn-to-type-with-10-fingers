namespace LearnToType
{
    partial class EvaluationPage
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.typingDataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.typingDataBox = new System.Windows.Forms.RichTextBox();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.typingDataChart)).BeginInit();
            this.SuspendLayout();
            // 
            // typingDataChart
            // 
            chartArea1.Name = "ChartArea1";
            this.typingDataChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.typingDataChart.Legends.Add(legend1);
            this.typingDataChart.Location = new System.Drawing.Point(324, 124);
            this.typingDataChart.Name = "typingDataChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "TypingData";
            this.typingDataChart.Series.Add(series1);
            this.typingDataChart.Size = new System.Drawing.Size(419, 300);
            this.typingDataChart.TabIndex = 1;
            this.typingDataChart.Text = "chart1";
            // 
            // typingDataBox
            // 
            this.typingDataBox.Location = new System.Drawing.Point(39, 12);
            this.typingDataBox.Name = "typingDataBox";
            this.typingDataBox.Size = new System.Drawing.Size(704, 91);
            this.typingDataBox.TabIndex = 2;
            this.typingDataBox.Text = "";
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Location = new System.Drawing.Point(66, 242);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(214, 66);
            this.btnPlayAgain.TabIndex = 3;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // EvaluationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.typingDataBox);
            this.Controls.Add(this.typingDataChart);
            this.Name = "EvaluationPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evaluation Page";
            this.Load += new System.EventHandler(this.EvaluationPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.typingDataChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart typingDataChart;
        private System.Windows.Forms.RichTextBox typingDataBox;
        private System.Windows.Forms.Button btnPlayAgain;
    }
}