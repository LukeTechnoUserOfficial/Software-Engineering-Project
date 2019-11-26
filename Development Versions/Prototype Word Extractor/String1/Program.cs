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

			public string Word_Extractor(string head) {
				var sb = new StringBuilder();

				foreach (char c in head)
				{
					if (!char.IsPunctuation(c))
						sb.Append(c);
				}

				head = sb.ToString();
				string notuse = "after a while afterwards at once at this moment at this point before that finally first second third here in the end lastly later on meanwhile next next time now on another occasion previously since soon straightaway then until then when whenever while additionally also as well even furthermore in addition indeed let alone moreover not only alternatively anyway but by contrast differs from elsewhere even so however in contrast in fact in other respects in spite of this in that respect instead nevertheless on the contrary on the other hand rather though whereas yet after all anyway besides moreover besides for example for instance in other words in that that is to say firstly secondly first of all finally lastly for one thing for another in the first place to begin with next in summation to conclude accordingly all the same  an effect of an outcome of an upshot of as a consequence of as a result of because caused by consequently despite this even though hence however in that case moreover nevertheless otherwise so so as stemmed from still then therefore though under the circumstances yet accordingly as a result as exemplified by consequently for example for instance for one thing including provided that since so such as then therefore these include through unless without";
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
					}
					else
					{
						NewList.Add(Word);
					}
				}
				return NewList;
			}


            /*foreach (string Word in NewList)
            {
                Console.WriteLine(Word);
            }*/
        }
    }
}
