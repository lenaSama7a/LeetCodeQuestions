//Divide Two Integers
//Given two integers dividend and divisor, divide two integers without using multiplication, division, and mod operator.
//https://leetcode.com/problems/divide-two-integers/description/
using System;
class Question2
{
    static int divide(int dividend, int divisor)
    {
        if (divisor == Int32.MinValue)
        {
            return dividend == Int32.MinValue ? 1 : 0;
        } 

        if (dividend == Int32.MinValue)
        {
            if (divisor == 1)
            {
                return dividend;
            }
            else if (divisor == -1)
            {
                return Int32.MaxValue;
            }
        }
        else if (dividend == Int32.MaxValue)
        {
            if (divisor == 1)
            {
                return dividend;
            }
            else if (divisor == -1)
            {
                return -dividend;
            }
        }

        long dividendLong = dividend;
        long divisorLong = divisor;

        bool sign = false;
        if (dividendLong < 0 && divisorLong < 0)
        {
            dividendLong = -dividendLong;
            divisorLong = -divisorLong;
        }
        else if (dividendLong < 0 && divisorLong > 0)
        {
            sign = true;
            dividendLong = -dividendLong;
        }
        else if (dividendLong > 0 && divisorLong < 0)
        {
            sign = true;
            divisorLong = -divisorLong;
        }

        long ans = 0;
        while (dividendLong >= divisorLong)
        {
            dividendLong -= divisorLong;
            ans++;
        }

        ans = sign ? -ans : ans;

        return ans > Int32.MaxValue ? Int32.MaxValue : (int)ans;
    }
}