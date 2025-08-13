using System;
using System.IO;
using System.Text;
using UglyToad.PdfPig;

namespace FileAnalyzer_Console.FileReaders
{
    public class PdfFileReader
    {
        public string ReadText(string filePath)
        {
            try
            {
                var sb = new StringBuilder();

                var pdf = PdfDocument.Open(filePath);

                foreach (var page in pdf.GetPages())
                {
                    sb.AppendLine(page.Text);
                }

                pdf.Dispose();

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