using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAlgorithms
{
    public static class Array
    {
        public static void FindDuplicate()
        {
            var input = new List<int> { 4, 5, 7, 1, 7, 2, 3 };
            var duplicate = 0; ;
            for (int i = 1; i < input.Count + 1; i++)
            {
                var valueinvalue = input[input[i - 1] - 1];
                var value = input[i - 1];
                if (valueinvalue == value)
                {
                    duplicate = value;
                    break;
                }
                var temp = input[value - 1];
                input[value - 1] = value;
                input[i - 1] = temp;
            }

        }

        public static void AdjecentSort()
        {
            var input = new List<int> { 1, 0, 0, 1, 1, 0, 0 };
            var zeroTracker = 0;
            var swap = 0;
            for (int i = 1; i < input.Count; i++)
            {
                if (input[i] == 0)
                {
                    var j = i;
                    while (j > zeroTracker)
                    {
                        var temp = input[j];
                        input[j] = input[j - 1];
                        input[j - 1] = temp;
                        swap++;
                        j--;
                    }
                    zeroTracker++;
                }

            }
            input = new List<int> { 1, 0, 0, 1, 1, 0, 0 };
            swap = 0;
            var count = 0;
            for (var j = input.Count - 1; j >= 1; j--)
            {
                if (input[j] == 0)
                    count++;
                else
                    swap += count;
            }
        }

        public static void SubsetSum()
        {
            var input = new List<int> { 1, 0, 0, 1, 1, 0, 0 };
            var flag = false;
            var max = -9999;
            var dynamicContainer = 0;
            for (int i = 0; i < input.Count; i++)
            {
                if (i == 0 || flag)
                {
                    dynamicContainer = input[i];
                    flag = false;
                    continue;
                }
                if (dynamicContainer <= (dynamicContainer + input[i]))
                {
                    dynamicContainer += input[i];
                    continue;
                }
                else
                    flag = true;
                if (max < dynamicContainer)
                    max = dynamicContainer;
            }
        }

        public static void sort()
        {
            var input = new List<int> { 1, 0, 0, 1, 1, 0, 0 };
            for (int i = 0, j = input.Count - 1; i <= j; )
            {
                if (input[i] < 0)
                {
                    i++;
                }
                else
                {
                    var temp = input[i];
                    input[i] = input[j];
                    input[j] = temp;
                    j--;
                }
            }
        }
    }
}
