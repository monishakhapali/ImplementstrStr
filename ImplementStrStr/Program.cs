using System;
using System.Globalization;

namespace ImplementStrStr
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string haystack = "hello";
            string needle = "ll";
            int res = 0;
            if (haystack.Length < needle.Length)
                res = -1;
            for(int i=0; i < haystack.Length - needle.Length; i++)
            {
                int j;
                for (j=0; j< needle.Length; j++)
                {
                    if(haystack[i+j] != needle[j])
                    {
                        break;
                    }
                }
                if(j== needle.Length)
                {
                    res = i;
                }
            }
            res = -1;
            
            
        }
    }
}
