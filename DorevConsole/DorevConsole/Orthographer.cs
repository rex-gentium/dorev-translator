using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DorevConsole
{

    static class Orthographer
    {
        public static string ToModernOrthography(string text)
        {
            string[] ttext = text
                .Split(' ')
                .Where(s => s != "")
                .Select(s => new Word(s))
                .Select(word => word.ToModern().ToString())
                .ToArray();
            return string.Join(" ", ttext);
        }
    }
}
