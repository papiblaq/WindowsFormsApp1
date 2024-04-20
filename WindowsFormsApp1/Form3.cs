using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_height.Text = "";
            txt_weight.Text = "";
            txt_result.Text = "";

            radkg.Checked = false;
            radpound.Checked = false;
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(txt_weight.Text);
            double height = Convert.ToDouble(txt_height.Text);
            double result = 0.0;
            string result2 = "";

            if (radkg.Checked)
            {
                result = weight / (height * height);
            }
            else if (radpound.Checked)
            {
                weight = weight / 2.205;
                result = weight / (height * height);
            }

            if (result < 18.5)
            {
                result2 = "your underweight";
            }
            else if (result < 25)
            {
                result2 = "you have normal weight";
            }
            else if (result < 30)
            {
                result2 = "your overweight";
            }
            else if (result >= 30)
            {
                result2 = "your are obese";
            }

            txt_result.Text = "your result is" + result.ToString("#.#") + "\r\n" + result2;
        }
    }
}
