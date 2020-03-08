using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritm2._10
{
    public partial class Algoritm210 : Form
    {
        private int num;
        public Algoritm210()
        {
            InitializeComponent();
        }
        private void inputCheckExeption()
        {
            try
            {
                num = Convert.ToInt32(tbNum.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            lblResult.Text = "";
        }
        private void btnClic_Click(object sender, EventArgs e)
        {
            inputCheckExeption();
            int num1, num2, num3, num4;
            if (num > 999 && num < 10000)
            {
                num1 = num / 1000 % 10;
                num2 = num / 100 % 10;
                num3 = num / 10 % 10;
                num4 = num % 10;
                if(num1 + num4 == num2 - num3)
                {
                    lblResult.Text = "Сумма и разность равны";
                }
                else
                {
                    lblResult.Text = "Сумма и разность неравны";
                }
            }
            else
            {
                lblResult.Text = "Число не четырехзначное";
            }
        }
    }
}
