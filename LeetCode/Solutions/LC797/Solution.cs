using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Solutions.LC797
{
    public class Solution
    {
        public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            IList<IList<int>> result = new List<IList<int>>();
            IList<int> init = new List<int> { 0 };
            result.Add(init);

            bool flag = false;
            while (true)
            {
                for (int i = result.Count - 1; i >= 0; i--)
                {
                    if (result[i][result[i].Count - 1] == graph.Length - 1)
                    {
                        continue;
                    }
                    else
                    {
                        foreach (int k in graph[result[i][result[i].Count - 1]])
                        {
                            IList<int> newList = result[i].Append(k).ToList();
                            result.Add(newList);
                        }
                        result.RemoveAt(i);
                        flag = true;
                    }
                }

                if (!flag)
                {
                    break;
                }
                else
                {
                    flag = false;
                }
            }

            return result;
        }
    }
}
