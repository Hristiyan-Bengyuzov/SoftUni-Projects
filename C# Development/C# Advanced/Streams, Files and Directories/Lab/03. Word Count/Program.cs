namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            string[] wantedWords;

            using (var reader = new StreamReader(wordsFilePath))
            {
                wantedWords = reader.ReadToEnd().Split();
            } // reading all wanted words

            string[] inputText;
            char[] separators = { ' ', '.', ',', '-', '?', '!' };

            using (var reader = new StreamReader(textFilePath))
            {
                inputText = reader.ReadToEnd().Split(separators);
            } // reading input

            var wordOccurences = new Dictionary<string, int>();

            foreach (var wantedWord in wantedWords)
            {
                foreach (var inputWord in inputText)
                {
                    if (wantedWord.ToLower() == inputWord.ToLower())
                    {
                        if (!wordOccurences.ContainsKey(wantedWord))
                        {
                            wordOccurences.Add(wantedWord, 0);
                        }

                        wordOccurences[wantedWord]++;
                    }
                }
            } // calculating occurences of each wanted word

            using (var writer = new StreamWriter(outputFilePath))
            {
                foreach (var word in wordOccurences.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{word.Key} - {word.Value}");
                }
            } // writing the result in an output file
        }
    }
}