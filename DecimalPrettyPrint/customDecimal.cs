using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DecimalPrettyPrint.Helpers;

namespace DecimalPrettyPrint {
    public static class customDecimal { //extension class for handling custom decimal modifications

        /// <summary>
        /// Gets a subset from a list, starting from the left, of char and returns it as a string.
        /// </summary>
        /// <param name="values">List of char</param>
        /// <param name="curr">Amount of characters to return</param>
        /// <param name="res">String to add result to</param>
        /// <returns>String from char list</returns>
        public static string getCharSubset(this List<char> values, int curr, string res) {
            if (curr == 0)
                return res;

            var additional = values[values.Count - 1];
            values.RemoveAt(values.Count - 1);
            return getCharSubset(values, curr - 1, res = $"{additional}{res}");
        }
    }
}
