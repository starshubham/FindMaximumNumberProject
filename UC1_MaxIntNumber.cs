using System;

/*
UC1 - Given 3 Integers find the maximum
- Ensure to test code with the Test Case.
- To ensure your Code works you need 3 test cases with Max Number at 1st, 2nd and 3rd
- Use Integer Object and compareTo method to test the maximum number
*/

namespace FindMaximumNumberProject
{
    public class UC1_MaxIntNumber
    {
        public static int MaximumIntegerNumber(int firstValue, int secondValue, int thirdValue)
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
