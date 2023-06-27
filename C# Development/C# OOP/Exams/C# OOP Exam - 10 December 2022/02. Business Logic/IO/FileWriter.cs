using ChristmasPastryShop.IO.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ChristmasPastryShop.IO
{
    public class FileWriter : IWriter
    {
        public FileWriter()
        {
            using (var writer = new StreamWriter("../../../output.txt", false))
            {
                writer.Write("");
            }
        }

        public void Write(string message)
        {
            using (var writer = new StreamWriter("../../../output.txt", true))
            {
                writer.Write(message);
            }
        }

        public void WriteLine(string message)
        {
            using (var writer = new StreamWriter("../../../output.txt", true))
            {
                writer.WriteLine(message);
            }
        }
    }
}
