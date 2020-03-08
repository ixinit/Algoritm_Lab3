using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritm2._4
{
    public partial class Form1 : Form
    {
        private int num1, num2;
        public Form1()
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
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            inputCheckExeption();
            if (num1 % 2 == 0 | num2 % 2 == 0)
            {
                lblResult.Text = "Да";
            }
            else
            {
                lblResult.Text = "Нет";
            }
        }
    }
}
