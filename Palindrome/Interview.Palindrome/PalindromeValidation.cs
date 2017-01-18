using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Palindrome
{
    public class PalindromeValidation : IPalindromeValidation
    {
        public bool Validate(string input)
        {
            int idx = 0;

            if (input.Length == 0 || input.Length == 1)
                return true;

            string lowercaseInput = input.ToLower();

            while(idx <= input.Length / 2)
            {
                if (lowercaseInput[idx] != lowercaseInput[input.Length - idx - 1])
                    return false;

                idx++;
            }

            return true;
        }
    }
}
