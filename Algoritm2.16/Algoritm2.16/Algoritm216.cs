using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritm2._16
{
    public partial class Algoritm216 : Form
    {
        private int num1, num2;
        public Algoritm216()
        {
            InitializeComponent();
        }
        private void inputCheckExeption()
        {
            try
            {
                num1 = Convert.ToInt32(tbNum1.Text);
                num2 = Convert.ToInt32(tbNum2.Text);
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
            int num3, num4;
            if ((num1 > 99 && num1 < 1000)||(num1 > 99 && num1 < 1000))
            {
                num3 = num1 / 10 % 10;
                num4 = num2 / 10 % 10;
                if(num3 % 2 == 0 || num4 %2 == 0)
                {
                    lblResult.Text = "1) "+ num1*num1 + "   2) " + Math.Sqrt(Convert.ToDouble(num2));
                }
                else
                {
                    lblResult.Text = "1) " + Math.Sqrt(Convert.ToDouble(num1)) + "   2) " + num2 * num2;
                }
            }
            else
            {
                lblResult.Text = "Число не трехзначное";
            }
        }
    }
}
