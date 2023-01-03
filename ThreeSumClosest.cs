using System;

namespace TestConsoleApp
{
    /* Three Sum Closest

    Given an integer array nums of length n and an integer target,
    find three integers in nums such that the sum is closest to target.

    Return the sum of the three integers.

    You may assume that each input would have exactly one solution.

    Example 1:
    Input: nums = [-1,2,1,-4], target = 1
    Output: 2
    Explanation: The sum that is closest to the target is 2. (-1 + 2 + 1 = 2).

    Example 2:
    Input: nums = [0,0,0], target = 1
    Output: 0

    Constraints:

    3 <= nums.length <= 1000
    -1000 <= nums[i] <= 1000
    -104 <= target <= 104
    */
    public class ThreeSumClosest
    {
        public int Closest(int[] nums, int target)
        {
            int current = 0, closest = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int ii = i + 1; ii < nums.Length; ii++)
                {
                    for (int iii = ii + 1; iii < nums.Length; iii++)
                    {
                        current = nums[i] + nums[ii] + nums[iii];
                        if (Math.Abs(target - current) < Math.Abs(target - closest))
                            if (target == current)
                                return target;
                            else
                                closest = current;
                        current = 0;
                    }
                }
            }
            return closest;
        }
        public static void Main(string[] a)
        {
            var obj = new ThreeSumClosest();
            Console.WriteLine(obj.Closest(new int[] { -1, 2, 1, -4, 9, 0, 4, 2, -12, 66 }, -10));
        }
    }
}