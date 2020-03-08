using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritm2._6
{
    public partial class Algoritm26 : Form
    {
        private int num;
        public Algoritm26()
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
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            inputCheckExeption();
            lblResult.Text = "";
            if (num % 5 == 0 & num.ToString().Length == 4)
            {
                lblResult.Text = "Удача";
            }
        }
    }
}
