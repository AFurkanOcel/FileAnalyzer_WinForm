using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FileAnalyzer_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "All files (*.*)|*.*|  Text Files (*.txt)|*.txt|  Word Documents (*.docx)|*.docx|  PDF Files (*.pdf)|*.pdf";

            openFileDialog1.Title = "Dosya Seç";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = "";
                richTextBox1.Text = openFileDialog1.FileName;
                richTextBox1.WordWrap = false;
                richTextBox1.ScrollBars = RichTextBoxScrollBars.None;
            }
        }
    }
}
