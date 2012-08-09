using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sioen.Kata.FizzBuzz.TDD
{
    public class FizzBuzz
    {
        public string CalculateFizzBuzz(int i)
        {
            var returnValue = new StringBuilder();
            if (i % 3 == 0)
            {
                returnValue.Append("Fizz");
            }
            if (i % 5 == 0)
            {
                returnValue.Append("Buzz");
            }
            if (returnValue.Length > 0)
            {
                return returnValue.ToString();
            }
            return i.ToString();
        }
    }
}
