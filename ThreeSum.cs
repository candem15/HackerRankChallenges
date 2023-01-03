using System;
using System.Collections.Generic;
using System.Linq;

namespace TestConsoleApp
{
    /* 3Sum

    Given an integer array nums,
    return all the triplets [nums[i], nums[j], nums[k]] such that
    i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

    Notice that the solution set must not contain duplicate triplets.

    Example 1:

    Input: nums = [-1,0,1,2,-1,-4]
    Output: [[-1,-1,2],[-1,0,1]]
    Explanation:
    nums[0] + nums[1] + nums[1] = (-1) + 0 + 1 = 0.
    nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
    nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
    The distinct triplets are [-1,0,1] and [-1,-1,2].
    Notice that the order of the output and the order of the triplets does not matter.

    Example 2:
    Input: nums = [0,1,1]
    Output: []
    Explanation: The only possible triplet does not sum up to 0.

    Example 3:
    Input: nums = [0,0,0]
    Output: [[0,0,0]]
    Explanation: The only possible triplet sums up to 0.


    Constraints:

    3 <= nums.length <= 3000
    -105 <= nums[i] <= 105

    */
    public class ThreeSum
    {
        public IList<IList<int>> Sum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            int sum = 0, current = 0;
            List<int> input = new List<int>(nums);
            input.Sort();
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (i > 0)
                {
                    while (input[i - 1] == input[i] & i + 1 < nums.Length - 1)
                    {
                        i++;
                    }
                }
                int leftPointer = i + 1, rightPointer = nums.Length - 1;
                while (leftPointer < rightPointer)
                {
                    current = input[i] + input[leftPointer] + input[rightPointer];
                    if (current < 0)
                    {
                        leftPointer++;
                    }
                    else if (current > 0)
                    {
                        rightPointer--;
                    }
                    else if (current == 0)
                    {
                        result.Add(new List<int> { input[i], input[leftPointer], input[rightPointer] });
                        leftPointer++;
                        while (input[leftPointer] == input[leftPointer - 1] & leftPointer < rightPointer)
                            leftPointer++;
                    }
                }
            }
            return result;
        }
        public static void Main(string[] a)
        {
            var obj = new ThreeSum();
            Console.WriteLine(obj.Sum(new int[] { -1, 0, 1, 2, -1, -4, -2, -3, 3, 0, 4 }).Count);
        }
    }
}