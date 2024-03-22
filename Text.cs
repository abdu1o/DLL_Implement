using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL1
{
    public static class Text
    {
        public static bool IsPalindrome(string text)
        {
            int left = 0;
            int right = text.Length - 1;

            while (left < right)
            {
                if (text[left] != text[right])
                {
                    return false;
                }
                    
                left++;
                right--;
            }
            return true;
        }

        public static int Count(string text)
        {
            return text.Length;
        }

    }
}
