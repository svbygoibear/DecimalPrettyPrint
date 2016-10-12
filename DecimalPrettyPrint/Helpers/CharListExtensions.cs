using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecimalPrettyPrint.Helpers {
    public static class CharListExtensions {
        /// <summary>
        /// Flattens a list of char to a single string.
        /// </summary>
        /// <param name="charItems">List of char</param>
        /// <returns>Single string value</returns>
        public static string flatten(this List<char> charItems) {
            var flattenedString = new StringBuilder();
            charItems.ForEach(item => {
                flattenedString.Append(item);
            });
            return flattenedString.ToString();
        }

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
