using System;
using System.IO;

namespace FileAnalyzer_WinForm.FileReaders
{
    public class TxtFileReader
    {
        public string ReadText(string filePath)
        {
            try
            {
                FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);

                StreamReader reader = new StreamReader(fs);

                string content = reader.ReadToEnd();

                reader.Close();
                fs.Close();

                return content;
            }
            catch(Exception ex)
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
