using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    /* Make a Rectangle
    Problem Statement
    Snuke wants to select four different sticks from these sticks and form a rectangle (including a square), using the sticks as its sides. Find the maximum possible area of the rectangle.

    Sample Input 1
    6
    3 1 2 4 2 1
    Sample Output 1
    2
    1×2 rectangle can be formed.

    Sample Input 2
    4
    1 2 3 4
    Sample Output 2
    0
    No rectangle can be formed.

    Sample Input 3
    10
    3 3 3 3 4 4 4 5 5 5
    Sample Output 3
    20
    */
    public class MakeARectangle
    {
        public static long rectangleCount(int N, int[] bufs)
        {
            int[] A = new int[N];

            for (int i = 0; i < N; i++)
            {
                A[i] = bufs[i];
            }

            Array.Sort(A);

            int cnt = 0;
            int width = 0;
            int height = 0;
            int idx = N - 1;
            int seq = 0;
            int cur = 0;

            while (cnt < 2 && idx >= 0)
            {
                if (seq > 0 && A[idx] == A[cur])
                {
                    if (cnt == 0)
                    {
                        width = A[idx];
                    }
                    else if (cnt == 1)
                    {
                        height = A[idx];
                    }
                    seq = 0;
                    cnt++;
                }
                else
                {
                    seq = 1;
                    cur = idx;
                }

                idx--;
            }

            return (long)width * height;
        }

        public static void Main(string[] args)
        {
            var arr = new int[] { 3, 3, 3, 3, 4, 4, 4, 5, 5, 5 };
            Console.WriteLine(rectangleCount(10, arr));
            Console.Read();
        }
    }
}