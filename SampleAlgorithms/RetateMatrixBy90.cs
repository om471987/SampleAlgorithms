using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[3, 3];
            input[0, 0] = 1;
            input[0, 1] = 2;
            input[0, 2] = 3;

            input[1, 0] = 4;
            input[1, 1] = 5;
            input[1, 2] = 6;
            
            input[2, 0] = 7;
            input[2, 1] = 8;
            input[2, 2] = 9;


            var output = RotateBy90(input);
            for (int i = 0; i < 3; i++)
			{
                for (int j = 0; j < 3; j++)
			    {
                     Console.WriteLine(output[i,j]);
			    }
			}
            Console.ReadKey();
        }



        public static int[,] RotateBy90(int[,] input)
        {
            var output = new int[3,3];

            for (int i = 0; i < 3; i++)
			{
                for (int j = 0; j < 3; j++)
			    {
                    output[j,2-i]=input[i,j];
			    }
			}
            return output;
        }
    }
