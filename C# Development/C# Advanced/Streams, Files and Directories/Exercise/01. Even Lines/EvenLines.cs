namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class EvenLines
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            var sb = new StringBuilder();
            using (StreamReader streamReader = new StreamReader(inputFilePath))
            {
                string line = string.Empty;
                int count = 0;

                while (!streamReader.EndOfStream)
                {
                    line = streamReader.ReadLine();

                    if (count++ % 2 == 0)
                    {
                        string replacedSymbols = ReplaceSymbols(line);
                        sb.AppendLine(ReverseWords(replacedSymbols));
                    }
                }
            }

            return sb.ToString().TrimEnd();
        }

        private static string ReplaceSymbols(string line)
        {
            char[] symbolsToReplace = { '-', ',', '.', '!', '?' };

            foreach (var symbol in symbolsToReplace)
            {
                line = line.Replace(symbol, '@');
            }

            return line;
        }

        private static string ReverseWords(string replacedSymbols)
        {
            return string.Join(' ', replacedSymbols
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Reverse());
        }
    }
}