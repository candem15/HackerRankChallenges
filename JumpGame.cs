using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    /* Jump Game

    You are given an integer array nums. You are initially positioned at the array's first index,
    and each element in the array represents your maximum jump length at that position.

    Return true if you can reach the last index, or false otherwise.



    Example 1:
    Input: nums = [2,3,1,1,4]
    Output: true
    Explanation: Jump 1 step from index 0 to 1, then 3 steps to the last index.

    Example 2:
    Input: nums = [3,2,1,0,4]
    Output: false
    Explanation: You will always arrive at index 3 no matter what.
    Its maximum jump length is 0, which makes it impossible to reach the last index.

    */
    public class JumpGame
    {
        public bool CanJump(int[] nums)
        {
            int lastPossibleIndex = nums.Length - 1;
            for (int i = lastPossibleIndex; i >= 0; i--)
            {
                if (i + nums[i] >= lastPossibleIndex)
                    lastPossibleIndex = i;
            }
            if (lastPossibleIndex == 0)
                return true;
            else
                return false;
        }

        public static void Main(string[] args)
        {
            var obj = new JumpGame();
            int[] arr = new int[] { 3, 2, 1, 1, 4 };
            Console.WriteLine(obj.CanJump(arr));
        }
    }
}