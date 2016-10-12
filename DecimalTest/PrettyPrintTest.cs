using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using DecimalPrettyPrint;

namespace DecimalTest {
    [TestClass]
    public class PrettyPrintTest {
        [TestMethod]
        public void TestPrettyPrint() {
            var inputs = new List<int> { 1, 10, 100, 1000, 10000, 100000, 1000000, 35235235 };
            var result = new List<string>();
            var expected = new List<string> {"1", "10","100", "1,000", "10,000", "100,000", "1,000,000", "35,235,235" };

            inputs.ForEach(input => {
                result.Add(input.decimalPrettyPrint());
            });
        }
    }
}
