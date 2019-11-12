using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String1
{
    class Program
    {
        static void Main(string[] args)
        {
            string head = "Learn Git and GitHub without any code!!!!";
            var sb = new StringBuilder();

            foreach (char c in head)
            {
                if (!char.IsPunctuation(c))
                    sb.Append(c);
            }

            head = sb.ToString();
            string notuse = "and no but";
            string[] nousearray = notuse.Split(new string[] { " " }, StringSplitOptions.None);
            List<string> NoUseList = new List<string>();
            NoUseList = nousearray.ToList();

            //char[] title = head.ToCharArray();
            string[] title = head.Split(new string[] { " " }, StringSplitOptions.None);
            List<string> TitleList = new List<string>();
            TitleList = title.ToList();

            List<string> NewList = new List<string>();
            bool IsBadWord = false;

            foreach (string Word in TitleList)
            {
                Console.WriteLine(Word);
                IsBadWord = false;
                foreach (string DontUse in NoUseList)
                {
                    Console.WriteLine(DontUse);
                    if (Word.ToLower() == (DontUse.ToString()).ToLower())
                    {
                        IsBadWord = true;
                    }
                }

                if (IsBadWord)
                {
                    Console.WriteLine("Word Removed: " + Word);
                }
                else
                {
                    Console.WriteLine("Word Added: " + Word);
                    NewList.Add(Word);
                }
            }

            Console.WriteLine("\n\nChosen Words:");

            foreach (string Word in NewList)
            {
                Console.WriteLine(Word);
            }

            Console.ReadLine();
        }
    }
}
