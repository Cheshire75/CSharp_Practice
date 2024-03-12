using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void operation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double value1 = Double.Parse(value1Box.Text);
            double value2 = Double.Parse(value2Box.Text);
            double result = 0.0;
            Calculator calc = new Calculator();

            switch (operation.Text)
            {
                case "Add":
                    result = calc.Add(value1, value2);
                    break;
                case "Subtract":
                    result = calc.Subtract(value1, value2);
                    break;
                case "곱하기":
                    result = calc.Multiple(value1, value2);
                    break;
                case "나누기":
                    result = calc.Divide(value1, value2);
                    break;
                case "나머지":
                    result = calc.Remainder(value1, value2);
                    break;
                case "Pow":
                    result = calc.Power(value1, value2);
                    break;
                case "Max":
                    result = calc.Max(value1, value2);
                    break;
            }
            resultBox.Text=result.ToString();
        }
    }
}
