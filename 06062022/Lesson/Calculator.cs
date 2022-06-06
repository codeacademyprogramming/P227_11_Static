using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal static class Calculator
    {
        public static int Sum(int num1,int num2)
        {
            return num1 + num2;
        }

        public static int Pow(int num,int pow)
        {
            int result = 1;

            while (pow>0)
            {
                result *= num;
                pow--;
            }

            return result;
        }
    }
}
