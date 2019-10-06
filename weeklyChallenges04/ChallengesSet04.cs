using System;
using System.Collections.Generic;
namespace weeklyChallenges04
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int z = 0;
            foreach (int x in numbers)
            {
                if (x % 2 == 0)
                    z += x;
                else
                    z -= x;
            }
            return z;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int strl1 = str1.Length;
            int strl2 = str2.Length;
            int strl3 = str3.Length;
            int strl4 = str4.Length;
            int shortest = 0;
            if (strl1 > strl2)
                shortest = strl2;
            else
                shortest = strl1;
            if (shortest > strl3)
                shortest = strl3;
            if (shortest > strl4)
                shortest = strl4;
            return shortest;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int smallest = 0;
            if (number1 > number2)
                smallest = number2;
            else
                smallest = number1;
            if (smallest > number3)
                smallest = number3;
            if (smallest > number4)
                smallest = number4;
            return smallest;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 && sideLength2 + sideLength3 > sideLength1)
                return true;
            else
                return false;
        }

        public bool IsStringANumber(string input)
        {
            double x = 0;
            bool result = double.TryParse(input, out x);
            return result;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int total = 0;
            foreach (object x in objs)
            {
                if (x == null)
                    total += 1;
            }
            if (total > (objs.Length - total))
                return true;
            else
                return false;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return 0;
            int oddint = 0;
            foreach (int x in numbers)
            {
                if (x % 2 != 0)
                    oddint += 1;
                if (oddint == numbers.Length)
                    return 0;
            }
            double total = 0;
            double it = 0;
            foreach (int x in numbers)
            {
                if (x % 2 == 0)
                {
                    total += x;
                    it++;
                }
                else
                    total += 0;
            }
            return total / it;

        }

        public int Factorial(int number)
        {
            int total = 1;
            if (number < 0)
                throw new ArgumentOutOfRangeException();

            if (number == 0)
                return 1;
            for (int i = 1; i <= number; i++)
                total *= i;
            return total;
        }
    }

}
