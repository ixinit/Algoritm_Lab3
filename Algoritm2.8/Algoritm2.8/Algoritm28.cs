using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritm2._8
{
    public partial class Algoritm28 : Form
    {
        private int num;
        public Algoritm28()
        {
            InitializeComponent();
        }
        private bool inputCheckExeption()
        {
            try
            {
                num = Convert.ToInt32(tbNum.Text);
                return true;
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;
            lblResult.Text = "";
            if (inputCheckExeption())
            if (num < 1000 && num > 99)
            {
                num1 = num / 100;
                num2 = num / 10 % 10;
                num3 = num % 10;
                if (num1 != num2 & num2 != num3 & num3 != num1)
                    lblResult.Text = "Все цифры разные";
                else
                    lblResult.Text = "Цифры повторяются";
            }
            else
                lblResult.Text = "Число не трехзначное";
        }
    }
}
