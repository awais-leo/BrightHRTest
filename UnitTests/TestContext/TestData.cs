using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.TestContext
{
    public static class TestData
    {
        public static IEnumerable<TestCaseData> SingleItemsAndExpextedResults()
        {
            yield return new TestCaseData("A", 50);
            yield return new TestCaseData("B", 30);
            yield return new TestCaseData("C", 20);
            yield return new TestCaseData("D", 15);
        }

        public static IEnumerable<TestCaseData> MultipleItemsAndExpextedResults()
        {
            yield return new TestCaseData("AA", 100);
            yield return new TestCaseData("AB", 80);
            yield return new TestCaseData("ABC",100);
            yield return new TestCaseData("ABCD",115);
        }
        public static IEnumerable<TestCaseData> MultipleWithDiscountsItemsAndExpextedResults()
        {
            yield return new TestCaseData("AAA", 130);
            yield return new TestCaseData("BB", 45);
            yield return new TestCaseData("AAAA", 180);
            yield return new TestCaseData("BBB", 75);
            yield return new TestCaseData("AAAC", 150);
            yield return new TestCaseData("AAAD", 145);
            yield return new TestCaseData("BBC", 65);
            yield return new TestCaseData("BBD", 60);
            yield return new TestCaseData("AAABB", 175);
            yield return new TestCaseData("BBAAA", 175);
            yield return new TestCaseData("AAAAAA", 260);
            yield return new TestCaseData("BBBB", 90);
        }
    }
}
