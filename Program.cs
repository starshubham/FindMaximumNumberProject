using System;

namespace FindMaximumNumberProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC1 - Maximum Integer Number
            Console.WriteLine("Find Max Integer Number!");
            int output = UC1_MaxIntNumber.MaximumIntegerNumber(11, 43, 33);
            Console.WriteLine(output);


            //UC2 - Maximum Double Number
            Console.WriteLine("Find Max Float Number!");
            double DoubleOutput = UC2_MaxFloatNumber.MaximumFloatNumber(11.2, 43.45, 33.45);
            Console.WriteLine(DoubleOutput);


            //UC3 - Maximum Double Number
            Console.WriteLine("Find Max String Number!");
            string StringOutput = UC3_MaxStringNumber.MaximumStringNumber("45", "12", "34");
            Console.WriteLine(StringOutput);


            //Refactor1
            Console.WriteLine("Find Max Integer Number!");
            GenericMaximum<int> generic = new GenericMaximum<int>(112, 344, 432);
            generic.MaxMethod();


            //UC4and5
            int[] intArray = { 112, 344, 432, 555, 678 };
            GenericMax<int> gen = new GenericMax<int>(intArray);
            gen.PrintMaxValue();

            double[] doubleArray = { 11.2, 34.4, 4.32, 55.5, 6.78 };
            GenericMax<double> genDouble = new GenericMax<double>(doubleArray);
            genDouble.PrintMaxValue();

            string[] stringArray = { "111", "222", "333", "55", "999" };
            GenericMax<string> genString = new GenericMax<string>(stringArray);
            genString.PrintMaxValue();
        }
    }
}
