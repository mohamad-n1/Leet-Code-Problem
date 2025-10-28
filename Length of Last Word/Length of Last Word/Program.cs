using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Length_of_Last_Word
{
    internal class Program
    {
        public static int LengthOfLastWord(string s)
        {
            bool flag = false;
            int counter = 0;
            for (int i = s.Length - 1; i >= 0; i--)
                if (s[i] != 32)
                {
                    counter++;
                    flag = true;
                }
                else if (s[i] == 32 && flag == true)
                    break;
            return counter;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter your Sentence : ");
            string str = Console.ReadLine();
            Console.WriteLine("The Length Of LastWord is {0}",LengthOfLastWord(str));
            Console.ReadKey();
        }


    }
}
