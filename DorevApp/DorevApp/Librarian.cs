using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DorevApp
{
    static class Librarian
    {
        static string comment = "//";
        public static List<char> Punctuations;      // знаки препинания
        public static List<string> Prefixes2;      // приставки второго рода

        public static void ImportDictionaries(string punctuationsFile, string prefixesFile)
        {
            ImportPunctuations(punctuationsFile);
            ImportPrefixes(prefixesFile);
        }

        public static void ImportPrefixes(string filename)
        {
            string[] text = System.IO.File.ReadAllLines(filename);
            Prefixes2 = text.Where(s => !s.StartsWith(comment)).ToList();
        }

        public static void ImportPunctuations(string filename)
        {
            string[] text = System.IO.File.ReadAllLines(filename);
            Punctuations = text.Where(s => !s.StartsWith(comment)).Select(s => s[0]).ToList();
        }

        public static bool IsPunctiationSign(char sign)
        {
            foreach (char punc in Punctuations)
            {
                if (sign == punc)
                    return true;
            }
            return false;
        }
    }
}
