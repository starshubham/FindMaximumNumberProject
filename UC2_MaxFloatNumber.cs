using System;

/*
UC2 - Given 3 Floats find the maximum
- Ensure to test code with the Test Case and repeat with the similar 3 Test cases in UC 1
*/

namespace FindMaximumNumberProject
{
    class UC2_MaxFloatNumber
    {
        public static double MaximumFloatNumber(double firstValue, double secondValue, double thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            throw new Exception("firstNumber, SecondNumber, thirdNumber are same");
        }
    }
}
