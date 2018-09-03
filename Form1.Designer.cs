namespace LearnToType
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
            this.components = new System.ComponentModel.Container();
            this.timeBox = new System.Windows.Forms.RichTextBox();
            this.amountTotalTypedBox = new System.Windows.Forms.RichTextBox();
            this.amountCorrectTypedBox = new System.Windows.Forms.RichTextBox();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnEvaluateTyping = new System.Windows.Forms.Button();
            this.percentageWrongTypedBox = new System.Windows.Forms.RichTextBox();
            this.middleCharacterBox = new System.Windows.Forms.TextBox();
            this.firstRightCharacterBox = new System.Windows.Forms.TextBox();
            this.secondRightCharacterBox = new System.Windows.Forms.TextBox();
            this.firstLeftCharacterBox = new System.Windows.Forms.TextBox();
            this.secondLeftCharacterBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fingerAdviceBox = new System.Windows.Forms.TextBox();
            this.headingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timeBox
            // 
            this.timeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeBox.Location = new System.Drawing.Point(612, 67);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(132, 40);
            this.timeBox.TabIndex = 5;
            this.timeBox.TabStop = false;
            this.timeBox.Text = "time";
            // 
            // amountTotalTypedBox
            // 
            this.amountTotalTypedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTotalTypedBox.Location = new System.Drawing.Point(49, 67);
            this.amountTotalTypedBox.Name = "amountTotalTypedBox";
            this.amountTotalTypedBox.Size = new System.Drawing.Size(132, 40);
            this.amountTotalTypedBox.TabIndex = 6;
            this.amountTotalTypedBox.TabStop = false;
            this.amountTotalTypedBox.Text = "how many total";
            // 
            // amountCorrectTypedBox
            // 
            this.amountCorrectTypedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountCorrectTypedBox.Location = new System.Drawing.Point(254, 67);
            this.amountCorrectTypedBox.Name = "amountCorrectTypedBox";
            this.amountCorrectTypedBox.Size = new System.Drawing.Size(132, 40);
            this.amountCorrectTypedBox.TabIndex = 7;
            this.amountCorrectTypedBox.TabStop = false;
            this.amountCorrectTypedBox.Text = "how many correct";
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Location = new System.Drawing.Point(129, 385);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(156, 73);
            this.btnPlayAgain.TabIndex = 9;
            this.btnPlayAgain.TabStop = false;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnEvaluateTyping
            // 
            this.btnEvaluateTyping.Location = new System.Drawing.Point(513, 385);
            this.btnEvaluateTyping.Name = "btnEvaluateTyping";
            this.btnEvaluateTyping.Size = new System.Drawing.Size(156, 73);
            this.btnEvaluateTyping.TabIndex = 10;
            this.btnEvaluateTyping.TabStop = false;
            this.btnEvaluateTyping.Text = "Evaluate";
            this.btnEvaluateTyping.UseVisualStyleBackColor = true;
            this.btnEvaluateTyping.Click += new System.EventHandler(this.btnEvaluateTyping_Click);
            // 
            // percentageWrongTypedBox
            // 
            this.percentageWrongTypedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentageWrongTypedBox.Location = new System.Drawing.Point(435, 67);
            this.percentageWrongTypedBox.Name = "percentageWrongTypedBox";
            this.percentageWrongTypedBox.Size = new System.Drawing.Size(132, 40);
            this.percentageWrongTypedBox.TabIndex = 11;
            this.percentageWrongTypedBox.TabStop = false;
            this.percentageWrongTypedBox.Text = "percentage wrong";
            // 
            // middleCharacterBox
            // 
            this.middleCharacterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleCharacterBox.Location = new System.Drawing.Point(334, 120);
            this.middleCharacterBox.Multiline = true;
            this.middleCharacterBox.Name = "middleCharacterBox";
            this.middleCharacterBox.Size = new System.Drawing.Size(147, 155);
            this.middleCharacterBox.TabIndex = 12;
            this.middleCharacterBox.TabStop = false;
            this.middleCharacterBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // firstRightCharacterBox
            // 
            this.firstRightCharacterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstRightCharacterBox.Location = new System.Drawing.Point(522, 158);
            this.firstRightCharacterBox.Multiline = true;
            this.firstRightCharacterBox.Name = "firstRightCharacterBox";
            this.firstRightCharacterBox.Size = new System.Drawing.Size(104, 117);
            this.firstRightCharacterBox.TabIndex = 13;
            this.firstRightCharacterBox.TabStop = false;
            this.firstRightCharacterBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // secondRightCharacterBox
            // 
            this.secondRightCharacterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondRightCharacterBox.Location = new System.Drawing.Point(683, 190);
            this.secondRightCharacterBox.Multiline = true;
            this.secondRightCharacterBox.Name = "secondRightCharacterBox";
            this.secondRightCharacterBox.Size = new System.Drawing.Size(74, 85);
            this.secondRightCharacterBox.TabIndex = 14;
            this.secondRightCharacterBox.TabStop = false;
            this.secondRightCharacterBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // firstLeftCharacterBox
            // 
            this.firstLeftCharacterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstLeftCharacterBox.Location = new System.Drawing.Point(181, 158);
            this.firstLeftCharacterBox.Multiline = true;
            this.firstLeftCharacterBox.Name = "firstLeftCharacterBox";
            this.firstLeftCharacterBox.Size = new System.Drawing.Size(104, 117);
            this.firstLeftCharacterBox.TabIndex = 15;
            this.firstLeftCharacterBox.TabStop = false;
            this.firstLeftCharacterBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // secondLeftCharacterBox
            // 
            this.secondLeftCharacterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondLeftCharacterBox.Location = new System.Drawing.Point(51, 190);
            this.secondLeftCharacterBox.Multiline = true;
            this.secondLeftCharacterBox.Name = "secondLeftCharacterBox";
            this.secondLeftCharacterBox.Size = new System.Drawing.Size(74, 85);
            this.secondLeftCharacterBox.TabIndex = 16;
            this.secondLeftCharacterBox.TabStop = false;
            this.secondLeftCharacterBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fingerAdviceBox
            // 
            this.fingerAdviceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fingerAdviceBox.Location = new System.Drawing.Point(199, 301);
            this.fingerAdviceBox.Multiline = true;
            this.fingerAdviceBox.Name = "fingerAdviceBox";
            this.fingerAdviceBox.Size = new System.Drawing.Size(404, 61);
            this.fingerAdviceBox.TabIndex = 17;
            this.fingerAdviceBox.TabStop = false;
            this.fingerAdviceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLabel.Location = new System.Drawing.Point(191, 9);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(438, 46);
            this.headingLabel.TabIndex = 18;
            this.headingLabel.Text = "Train your typing skills";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.headingLabel);
            this.Controls.Add(this.fingerAdviceBox);
            this.Controls.Add(this.secondLeftCharacterBox);
            this.Controls.Add(this.firstLeftCharacterBox);
            this.Controls.Add(this.secondRightCharacterBox);
            this.Controls.Add(this.firstRightCharacterBox);
            this.Controls.Add(this.middleCharacterBox);
            this.Controls.Add(this.percentageWrongTypedBox);
            this.Controls.Add(this.btnEvaluateTyping);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.amountCorrectTypedBox);
            this.Controls.Add(this.amountTotalTypedBox);
            this.Controls.Add(this.timeBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Learn to type";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox timeBox;
        private System.Windows.Forms.RichTextBox amountTotalTypedBox;
        private System.Windows.Forms.RichTextBox amountCorrectTypedBox;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnEvaluateTyping;
        private System.Windows.Forms.RichTextBox percentageWrongTypedBox;
        private System.Windows.Forms.TextBox middleCharacterBox;
        private System.Windows.Forms.TextBox firstRightCharacterBox;
        private System.Windows.Forms.TextBox secondRightCharacterBox;
        private System.Windows.Forms.TextBox firstLeftCharacterBox;
        private System.Windows.Forms.TextBox secondLeftCharacterBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox fingerAdviceBox;
        private System.Windows.Forms.Label headingLabel;
    }
}

