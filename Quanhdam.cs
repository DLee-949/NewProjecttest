using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewProjecttest
{
    public partial class Quanhdam : Form
    {
        double a, b, c, d, x1, x2;
        public Quanhdam()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Quanhdam_Load(object sender, EventArgs e)
        {

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    a = Convert.ToDouble(txtA.Text);
                    b = Convert.ToDouble(txtB.Text);
                    c = Convert.ToDouble(txtC.Text);
                    d = b * b - 4 * a * c;
                }
                if (d < 0)
                {
                    lblKQ.Text = "Phương trình vô nghiệm";
                }
                else if (d == 0)
                {
                    x1 = x2 = -b / (2 * a);
                    lblKQ.Text = "Phương trình có nghiệm kép: x1 = x2 = " + Math.Round(x1, 1);
                }
                else
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    lblKQ.Text = "Phương trình có hai nghiệm phân biệt: x1 = " + Math.Round(x1, 1) + ", x2 = " + Math.Round(x2, 1);
                }

            }
            catch (Exception)
            {
                lblKQ.Text= "Vui lòng nhập đúng định dạng số!";
            }


        }
    }
}

