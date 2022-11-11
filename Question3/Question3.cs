//https://leetcode.com/problems/string-to-integer-atoi/
//Implement the myAtoi(string s) function,
//which converts a string to a 32-bit signed integer (similar to C/C++'s atoi function).

using System;

class Question3
{

    static int myAtoi(string str)
    {
        double res = 0;
        bool sign = true; // true means +
        int intVal;

        int i = 0;
        str = str.TrimStart();

        if (string.IsNullOrEmpty(str))
        {
            return 0;
        }
        if (str[0] == '-')
        {
            sign = false;
            i++;
        }
        else if (str[0] == '+')
        {
            sign = true;
            i++;
        }

        for (; i < str.Length; ++i)
        {
            intVal = (int)Char.GetNumericValue(str[i]); // if it's letter intVal= -1
            if (intVal <= 9 && intVal >= 0)
            {
                res = res * 10 + intVal;
            }
            else
            {
                break;
            }
        }
        if (sign == false)
        {
            res = -res;
        }

        if (res > Int32.MaxValue)
        {
            return Int32.MaxValue;
        }

        if (res < Int32.MinValue)
        {
            return Int32.MinValue;
        }

        return (int)res;
    }

public static void Main()
{
    //string str = "words and 987";
    //string str = " ";
    string str = "9999999999999999999999999";

    int val = myAtoi(str);
    Console.Write(val);


    }
}