using System;
using System.IO;
using System.Text;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace FileAnalyzer_Console.FileReaders
{
    public class DocxFileReader
    {
        public string ReadText(string filePath)
        {
            try
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
            catch (Exception ex)
            {
                Directory.CreateDirectory("Logs");
                string logPath = Path.Combine("Logs", "log.txt");
                File.AppendAllText(logPath, Environment.UserName);
                File.AppendAllText(logPath, Environment.NewLine);
                File.AppendAllText(logPath, DateTime.Now.ToString("dd.MM.yyyy HH.mm"));
                File.AppendAllText(logPath, Environment.NewLine);
                File.AppendAllText(logPath, ex.Message);
                File.AppendAllText(logPath, Environment.NewLine);
                File.AppendAllText(logPath, ex.StackTrace);
                File.AppendAllText(logPath, Environment.NewLine);
                File.AppendAllText(logPath, Environment.NewLine);

                return "Error reading file: " + ex.Message;
            }
        }
    }
}