using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TDD = Sioen.Kata.FizzBuzz.TDD;

namespace Sioen.Kata.FizzBuzzTest
{
    [TestFixture]
    public class FizzBuzzTest
    {
        [Test, TestCaseSource(typeof(FizzBuzzData), "Generate")]
        public string TestTddFizzBuzz(int i)
        {
            var fizzBuzzer = new TDD.FizzBuzz();
            return fizzBuzzer.CalculateFizzBuzz(i);
        }
    }
}
