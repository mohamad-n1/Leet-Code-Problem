using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace testC_
{
    internal class Program
    {

        static string LongestCommonPrefix(string[] strs)
        {
            string container = strs[0];
            int counter = 1;
            string result = "";
            bool flag = false;
            int k = 0;
            while (counter < strs.Length)
            {
                result = "";
                for (int i = 0; i < container.Length; i++)
                {
                    flag = false;
                    for (int j = i; j < strs[counter].Length && j < container.Length; j++)
                    {

                        if (container[i] == strs[counter][j])
                        {
                            flag = true;
                            result += strs[counter][j];
                            break;
                        }
                        if (result == "")
                            return "";
                        if (result != "" && j == result.Length)/*["aabc", "aacb", "aab"]*/
                            break;
                    }
                    if (flag == false) /*["c", "acc", "ccc"]*/
                        break;
                }
                container = result;
                counter++;
            }
            return container;
        }
        static void Main(string[] args)
        {

            string[] str1 = { "flower", "flow", "flight" };
            string[] str2 = { "dog", "racecar", "car" };
            string[] str3 = { "" };
            string[] str4 = { "cir", "car" };
            string[] str5 = { "c", "acc", "ccc" };
            string[] str6 = { "aa", "ab" };
            string[] str7 = { "abca", "aba", "aaab" };
            string[] str8 = { "aabc", "aacb", "aab" };
            Console.WriteLine("1 " + LongestCommonPrefix(str1));
            Console.WriteLine("2 " + LongestCommonPrefix(str2));
            Console.WriteLine("3 " + LongestCommonPrefix(str3));
            Console.WriteLine("4 " + LongestCommonPrefix(str4));
            Console.WriteLine("5 " + LongestCommonPrefix(str5));
            Console.WriteLine("6 " + LongestCommonPrefix(str6));
            Console.WriteLine("7 " + LongestCommonPrefix(str7));
            Console.WriteLine("8 " + LongestCommonPrefix(str8));
            Console.ReadKey();
        }
    }
}
