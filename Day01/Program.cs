using System;
using System.IO;
using System.Linq;

namespace Day01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input");
            int[] values = lines.Select(l => int.Parse(l)).ToArray();

            // Part One
            int lastValue = values[0];
            int largerCount = 0;
            for (int i = 1; i < values.Length; i++)
            {
                int lineVal = values[i];
                if (lastValue < lineVal)
                    ++largerCount;
                lastValue = lineVal;
            }
            Console.WriteLine("Part one: " + largerCount);


            // Part Two
            int lastSum = values[0] + values[1] + values[2];
            int largerSumCount = 0;
            for (int i = 1; i < values.Length - 2; i++)
            {
                int lineVal = values[i + 0] + values[i + 1] + values[i + 2];
                if (lastSum < lineVal)
                    ++largerSumCount;
                lastSum = lineVal;
            }
            Console.WriteLine("Part two: " + largerSumCount);
        }
    }
}
