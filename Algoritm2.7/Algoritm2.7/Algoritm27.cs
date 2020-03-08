using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritm2._7
{
    public partial class Algoritm27 : Form
    {
        private int num;
        public Algoritm27()
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

        private void btnCalc_Click(object sender, EventArgs e)
        {
            inputCheckExeption();
            if (num / 10 == num %10)
            {
                lblResult.Text = "Состоит из одинаковых чисел";
            }
        }
    }
}
