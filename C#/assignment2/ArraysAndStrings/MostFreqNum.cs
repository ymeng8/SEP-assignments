using System;
namespace ArraysAndStrings
{
    public class MostFreqNum
    {
        public void Run(int[] arr)
        {
            Dictionary<int, int> count = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (count.ContainsKey(arr[i]))
                {
                    count[arr[i]] += 1;
                }
                else
                {
                    count.Add(arr[i], 1);
                }
            }

            int maxCount = count.Values.Max();
            List<int> maxNum = new List<int>();
            foreach (KeyValuePair<int, int> kvp in count)
            {
                if (kvp.Value == maxCount)
                {
                    maxNum.Add(kvp.Key);
                }
            }

            if (maxNum.Count == 1)
            {
                Console.WriteLine($"The number {maxNum[0]} is the most frequent (occurs {maxCount} times).");
            }
            else
            {
                Console.WriteLine($"The numbers {String.Join(", ", maxNum)} have the same maximal frequence" +
                    $" (each occurs {maxCount} times). The leftmost of them is {maxNum[0]}.");
            }
        }
    }
}

