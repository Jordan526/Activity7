namespace Activity_7
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
            this.introductionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numberOfTermsTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // introductionTextBox
            // 
            this.introductionTextBox.Location = new System.Drawing.Point(12, 12);
            this.introductionTextBox.Name = "introductionTextBox";
            this.introductionTextBox.Size = new System.Drawing.Size(281, 20);
            this.introductionTextBox.TabIndex = 0;
            this.introductionTextBox.Text = "Calulate Number of Terms of Pie";
            this.introductionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Number of Terms:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberOfTermsTextBox
            // 
            this.numberOfTermsTextBox.Location = new System.Drawing.Point(160, 81);
            this.numberOfTermsTextBox.Name = "numberOfTermsTextBox";
            this.numberOfTermsTextBox.Size = new System.Drawing.Size(69, 20);
            this.numberOfTermsTextBox.TabIndex = 2;
            this.numberOfTermsTextBox.TextChanged += new System.EventHandler(this.numberOfTermsTextBox_TextChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(160, 125);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(69, 23);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(85, 167);
            this.answerTextBox.Multiline = true;
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(208, 65);
            this.answerTextBox.TabIndex = 5;
            this.answerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 244);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.numberOfTermsTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.introductionTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox introductionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberOfTermsTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox answerTextBox;
    }
}

