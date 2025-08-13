using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAnalyzer_WinForm.FileReaders
{
    public class TxtFileReader
    {
        public string ReadText(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            StreamReader reader = new StreamReader(fs);

            string content = reader.ReadToEnd();

            reader.Close();
            fs.Close();

            return content;
        }
    }
}
