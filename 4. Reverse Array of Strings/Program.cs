using System;
using System.Collections;

namespace _4._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine() + ' ';
            int strStart = 0;
            Stack strs = new Stack();
            for (int i = 0; i < input.Length; i++)
            {
                string str = "";
                if (input[i] == ' ')
                {
                    for (; strStart < i; strStart++) { str += input[strStart]; }
                    strs.Push(str);
                    strStart++;
                }
            }
            foreach (string item in strs) { Console.Write(item + ' '); }
        }
    }
}
