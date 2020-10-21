using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode.Solutions.LC0207
{
    public class Solution
    {
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            if (numCourses == 0)
            {
                return true;
            }

            Dictionary<int, List<int>> ru = new Dictionary<int, List<int>>();
            for (int i = 0; i < numCourses; i++)
            {
                ru[i] = new List<int>();
            }
            for (int i = 0; i < prerequisites.Length; i++)
            {
                List<int> list = null;
                if (ru.ContainsKey(prerequisites[i][0]))
                {
                    list = ru[prerequisites[i][0]];
                }
                else
                {
                    list = new List<int>();
                }
                list.Add(prerequisites[i][1]);
                ru[prerequisites[i][0]] = list;
            }

            int count = 0;
            while (true)
            {
                List<int> courses = ru.Keys.Where(k => ru[k].Count == 0).ToList();
                foreach (int key in courses)
                {
                    ru.Remove(key);
                }
                int[] keys = ru.Keys.ToArray();
                for (int i = 0; i < keys.Length; i++)
                {
                    List<int> list = ru[keys[i]];
                    list.RemoveAll(k => courses.Contains(k));
                    ru[keys[i]] = list;
                }

                count += courses.Count;
                if (count >= numCourses)
                {
                    return true;
                }
                else if (courses.Count == 0)
                {
                    return false;
                }
            }
        }
    }
}
