using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piratage_Securite_Lab2
{
    public class FileWriter
    {
        public FileWriter() { }
        public void WriteFileLines(string filePath, string[] lines)
        {
            File.WriteAllLines(filePath, lines);
        }
    }
}
