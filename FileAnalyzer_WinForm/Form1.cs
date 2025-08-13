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
using FileAnalyzer_WinForm.FileReaders;
using FileAnalyzer_Console.FileReaders;

namespace FileAnalyzer_WinForm
{
    public partial class Form1 : Form
    {
        string filePath = "";
        string content = "";
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "All files (*.*)|*.*|  Text Files (*.txt)|*.txt|  Word Documents (*.docx)|*.docx|  PDF Files (*.pdf)|*.pdf";

            openFileDialog.Title = "FileAnalyzer";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                richTextBox1.Text = "";
                richTextBox1.Text = openFileDialog.FileName;
                richTextBox1.WordWrap = false;
                richTextBox1.ScrollBars = RichTextBoxScrollBars.None;
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string extension = Path.GetExtension(filePath).ToLower();

            if (extension == ".txt")
            {
                var txtReader = new TxtFileReader();
                content = txtReader.ReadText(filePath);
            }
            else if (extension == ".docx")
            {
                var txtReader = new DocxFileReader();
                content = txtReader.ReadText(filePath);
            }
            else
            {
                var txtReader = new PdfFileReader();
                content = txtReader.ReadText(filePath);
            }

            var analyzer = new TextAnalyzer();
            string analyzeResult = analyzer.AnalyzeFile(content);

            analyzeText.Text = analyzeResult;
        }
    }
}
