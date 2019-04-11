using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingChallenges
{
    public class BracketsValidation
    {
        /// <summary>
        /// Function that validates the balancing of brackets.
        /// Time Complexity: 
        ///      Worst Case --> O(N) Where N is the number of characters in the string
        ///      Best Case --> O(1) If the sentence starts with a closed bracket ')'
        /// Space Complexity: O(1) The space is fixed: 1 char variable, 1 int variable
        /// </summary>
        /// <param name="stringToValidate"></param>
        /// <param name="openBracketCharacter"></param>
        /// <param name="closedBracketCharacter"></param>
        /// <returns></returns>
        public static bool IsStringValid(string stringToValidate,
                                         char openBracketCharacter, char closedBracketCharacter)
        {
            if (String.IsNullOrEmpty(stringToValidate))
                throw new ArgumentNullException(stringToValidate, "Input value cannot be empty.");

            if (openBracketCharacter == '\0' ||
                closedBracketCharacter == '\0')
                throw new ArgumentNullException("Bracket character values cannot be empty");

            char firstBracketFound = '\0';
            char lastBracketFound = '\0';
            int bracketsCounter = 0;

            for (int i = 0; i < stringToValidate.Length; i++)
            {
                if (stringToValidate[i] == openBracketCharacter)
                {
                    if (firstBracketFound == '\0')
                        firstBracketFound = openBracketCharacter;

                    bracketsCounter += 1;
                    lastBracketFound = openBracketCharacter;
                }
                else if (stringToValidate[i] == closedBracketCharacter)
                {
                    if (firstBracketFound == '\0')
                        return false; // First bracket in string must be an open bracket

                    bracketsCounter -= 1;
                    lastBracketFound = closedBracketCharacter;
                }
            }

            if (bracketsCounter == 0 &&
                lastBracketFound == '\0' || lastBracketFound == closedBracketCharacter)
                return true;

            return false;
        }
    }
}
