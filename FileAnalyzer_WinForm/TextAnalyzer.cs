using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileAnalyzer_WinForm
{
    public class TextAnalyzer
    {
        public string AnalyzeFile(string content)
        {
            //if (string.IsNullOrWhiteSpace(content))
            //{
            //    throw new Exception("File is empty!");
            //}

            int charCount = content.Length;
            int lineCount = content.Split('\n').Length;

            string[] conjunctions = { "ve", "ile", "ama", "ancak" };
            string[] words = content.Split(' ', '\n', '\r');
            string[] punctuation = {""}; // noktalama işaretleri de sayılmalı, daha eklemedim.

            List<string> filteredWords = new List<string>();

            foreach (string word in words)
            {
                string lowercaseWord = word.ToLower();

                int number;
                bool isNumber = int.TryParse(lowercaseWord, out number);

                if (!string.IsNullOrWhiteSpace(lowercaseWord) && !conjunctions.Contains(lowercaseWord) && !isNumber)
                {
                    filteredWords.Add(lowercaseWord);
                }
            }

            int uniqueWordCount = filteredWords.Distinct().Count();
            Dictionary<string, int> wordAndCounts = new Dictionary<string, int>();

            foreach (var word in filteredWords)
            {
                if (wordAndCounts.ContainsKey(word))
                    wordAndCounts[word]++;
                else
                    wordAndCounts[word] = 1;
            }

            var sortedWordCounts = wordAndCounts.OrderByDescending(wordAndValue => wordAndValue.Value);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Character count: {charCount}");
            sb.AppendLine($"Line count: {lineCount}");
            sb.AppendLine($"Unique word count: {uniqueWordCount}");
            sb.AppendLine("");
            sb.AppendLine("repetitive words");
            sb.AppendLine("----------------");

            foreach (var repetitiveWords in sortedWordCounts)
            {
                if (repetitiveWords.Value > 1)
                {
                    sb.AppendLine($"{repetitiveWords.Value}  {repetitiveWords.Key}");
                }
            }
            return sb.ToString();
        }
    }
}

