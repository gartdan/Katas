using System;
using System.Linq;

namespace SumTwoNumbersThatAreArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Sum(new int[] { 5, 5, 9 }, new int[] { 2, 7, 6 });
            result.ToList().ForEach(x => Console.Write(x));
            Console.ReadKey();
            result = Sum(new int[] { 7, 8, 9 }, new int[] { 9, 8, 7 });
            result.ToList().ForEach(x => Console.Write(x));
            Console.ReadKey();
        }

        /// <summary>
        /// Input: [5,5,9] + [2,7,6] = [ 8,3,5]
        /// Input: [7,8,9] + [9,8,7] = [1,7,7,6]
        /// Assumes the arrays are the same length
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int[] Sum(int[] num1, int[] num2)
        {
            int[] result = new int[num1.Length+1];
            bool carryTheOne = false;
            for(var i=num1.Length-1; i>=0; i--)
            {
                int temp = num1[i] + num2[i];
                if (carryTheOne) temp += 1;
                if (temp >= 10)
                {
                    result[i+1] = temp % 10;
                    carryTheOne = true;
                }
                else
                {
                    result[i+1] = temp;
                    carryTheOne = false;
                }
            }
            if (carryTheOne) result[0] = 1;
            return result;
        }
    }
}
