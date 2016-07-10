using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn_Arrays_Strings
{
    public class MyLoops
    {
        int[] nums = { 1, 2, 3, 4, 5, 6 };

        // multi-dimensional arrays
        int[,] someNums = { { 2, 3 }, { 5, 6 }, { 4, 6 } };
        int[,] e = new int[3,2]; // 3 rows, 2 columns

        //jagged arrays -> arrays within arrays
        int[][] jaggedArr = new int[3][];
        // OR
        int[][] jaggedArr2 = new int[][]
        {
            new int[] {1, 4, 4, 5, 6},
            new int[] {3, 6, 7, 4},
            new int[] {4, 9, 1}
        };

        //jagged array of 8 2-dimensional arrays
        int[][,] a = new int[8][,];


        public void GetNum()
        {
            foreach (var n in nums)
            {
                if (n % 2 == 0)
                {

                    Console.WriteLine(n);
                }
            }


        }

        public void GetDnum()
        {
            for (int k = 0; k < 3; k++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(someNums[k, j] + " ");
                }

                Console.WriteLine();
            }
        }


    }
}
