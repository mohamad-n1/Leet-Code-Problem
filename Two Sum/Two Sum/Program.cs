using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Sum
{
    internal class Program
    {
        static int[] TwoSum(int[] nums, int target)
        {
            int tedad = nums.Length - 1;
            int counter = 0;
            int[] export = {0,0};
            for (int i = 0; i < nums.Length-counter; i++)
            {
                if (nums[i] + nums[tedad] == target)
                {
                    export[0] = i;
                    export[1] = tedad;
                    return export;
                }
                else if (i == tedad-1)
                {
                    tedad--;
                    i = -1;
                    counter++;
                }
            }
            return null;
        }
        static void Main(string[] args)
        {
            int[] InputArray = { 150, 24, 79, 50, 88, 345, 3 }; //your Array
            int[] p=TwoSum(InputArray, 200); //your Target
            Console.WriteLine("{0},{1}", p[0], p[1]);
            Console.ReadKey();
        }

    }
}
