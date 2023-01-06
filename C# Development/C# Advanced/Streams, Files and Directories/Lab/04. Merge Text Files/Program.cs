using System;
using System.IO;

namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            var firstReader = new StreamReader(firstInputFilePath);
            var secondReader = new StreamReader(secondInputFilePath);
            var writer = new StreamWriter(outputFilePath);

            Action<StreamReader, StreamWriter> writeLineFromReader = (reader, writer) =>
            {
                if (!reader.EndOfStream)
                {
                    writer.WriteLine(reader.ReadLine());
                }
            };

            while (!firstReader.EndOfStream || !secondReader.EndOfStream)
            {
                writeLineFromReader(firstReader, writer);
                writeLineFromReader(secondReader, writer);
            }

            writer.Close();
            firstReader.Close();
            secondReader.Close();
        }
    }
}