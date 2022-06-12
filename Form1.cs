using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void numberOfTermsTextBox_TextChanged(object sender, EventArgs e)
        {
           

        }
     
        private void calculateButton_Click(object sender, EventArgs e)

        {
            int numberOfTerms = 0;
            double calculation = 4;
            double numerator = 4;
            double denomiantor = 3;
            numberOfTerms = Convert.ToInt32(numberOfTermsTextBox.Text);

            for (int i = 0; i <= numberOfTerms; i++)
            {
               if(i % 2 == 0)
                {
                    calculation -= numerator / denomiantor;
                }
               else
                {
                    calculation += numerator / denomiantor;
                }
                denomiantor += 2;
            }
            answerTextBox.Text += "Approximate value of pi after " + numberOfTerms + " terms";
            answerTextBox.Text += Environment.NewLine + " =" + calculation;


        }
    }
}
