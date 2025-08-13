using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileAnalyzer_WinForm
{
    public class TextAnalyzer
    {
        public string AnalyzeFile(string content)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(content))
                {
                    return "File is empty!";
                }

                string[] punctuation = { ".", ",", ";", ":", "-", "_", "|", "<", ">", "!", "?", "#", "%", "/", "=", "*", "+", "{", "[", "]", "}", "(", ")", "𝜀", "'" };
                string[] conjunctions = { "ve", "ile", "ama", "ancak" };

                string[] words = content.Split(' ', '\n', '\r');

                List<string> filteredWords = new List<string>();
                Dictionary<string, int> punctuationAndCounts = new Dictionary<string, int>();

                foreach (string word in words)
                {
                    string lowercaseWord = word.ToLower().Trim();

                    bool isNumber = int.TryParse(lowercaseWord, out _);

                    if (!string.IsNullOrWhiteSpace(lowercaseWord) && !conjunctions.Contains(lowercaseWord) && !isNumber && !punctuation.Contains(lowercaseWord))
                    {
                        filteredWords.Add(lowercaseWord);
                    }

                    foreach (var punc in punctuation)
                    {
                        if (lowercaseWord.Contains(punc))
                        {
                            if (punctuationAndCounts.ContainsKey(punc))
                            {
                                punctuationAndCounts[punc]++;
                            }
                            else
                            {
                                punctuationAndCounts[punc] = 1;
                            }
                        }
                    }
                }

                int charCount = content.Length;
                int lineCount = content.Split('\n').Length;
                int uniqueWordCount = filteredWords.Distinct().Count();

                Dictionary<string, int> wordAndCounts = new Dictionary<string, int>();
                foreach (var word in filteredWords)
                {
                    if (wordAndCounts.ContainsKey(word))
                    {
                        wordAndCounts[word]++;
                    }
                    else
                    {
                        wordAndCounts[word] = 1;
                    }
                }

                var sortedWordCounts = wordAndCounts.OrderByDescending(entry => entry.Value);
                var sortedPunctuations = punctuationAndCounts.OrderByDescending(entry => entry.Value);

                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Character Count: {charCount}");
                sb.AppendLine($"Line Count: {lineCount}");
                sb.AppendLine($"Unique Word Count: {uniqueWordCount}");
                sb.AppendLine("");
                sb.AppendLine("Repetitive Words");
                sb.AppendLine("----------------");

                foreach (var repetitiveWord in sortedWordCounts)
                {
                    if (repetitiveWord.Value > 1)
                    {
                        sb.AppendLine($"{repetitiveWord.Value}  {repetitiveWord.Key}");
                    }
                }

                sb.AppendLine("");
                sb.AppendLine("Punctuation Counts");
                sb.AppendLine("-----------------");

                foreach (var punc in sortedPunctuations)
                {
                    sb.AppendLine($"{punc.Key} : {punc.Value}");
                }

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

                return $"An error occurred: {ex.Message}";
            }
        }
    }
}

