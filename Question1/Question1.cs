//Link of Question: https://leetcode.com/problems/longest-substring-without-repeating-characters/description/
//Longest Substring Without Repeating Characters
//Given a string s, find the length of the longest substring without repeating characters.
using System;
namespace LeetCodeQuestions
{
    public class Question1
    {
        public static int LengthOfLongestSubstring(String s)
        {
            String tempString = "";
            var maxLength = 0;

            foreach (char c in s.ToCharArray())
            {
                var current = c + "";

                if (tempString.Contains(current))
                {
                    tempString = tempString.Substring(tempString.IndexOf(current) + 1);
                }
                tempString = tempString + c;
                maxLength = Math.Max(tempString.Length, maxLength);
            }
            return maxLength;
        }

        public static void Main(String[] args)
        {
            //String str = "abcabcbb"; //3
            //String str = "bbbbb"; //1
            String str = "pwwkeyw"; //4
            //String str = ""; //0

            int Maxlength = LengthOfLongestSubstring(str);
            Console.WriteLine(Maxlength);
        }
    }
}
