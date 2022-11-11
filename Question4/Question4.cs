//https://leetcode.com/problems/search-insert-position/description/
//Given a sorted array of distinct integers and a target value,
//return the index if the target is found. If not, return the index where it would be if it were inserted in order.
//You must write an algorithm with O(log n) runtime complexity.

using System;
class Question4
{
    static int SearchInsert(int[] nums, int target)
    {

        int n = nums.Length;
        int start = 0;
        int end = n - 1;

        while (start <= end)
        {
            int mid = (start + end) / 2;

            if (nums[mid] == target)
                return mid;

            else if (nums[mid] < target)
                start = mid + 1;

            else
                end = mid - 1;
        }

        return end + 1;
    }

    public static void Main()
    {
        int[] num = { 1, 3, 5, 6 };
        int target = 5;

        Console.WriteLine(SearchInsert(num, target));
    }
}
