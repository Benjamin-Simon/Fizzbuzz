using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using FizzBuzzTDD;

namespace FizzBuzzTests
{
    [TestFixture]
    public class FbProceederTests
    {
        static IEnumerable TestDataFizz
        {
            get
            {
                yield return new TestCaseData(1).Returns(false);
                yield return new TestCaseData(3).Returns(true);
                yield return new TestCaseData(9).Returns(true);
                yield return new TestCaseData(10).Returns(false);
                yield return new TestCaseData(15).Returns(true);
            }
        }

        [Test, TestCaseSource("TestDataFizz")]
        public bool Test_IsFizz(int value)
        {
            return new FbProceeder().IsFizz(value);
        }

        static IEnumerable TestDataBuzz
        {
            get
            {
                yield return new TestCaseData(1).Returns(false);
                yield return new TestCaseData(5).Returns(true);
                yield return new TestCaseData(9).Returns(false);
                yield return new TestCaseData(10).Returns(true);
                yield return new TestCaseData(15).Returns(true);
            }
        }

        [Test, TestCaseSource("TestDataBuzz")]
        public bool Test_IsBuzz(int value)
        {
            return new FbProceeder().IsBuzz(value);
        }

        static IEnumerable TestDataFizzOrBuzz
        {
            get
            {
                yield return new TestCaseData(1).Returns(false);
                yield return new TestCaseData(4).Returns(false);
                yield return new TestCaseData(9).Returns(true);
                yield return new TestCaseData(10).Returns(true);
                yield return new TestCaseData(15).Returns(true);
            }
        }

        [Test, TestCaseSource("TestDataFizzOrBuzz")]
        public bool Test_IsFizzOrBuzz(int value)
        {
            return new FbProceeder().IsFizzOrBuzz(value);
        }

        static IEnumerable TestDataFizzAndBuzz
        {
            get
            {
                yield return new TestCaseData(1).Returns(false);
                yield return new TestCaseData(4).Returns(false);
                yield return new TestCaseData(9).Returns(false);
                yield return new TestCaseData(10).Returns(false);
                yield return new TestCaseData(15).Returns(true);
                yield return new TestCaseData(30).Returns(true);
            }
        }

        [Test, TestCaseSource("TestDataFizzAndBuzz")]
        public bool Test_IsFizzAndBuzz(int value)
        {
            return new FbProceeder().IsFizzAndBuzz(value);
        }

        static IEnumerable TestDataItemModification
        {
            get
            {
                yield return new TestCaseData(1).Returns("1");
                yield return new TestCaseData(4).Returns("4");
                yield return new TestCaseData(9).Returns("Fizz");
                yield return new TestCaseData(10).Returns("Buzz");
                yield return new TestCaseData(15).Returns("FizzBuzz");
                yield return new TestCaseData(30).Returns("FizzBuzz");
            }
        }

        [Test, TestCaseSource("TestDataItemModification")]
        public string Test_ItemModification(int value)
        {
            return new FbProceeder().GetModifiedItem(value);
        }

        static IEnumerable TestDataGetCombinedResult
        {
            get
            {
                yield return new TestCaseData(new[] { 1, 2, 4, 7 }).Returns("1 2 4 7");
                yield return new TestCaseData(new[] { 3, 4, 6, 8 }).Returns("Fizz 4 Fizz 8");
                yield return new TestCaseData(new[] { 2, 4, 5, 10 }).Returns("2 4 Buzz Buzz");
                yield return new TestCaseData(new[] { 2, 3, 5, 7 }).Returns("2 Fizz Buzz 7");
                yield return new TestCaseData(new[] { 3, 5, 15 }).Returns("Fizz Buzz FizzBuzz");
                yield return new TestCaseData(Enumerable.Range(1, 15)).Returns("1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz");
            }
        }

        [Test, TestCaseSource("TestDataGetCombinedResult")]
        public string Test_GetCombinedResult(IEnumerable<int> collection)
        {
            return new FbProceeder().GetCombinedResult(collection);
        }

    }
}
