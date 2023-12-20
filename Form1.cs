using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCA_Practical
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string pn = txtPersonName.Text;
            string cn = txtCountryName.Text;

            if (string.IsNullOrEmpty(pn))  // pn == ""
            {
                MessageBox.Show("Enter Person Name");
            }
            else if (string.IsNullOrEmpty(cn))
            {
                MessageBox.Show("Enter Country Name");
            }
            else
            {
                //string msg = "Hello " + pn + ". Welcome to " + cn;
                string msg = string.Format("Hello {0}. Welcome to {1}. Have fun {0}!!"
                                        , pn, cn);
                MessageBox.Show(msg);
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int fn = Convert.ToInt32(txtFirstNumber.Text);
            int sn = Convert.ToInt32(txtSecondNumber.Text);

            int sum = fn + sn;
            string msg = "The sum of two number is " + sum.ToString();
            MessageBox.Show(msg, "SUM");
        }

        private void btnIsEqual_Click(object sender, EventArgs e)
        {
            int fn = Convert.ToInt32(txtFirstNumber.Text);
            int sn = Convert.ToInt32(txtSecondNumber.Text);

            string msg = fn == sn ? "The numbers are EQUAL" : "NOT EQUAL";
            MessageBox.Show(msg);
        }

        private void btnAssignment_Click(object sender, EventArgs e)
        {
            int fn = Convert.ToInt32(txtFirstNumber.Text);
            int sn = Convert.ToInt32(txtSecondNumber.Text);

            fn += 5;
            sn -= 10;

            string msg = "First Number is increased by 5. RESULT = " + fn.ToString();
            MessageBox.Show(msg);

            msg = "Second number is decreased by 10. RESULT = " + sn.ToString();
            MessageBox.Show(msg);
        }
    }
}
