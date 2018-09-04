namespace LearnToType
{
    partial class StartingPage
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
            this.dropDownList = new System.Windows.Forms.ComboBox();
            this.btnStartTyping = new System.Windows.Forms.Button();
            this.btnCloseApplication = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.headingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dropDownList
            // 
            this.dropDownList.FormattingEnabled = true;
            this.dropDownList.Location = new System.Drawing.Point(329, 143);
            this.dropDownList.Name = "dropDownList";
            this.dropDownList.Size = new System.Drawing.Size(161, 24);
            this.dropDownList.TabIndex = 0;
            this.dropDownList.TabStop = false;
            // 
            // btnStartTyping
            // 
            this.btnStartTyping.Location = new System.Drawing.Point(329, 211);
            this.btnStartTyping.Name = "btnStartTyping";
            this.btnStartTyping.Size = new System.Drawing.Size(179, 84);
            this.btnStartTyping.TabIndex = 1;
            this.btnStartTyping.Text = "Start Typing";
            this.btnStartTyping.UseVisualStyleBackColor = true;
            this.btnStartTyping.Click += new System.EventHandler(this.btnStartTyping_Click);
            // 
            // btnCloseApplication
            // 
            this.btnCloseApplication.Location = new System.Drawing.Point(329, 321);
            this.btnCloseApplication.Name = "btnCloseApplication";
            this.btnCloseApplication.Size = new System.Drawing.Size(179, 84);
            this.btnCloseApplication.TabIndex = 2;
            this.btnCloseApplication.Text = "Close Application";
            this.btnCloseApplication.UseVisualStyleBackColor = true;
            this.btnCloseApplication.Click += new System.EventHandler(this.btnCloseApplication_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select time:";
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLabel.Location = new System.Drawing.Point(117, 35);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(579, 55);
            this.headingLabel.TabIndex = 4;
            this.headingLabel.Text = "Welcome to Type Master";
            // 
            // StartingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.headingLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCloseApplication);
            this.Controls.Add(this.btnStartTyping);
            this.Controls.Add(this.dropDownList);
            this.Name = "StartingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartingPage";
            this.Load += new System.EventHandler(this.StartingPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox dropDownList;
        private System.Windows.Forms.Button btnStartTyping;
        private System.Windows.Forms.Button btnCloseApplication;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label headingLabel;
    }
}