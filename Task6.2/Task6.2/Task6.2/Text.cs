using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task6._2
{
    internal class Text
    {
        private string inputText;
        public Text() : this("")
        { 

        }
        public Text(string text)
        {
            inputText = text;
        }
        public Text(StreamReader reader)
        {
            inputText = Regex.Replace(reader.ReadToEnd(), @"\s+", " ").Trim();
        }
        public void WriteToFileSentences()
        {
//Цікаво,  чи вмієте самі створювати та читати регулярні вирази
            string[] sentences = Regex.Split(inputText, @"(?<=[\.!\?]+['\""]*)\s+");
            using (StreamWriter writer = new StreamWriter("Result.txt"))
            {
                foreach (var item in sentences)
                {
                    writer.WriteLine(item);
                }
                
            }
        }
        public void SearchLongestAndShortestWords()
        {
            string[] sentences = Regex.Split(inputText, @"(?<=[\.!\?]+['\""]*)\s+");
            for (int i = 0; i < sentences.Length; i++)
            {
                var words = sentences[i].Split(" ,.:<>'\"\\/[]{}()%$#@".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var shortestWord = words.Where(s => s.Length == words.Select(s => s.Length).Min()).FirstOrDefault();
                var longestWord = words.Where(s => s.Length == words.Select(s => s.Length).Max()).FirstOrDefault();
                Console.WriteLine("Sentence: "+sentences[i]);
                Console.WriteLine($"The longest word in sentence: {longestWord}");
                Console.WriteLine($"The shortest word in sentence: {shortestWord}\n");
            }
        }
    }
}
