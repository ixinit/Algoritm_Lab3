using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritm2._18
{
    public partial class Algoritm218 : Form
    {
        private int num;
        public Algoritm218()
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
            int num1, num2;
            if (num > 9 && num < 100)
            {
                num1 = num / 10 % 10;
                num2 = num % 10;
                if((num1+num2)/10 > 0)
                {
                    lblResult.Text = "Сумма чисел - двузначное число("+(num1+num2)+")";
                }
                else
                {
                    lblResult.Text = (9 - num1 - num2) + " ("+(num+10+ -num1 - num2)+")";
                    
                }
            }
            else
            {
                lblResult.Text = "Число не двузначное";
            }
        }
    }
}
