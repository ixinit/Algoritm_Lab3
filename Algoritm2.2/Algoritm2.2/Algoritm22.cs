using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritm_Lab2._2
{
    public partial class Algoritm22 : Form
    {
        private int num;
        public Algoritm22()
        {
            InitializeComponent();
        }
        private void inputCheckExeption()
        {
            try
            {
                num = Convert.ToInt32(tbNumber.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            inputCheckExeption();
            if (num % 2 == 0)
            {
                lblResult.Text = "Число четное";
            }
            else
            {
                lblResult.Text = "Число нечетное";
            }
        }
    }
}
