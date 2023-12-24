using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(height.Text, out double heightValue) && double.TryParse(weight.Text, out double weightValue))
            {
                double bmi = CalculateBMI(heightValue, weightValue);
                Result.Text = $"BMI: {bmi:F2}";
                DisplayTextBasedOnBMI(bmi);
            }
            else
            {
                Result.Text = "Please enter valid height and weight.";
            }
        }

        private double CalculateBMI(double height, double weight)
        {
            return weight / ((height * height)/10000);
        }


        private void DisplayTextBasedOnBMI(double bmi)
        {
            if (bmi < 18.5)
            {
                Result.Text += "\n   Underweight";
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                Result.Text += "\n   Normal Weight";
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                Result.Text += "\n   Overweight ";
            }
            else if (bmi >= 30 && bmi <= 34.9)
            {
                Result.Text += "\n   Obesity (Class I)";
            }
            else if (bmi >= 35.5 && bmi <= 39.9)
            {
                Result.Text += "\n  Obesity (Class II)";
            }
            else
            {
                Result.Text += "\n   Extreme Obesity";
            }
        }
    }
}
