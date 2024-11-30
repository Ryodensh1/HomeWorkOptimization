using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string text = "Это пример текста. Текст должен быть проанализирован. Это важно.";
        Dictionary<string, int> wordCounts = WordFrequency(text);

        foreach (var item in wordCounts)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
            Console.ReadKey();
        }
    }

    static Dictionary<string, int> WordFrequency(string text)
    {

        char[] delimiters = { ' ', '.', ',', '!', '?' };
        string[] words = text.ToLower().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (wordCount.ContainsKey(word))
            {
                wordCount[word]++;
            }
            else
            {
                wordCount[word] = 1;
            }
        }

        return wordCount;
    }
}

