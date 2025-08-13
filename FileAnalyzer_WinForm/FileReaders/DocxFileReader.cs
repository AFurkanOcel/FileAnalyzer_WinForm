using System.Text;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab.Body;

namespace FileAnalyzer_Console.FileReaders
{
    public class DocxFileReader
    {
        public string ReadText(string filePath)
        {
            StringBuilder sb = new StringBuilder();

            WordprocessingDocument docx = WordprocessingDocument.Open(filePath, false);

            Body body = docx.MainDocumentPart.Document.Body;

            foreach (var paragraf in body.Elements<Paragraph>())
            {
                sb.AppendLine(paragraf.InnerText);
            }

            docx.Dispose();

            return sb.ToString();
        }
    }
}