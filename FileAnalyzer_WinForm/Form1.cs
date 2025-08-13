using System;
using System.IO;
using System.Windows.Forms;
using FileAnalyzer_WinForm.FileReaders;
using FileAnalyzer_Console.FileReaders;
using Newtonsoft.Json;

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

        private void SelectFolderButton_Click(object sender, EventArgs e)
        {
            AnalyzeBar.Value = 0;
            AnalyzeText.Text = "";
            FolderPathText.Text = "";

            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (txtCheckBox.Checked == true && docxCheckBox.Checked == true && pdfCheckBox.Checked == true)
            {
                openFileDialog.Filter = "All files (*.txt;*.docx;*.pdf)|*.txt;*.docx;*.pdf|  Text Files (*.txt)|*.txt|  Word Documents (*.docx)|*.docx|  PDF Files (*.pdf)|*.pdf";
            }
            else if (txtCheckBox.Checked == true && docxCheckBox.Checked == true && pdfCheckBox.Checked == false)
            {
                openFileDialog.Filter = "All Files (*.txt;*.docx)|*.txt;*.docx|  Text Files (*.txt)|*.txt|  Word Documents (*.docx)|*.docx";
            }
            else if (txtCheckBox.Checked == true && docxCheckBox.Checked == false && pdfCheckBox.Checked == true)
            {
                openFileDialog.Filter = "All Files (*.txt;*.pdf)|*.txt;*.pdf|  Text Files (*.txt)|*.txt|  PDF Files (*.pdf)|*.pdf";
            }
            else if (txtCheckBox.Checked == false && docxCheckBox.Checked == true && pdfCheckBox.Checked == true)
            {
                openFileDialog.Filter = "All Files (*.docx;*.pdf)|*.docx;*.pdf|  Word Documents (*.docx)|*.docx|  PDF Files (*.pdf)|*.pdf";
            }
            else if (txtCheckBox.Checked == true && docxCheckBox.Checked == false && pdfCheckBox.Checked == false)
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt";
            }
            else if (txtCheckBox.Checked == false && docxCheckBox.Checked == true && pdfCheckBox.Checked == false)
            {
                openFileDialog.Filter = "Word Documents (*.docx)|*.docx";
            }
            else if (txtCheckBox.Checked == false && docxCheckBox.Checked == false && pdfCheckBox.Checked == true)
            {
                openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
            }
            else
            {
                MessageBox.Show("No file type selected");
            }

            openFileDialog.Title = "FileAnalyzer";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                FolderPathText.Text = openFileDialog.FileName;
                FolderPathText.WordWrap = false;
                FolderPathText.ScrollBars = RichTextBoxScrollBars.None;
            }
        }

        public void AnalyzeButton_Click(object sender, EventArgs e)
        {
            AnalyzeBar.Value += 50;

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

            AnalyzeBar.Value += 50;
            AnalyzeText.Text = analyzeResult;
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("JSON");

            string AnalyzedText = AnalyzeText.Text;

            string json = JsonConvert.SerializeObject(AnalyzedText);
            File.WriteAllText(@"JSON\AnalyzeResult.json", json);

            MessageBox.Show("Export completed");
        }
    }
}
