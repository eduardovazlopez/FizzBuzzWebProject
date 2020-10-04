using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzWebProject.Services
{
    public static class FizzBuzzService
    {
        public static void ExecuteFizzBuzz(IList<string> result, int length = 100)
        {
            for (int i = 1; i <= length; i++)
            {
                result.Add(FizzBuzzSingleOutput(i));
            }
        }

        public static string FizzBuzzSingleOutput(int number)
        {
            if ((number % 3 == 0) && (number % 5 == 0))
                return "FizzBuzz";

            if (number % 3 == 0)
                return "Fizz";

            if (number % 5 == 0)
                return "Buzz";

            return number.ToString();
        }
    }
}
