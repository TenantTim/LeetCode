using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solutions.LC003
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length <= 1)
            {
                return s.Length;
            }

            int left = 0, right = 0, result = 0;
            Dictionary<char, int> dict = new Dictionary<char, int>();

            while (right < s.Length)
            {
                if (dict.ContainsKey(s[right]))
                {
                    int pivot = dict[s[right]];
                    result = right - left > result ? right - left : result;
                    for (int i = left; i < dict[s[right]]; i++)
                    {
                        dict.Remove(s[i]);
                    }
                    left = pivot + 1;
                }
                dict[s[right]] = right;
                right++;
            }

            result = right - left > result ? right - left : result;
            return result;
        }
    }
}
