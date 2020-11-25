using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas24
{
    class FileX
    {
        private static string FileName = @"C:\Kurs\vezba.txt";
        public static void Write(params string[] InputData)
        {
            using(StreamWriter FileHandle = new StreamWriter(FileName, true))
            {
                FileHandle.WriteLine("{0}", String.Join(";", InputData));
            }

        }
    }
}
