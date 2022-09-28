using System;
using System.Collections.Generic;

namespace _3._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine() + ' ';
            int numStart = 0;
            List<double> nums = new List<double>();
            for (int i = 0; i < input.Length; i++)
            {
                string num = "";
                if (input[i] == ' ') 
                { 
                    for (; numStart < i; numStart++) { num += input[numStart]; }
                    nums.Add(double.Parse(num));
                }
            }
            foreach(double i in nums) { Console.WriteLine(Math.Round(i, 0, MidpointRounding.AwayFromZero)); }
        }
    }
}
