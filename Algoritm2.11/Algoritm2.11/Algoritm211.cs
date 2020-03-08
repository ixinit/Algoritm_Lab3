using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritm2._11
{
    public partial class Algoritm211 : Form
    {
        private int num;
        public Algoritm211()
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
            int num1, num2, num3;
            if (num > 99 && num < 1000)
            {
                num1 = num / 100 % 10;
                num2 = num / 10 % 10;
                num3 = num % 10;
                if (num1 == 1 || num2 == 1 || num3 == 1)
                {
                    lblResult.Text = num * 2 + "";
                }
                else
                {
                    lblResult.Text = num * num + "";
                }
            }
            else
            {
                lblResult.Text = "Число не трехзначное";
            }
        }
    }
}
