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

        public static List<string> AllWord = File.ReadAllLines(@"dictionary.txt", Encoding.GetEncoding(1251)).ToList();


        public static string FindWord(string mask)
        {
            Regex regex = new Regex("^" + Regex.Replace(mask, "#*", m => $@"\p{{L}}{{{m.Length}}}") + "$");

            
            string[] a = AllWord.Where(x => regex.IsMatch(x)).ToArray();
            Random random = new Random();
            int i = random.Next(a.Length);
            return a[i];
        }
    }
}