using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piratage_Securite_Lab2
{
    public class FileReader
    {
        public FileReader() { }
        public string[] ReadFileLines(string filePath)
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                return lines;
            }
            else
            {
                throw new FileNotFoundException("File not found");
            }
        }
    }
}
