using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorevConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Librarian.ImportDictionaries(@"punctuations.txt", @"prefix2.txt");

            string dorevText = System.IO.File.ReadAllText(@"input.txt");
            string modernText = Orthographer.ToModernOrthography(dorevText);

            System.IO.File.WriteAllText(@"output.txt", modernText);
        }
    }
}
