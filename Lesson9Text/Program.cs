using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lesson9Text
{
    internal class Program
    {
        static string isNumber(string researchString)
        {
            char Spliter = ',';
            string pattern = @"[0-9]";
            Regex currencyRegex = new Regex(pattern);


            string[] splt = researchString.Split(Spliter);
            for (int i = 0; i < splt.Length; i++)
            {
                if (currencyRegex.IsMatch(splt[i]))
                {
                    return splt[i];
                }
            }

            return null;
        }

        static string isSurname(string researchString)
        {
            char Spliter = ',';
            string pattern = @"[a-zA-Z]";
            Regex currencyRegex = new Regex(pattern);


            string[] splt = researchString.Split(Spliter);
            if (currencyRegex.IsMatch(splt[0]))
            {
                return splt[0];
            }


            return null;

        }

        static string isName(string researchString)
        {
            char Spliter = ',';
            string pattern = @"[a-zA-Z]";
            Regex currencyRegex = new Regex(pattern);


            string[] splt = researchString.Split(Spliter);
            if (currencyRegex.IsMatch(splt[1]))
            {
                return splt[1];
            }

            return null;
        }







        static string StringSearch (string Allfile, string Keyword, char SplitSymbol)
        {
            string[] splt = Allfile.Split(SplitSymbol);
            for (int i = 0; i < splt.Length; i++)
            {
                if (splt[i].Contains(Keyword))
                {
                    Console.WriteLine($"Number String:{i + 1} {splt[i]}");
                    return splt[i];
                }
            }
            return null;
        }






        static void Main(string[] args)
        {
            Console.WriteLine("Enter keyword (Name, Surname, Phone number)");

            string SearchingName = Console.ReadLine();

            string path = "TextFile1.txt";
            string lines = File.ReadAllText(path);
            char Spliter = '\r';

            StringSearch(lines,SearchingName,Spliter);

        }
    }
}
