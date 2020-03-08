using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritm2._9
{
    public partial class Algoritm29 : Form
    {
        private int num;
        public Algoritm29()
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
            int num1, num2, num3, num4;
            lblResult.Text = "";
            if (inputCheckExeption() && num < 10000 && num >99)
            {
                num1 = num / 1000 % 10;
                num2 = num / 100 % 10;
                num3 = num / 10 % 10;
                num4 = num % 10;
                if (num1 != 0)
                {
                    lblResult.Text = num1 + num2 + num3 + num4 + "";
                }
                else if (num2 != 0)
                {
                    lblResult.Text = num2 * num3 * num4 + "";
                }
                else
                {
                    lblResult.Text = "Число за промежутком [100, 9999]";
                }
            }
            else
            {
                lblResult.Text = "Число за промежутком [100, 9999]";
            }
        }
    }
}
