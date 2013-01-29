using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashingAlgo
{
    class Program
    {
         static void Main()
        {
            var input = "olacomiesta";
            var substring = "comoesta";
            Console.WriteLine(IsSubstring(input,substring));
            Console.ReadKey();
        }

        public static bool IsSubstring( string input, string substring)
        {
            var output = false;
            var i = 0;
            var max = substring.Length;

            foreach(var c in input)
            {
                if(c == substring[i])
                {
                    i++;
                    if(i == max)
                    {
                        output = true;
                        break;
                    }
                }
                else
                {
                    i = 0;
                }
            }
            return output;
        }
    }
}
