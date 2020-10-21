using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solutions.LC0395
{
    public class Solution
    {
        public int LongestSubstring(string s, int k)
        {
            if (k <= 1)
            {
                return s.Length;
            }

            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int[] mapping = new int[26];
                for (int j = 0; j < 26; j++)
                {
                    mapping[j] = 0;
                }

                for (int j = i; j < s.Length; j++)
                {
                    mapping[s[j] - 'a']++;

                    if (TestMapping(mapping, k))
                    {
                        if (j - i + 1 > result)
                        {
                            result = j - i + 1;
                        }
                    }

                }
            }

            return result;
        }

        private bool TestMapping(int[] mapping, int k)
        {
            for (int i = 0; i < mapping.Length; i++)
            {
                if (mapping[i] > 0 && mapping[i] < k)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
