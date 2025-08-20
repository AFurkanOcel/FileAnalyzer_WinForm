using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileAnalyzer_WinForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            if (this.Text == "Log In")
            {
                Form1 form1 = new Form1();
                form1.Show();

                this.Hide();
            }
            else
            {
                this.Text = "Log In";
            }
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            if(this.Text == "Sign Up")
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                this.Text = "Sign Up";
            }
        }
    }
}
