using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreworkAssignment
{
    class Program
    {
        public static void Main()
        {
            //var result = CheckPoint2(4);
            //PrintOut2DMatrix(result);

            var result = CheckPoint3(new[] { 2, 1, 4, 3, 2 }, 4);
            Console.WriteLine(result);
        }

        public static int CheckPoint3(int[] a, int k)
        {
            var currentK = 0;
            var currentValue = -1;

            for (var i = 0; i < a.Length; i++)
                if (currentK < k)
                {
                    if (a[i] >= currentValue)
                    {
                        currentValue = a[i];
                        currentK++;
                    }
                    else
                    {
                        currentK++;
                    }
                }
                else if (a[i] < currentValue)
                    currentValue = a[i];

            return currentValue;
        }

        public static int[,] CheckPoint2(int a)
        {
            var result = new int[2 * a - 1, 2 * a - 1];

            for (var i = a; i > 0; i--)
            {
                for (var col = a - i; col < a + i - 1; col++)
                {
                    result[a - i, col] = i;
                    result[a + i - 2, col] = i;

                    result[col, a - i] = i;
                    result[col, a + i - 2] = i;
                }
            }

            return result;
        }

        public static void PrintOut2DMatrix(int[,] a)
        {
            for (var i = 0; i < a.GetLength(0); i++)
            {
                for (var j = 0; j < a.GetLength(1); j++)
                    Console.Write(a[i, j]);

                Console.WriteLine("");
            }
        }
    }
}
