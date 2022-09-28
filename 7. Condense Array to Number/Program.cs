using System;
using System.Linq;

namespace _7._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            while(nums.Length > 1)
            {
                int[] con = new int[nums.Length - 1];
                for (int i = 0; i < con.Length; i++) { con[i] = nums[i] + nums[i + 1]; }
                nums = con;
            }
            Console.WriteLine(nums[0]);
        }
    }
}
