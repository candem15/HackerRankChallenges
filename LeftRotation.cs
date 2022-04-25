using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    /*
    A left rotation operation on an array shifts
    each of the array's elements 1 unit to the left.
    For example, if 2 left rotations are performed on array [1,2,3,4,5],
    then the array would become [3,4,5,1,2].
    Note that the lowest index item moves to the highest index in a rotation.
    This is called a circular array.

    Given an array a of n integers and a number, d, perform d left rotations on the array.
    Return the updated array to be printed as a single line of space-separated integers.

    Sample Input:

    5 4
    1 2 3 4 5

    Sample Output:

    5 1 2 3 4
    */
    public class LeftRotation
    {
        public static List<int> rotLeft(List<int> a, int d)
        {
            var result = new int[a.Count];
            int move = a.Count - d;
            for (int i = 0; i < a.Count; i++)
            {
                result[(i + move) % a.Count] = a[i];
            }
            return result.ToList();
        }

        public static void Main(string[] args)
        {
            var list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            List<int> result = rotLeft(list, 4);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}

