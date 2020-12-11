using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T7_2180617_TranHoangAnh.Classes;

namespace check_triangle
{
    public partial class Dlg_Data : Form
    {

        private String muc = "";
        private int mucIndex;

        public Dlg_Data()
        {
            InitializeComponent();
        }

        public string getMuc()
        {
            return muc;
        }

        public int getMucIndex()
        {
            return mucIndex;
        }

        public ComboBox getComboBoxMuc()
        {
            return Txt_Type;
        }

        public string getNgay()
        {
            return Txt_Date.Text;
        }

        public string getMoney()
        {
            return Txt_Cash.Text;
        }

        public string getKhoan()
        {
            return Txt_Item.Text;
        }

        // CHECK INPUT
        private bool isNumberInputValid(TextBox tb, object sender, KeyPressEventArgs e)
        {
            // check is control keys or number
            if (!isValidLetter(e.KeyChar)) return false;

            // only allow one decimal point
            if (
                    (e.KeyChar == '.' || e.KeyChar == ',') &&
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

        private void tbNgay_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tbKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!isNumberInputValid(tbKhoan, sender, e)) e.Handled = true;
        }

        private void tbMoney_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!isNumberInputValid(Txt_Cash, sender, e)) e.Handled = true;
        }
        private bool IsDateTime(string txtDate)
        {
            try
            {
                DateTime dateTime = Helper.getTime(txtDate);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // ON ADD
        private void btnAddData(object sender, EventArgs e)
        {
            if (
                IsDateTime(Txt_Date.Text) &&
                getKhoan().Trim() != "" &&
                getMoney().Trim() != "" &&
                getMuc().Trim() != "")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Du lieu khong hop le");
            }
        }

        private void comboBoxMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selected = (string)Txt_Type.SelectedItem;
            this.muc = selected;
            this.mucIndex = Txt_Type.SelectedIndex;
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

