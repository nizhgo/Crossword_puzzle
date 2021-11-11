using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Crossword_puzzle
{
    static class Dictionary
    {

        public static List<string> AllWord = File.ReadAllLines("@dictionary.txt").ToList();


        public static string[] Variants(string mask, IEnumerable<string> availableWords)
        {
            Regex regex = new Regex("^" + Regex.Replace(mask, "#*", m => $@"\p{{L}}{{{m.Length}}}") + "$");

            return availableWords
              .Where(word => regex.IsMatch(availableWords.ToString()))
              .OrderBy(word => word)
              .ToArray();
        }
    }
}
