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
            if (i % 3 == 0)
            {
                return "Fizz";
            }
            if (i % 5 == 0)
            {
                return "Buzz";
            }
            return i.ToString();
        }
    }
}
