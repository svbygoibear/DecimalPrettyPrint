using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DecimalPrettyPrint.Helpers;

namespace DecimalPrettyPrint {
    public static class CustomDecimal { //extension class for handling custom decimal modifications
        /// <summary>
        /// Generates a pretty print in decimal values for an integer.
        /// </summary>
        /// <param name="inputs">Integer value</param>
        /// <returns>Formatted string</returns>
        public static string decimalPrettyPrint(this int input) {
            var arr = input.ToString().ToCharArray().ToList();
            var convertedVal = String.Empty;

            for (int i = arr.Count - 1; i >= 0; i = i - 3)
                convertedVal = i < 3 ?
                    $"{arr.flatten()}{convertedVal}" : $",{arr.getCharSubset(3, String.Empty)}{convertedVal}";
            return convertedVal;
        }
    }
}
