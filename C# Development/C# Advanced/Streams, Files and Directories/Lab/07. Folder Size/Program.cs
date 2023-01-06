using System.IO;
using System.Linq;

namespace FolderSize
{
    public class FolderSize
    {
        static void Main()
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            DirectoryInfo dir = new DirectoryInfo(folderPath);
            FileInfo[] files = dir.GetFiles("*", SearchOption.AllDirectories);

            // size in bytes
            double sum = files.Sum(f => f.Length);

            using (var writer = new StreamWriter(outputFilePath))
            {
                writer.Write(sum / 1024);
            }
        }
    }
}
