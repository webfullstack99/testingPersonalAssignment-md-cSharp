using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check_triangle
{
    public partial class Form1 : Form
    {
        private String aVal;
        private String bVal;
        private String cVal;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // KEY PRESS
        private void tbA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!isInputValid(tbA, sender, e)) e.Handled = true;
        }

        private void tbB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!isInputValid(tbB, sender, e)) e.Handled = true;
        }

        private void tbC_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!isInputValid(tbC, sender, e)) e.Handled = true;
        }

        // CHECK INPUT
        private bool isInputValid(TextBox tb, object sender, KeyPressEventArgs e)
        {
            // check is control keys or number
            if (!isValidLetter(e.KeyChar)) return false;

            // only allow one decimal point
            if (
                    (e.KeyChar == '.' || e.KeyChar == ',' ) && 
                    (
                        ((sender as TextBox).Text.IndexOf('.') > -1) ||
                        ((sender as TextBox).Text.IndexOf(',') > -1)
                    )
                ) return false;

            if (!char.IsDigit(e.KeyChar))
            {
                int position = Convert.ToInt32(tb.SelectionStart.ToString());
                string tbVal = tb.Text.ToString();

                // operator
                if (isOperator(e.KeyChar))
                {
                    if (position == 0)
                    {
                        if (tbVal.Length > 0)
                        {
                            if (isOperator(tbVal[0])) return false;
                        }
                    }
                    else
                    {
                        if (!isScientificNotation(tbVal[position - 1])) return false;
                    }
                }

                // scientific notation
                else if (isScientificNotation(e.KeyChar))
                {
                    if (tbVal.Length > 0)
                    {
                        if (char.IsDigit(tbVal[position - 1])) return true;
                    }
                    return false;
                }
            }
            return true;
        }

        private bool isValidLetter(char c)
        {
            return (char.IsControl(c) || char.IsDigit(c) || isScientificNotation(c) || isOperator(c) || c == '.' || c == ',');
        }

        private bool isScientificNotation(char c)
        {
            char[] scientificNotationAllowed = { 'e', 'E' };
            return Array.IndexOf(scientificNotationAllowed, c) > -1;
        }

        private bool isOperator(char c)
        {
            char[] operatorAllowed = { '+', '-' };
            return Array.IndexOf(operatorAllowed, c) > -1;
        }

        // ON CHECK
        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(standardizeValue(tbA.Text.ToString()));
                double b = Convert.ToDouble(standardizeValue(tbB.Text.ToString()));
                double c = Convert.ToDouble(standardizeValue(tbC.Text.ToString()));
                checkTriagle(a, b, c);

            }
            catch (Exception ex) {
                String errMessage = "Loi chua co du lieu";
                Console.WriteLine(errMessage);
                //MessageBox.Show(errMessage);
                lbResult.Text = errMessage;
            }
        }

        // CHECK TRIAGLE
        private void checkTriagle(double a, double b, double c)
        {
            String result = "";
                Console.WriteLine($"a: {a}");
                Console.WriteLine($"b: {b}");
                Console.WriteLine($"c: {c}");
            if (a+b > c && a+c > b && c+b > a)
            {
                if (a==b && b==c && a == c)
                {
                    result = "Tam giac deu";
                }else if (a==c || b==c || a == b)
                {
                    result = "Tam giac can";

                }else if (isSquareTriangle(a, b, c))
                {
                    result = "Tam giac vuong";
                }
                else
                {
                    result = "Tam giac thuong";
                }

            }
            else 
            {
                result = "Khong phai la tam giac";
            }
            lbResult.Text = "Ket qua: "+result;
        }

        private bool isSquareTriangle(double a, double b, double c)
        {
            double pA = Math.Pow(a, 2);
            double pB = Math.Pow(b, 2);
            double pC = Math.Pow(c, 2);
            if (pA + pB == pC || pA + pC == pB || pB + pC == pA) return true;
            return false;
        }

        private String standardizeValue(String value)
        {
            return value.Replace(',', '.');
        }

        private void tbA_TextChanged(object sender, EventArgs e)
        {
            /*
            TextBox senderTextBox = (sender as TextBox);
            String value = senderTextBox.Text.ToString();
            Console.WriteLine("current val: "+ aVal);
            Console.WriteLine("a paste: "+value);

            // TEST
            Double n1;
            bool succeeded1 = Double.TryParse(value, out n1);
            if (!succeeded1)
            {
                // only one , or . or none
                senderTextBox.Text = aVal;
                Console.WriteLine("paste failed, old val: "+aVal);
                senderTextBox.SelectionStart = aVal.Length;
                senderTextBox.SelectionLength = 0;
            }
            else { 
                 aVal = value;
                Console.WriteLine("paste success", aVal);
            }
            */
        }

        private void tbB_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbC_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
