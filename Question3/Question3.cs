//https://leetcode.com/problems/string-to-integer-atoi/
//Implement the myAtoi(string s) function,
//which converts a string to a 32-bit signed integer (similar to C/C++'s atoi function).

using System;

class Question3
{

    static int myAtoi(string str)
{
        int res = 0;
        int sign = 1;
        int intVal;

        int i = 0;

        if (str.Contains('-'))
        {
            sign = -1;
            str.Remove(str.IndexOf('-'));
            i++;
        }

        for (; i < str.Length; ++i)
        {
            intVal = (int)Char.GetNumericValue(str[i]); // it it's letter intVal= -1
            if (intVal <= 9 && intVal >= 0)
            {
                res = res * 10 + intVal;
            }
            else
            {
                continue;
            }
            

        }


        return sign * res;
    }

// Driver code
public static void Main()
{
    string str = "words and 987";

    int val = myAtoi(str);
    Console.Write(val);


    }
}