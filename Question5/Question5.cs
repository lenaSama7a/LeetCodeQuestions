//https://leetcode.com/problems/add-binary/description/
//Given two binary strings a and b, return their sum as a binary string.

using System;

class Question5
{
    static string AddBinary(string a, string b)
    {
        string result = "";

        int s = 0;

        int i = a.Length - 1, j = b.Length - 1;
        while (i >= 0 || j >= 0 || s == 1)
        {

            s += ((i >= 0) ? a[i] - '0' : 0);
            s += ((j >= 0) ? b[j] - '0' : 0);


            result = (char)(s % 2 + '0') + result;

            s /= 2;

            i--; j--;
        }
        return result;
    }
    public static void Main()
    {
        string a = "1101", b = "100";
        Console.Write(AddBinary(a, b));
    }
}