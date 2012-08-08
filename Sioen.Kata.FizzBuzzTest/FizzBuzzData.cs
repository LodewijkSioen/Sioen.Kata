using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Sioen.Kata.FizzBuzzTest
{
    class FizzBuzzData
    {
        public static IEnumerable<TestCaseData> Generate()
        {
            yield return new TestCaseData(1).Returns("1");
            yield return new TestCaseData(2).Returns("2");
            yield return new TestCaseData(3).Returns("Fizz");
            yield return new TestCaseData(4).Returns("4");
            yield return new TestCaseData(5).Returns("Buzz");
            yield return new TestCaseData(6).Returns("Fizz");
            yield return new TestCaseData(7).Returns("7");
            yield return new TestCaseData(8).Returns("8");
            yield return new TestCaseData(9).Returns("Fizz");
            yield return new TestCaseData(10).Returns("Buzz");
            yield return new TestCaseData(11).Returns("11");
            yield return new TestCaseData(12).Returns("Fizz");
            yield return new TestCaseData(13).Returns("13");
            yield return new TestCaseData(14).Returns("14");
            yield return new TestCaseData(15).Returns("FizzBuzz");
            yield return new TestCaseData(16).Returns("16");
            yield return new TestCaseData(17).Returns("17");
            yield return new TestCaseData(18).Returns("Fizz");
            yield return new TestCaseData(19).Returns("19");
            yield return new TestCaseData(20).Returns("Buzz");            
        }
    }
}
