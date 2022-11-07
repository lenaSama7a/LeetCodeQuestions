//Divide Two Integers
//Given two integers dividend and divisor, divide two integers without using multiplication, division, and mod operator.
//https://leetcode.com/problems/divide-two-integers/description/
using System;
class Question2
{
    static long divide(long dividend, long divisor)
    {
        int sign;
        if ((dividend < 0) ^ (divisor < 0)) // ^ : XOR
            sign = -1;
        else
            sign = 1;

        dividend = Math.Abs(dividend);
        divisor = Math.Abs(divisor);

        long quotient = 0;

        while (dividend >= divisor)
        {
            dividend -= divisor;
            ++quotient;
        }

        if (sign == -1)
            quotient = -quotient;

        return quotient;
    }

    public static void Main()
    {

        long a = 10;
        long b = 3;
        Console.WriteLine(divide(a, b)); // 3

        a = -7;
        b = 3;
        Console.WriteLine(divide(a, b)); // -5
    }
}