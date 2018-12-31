using System.Runtime.InteropServices.ComTypes;
using NUnit.Framework;

namespace AdventOfCode
{
    public class Day1
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestDay1()
        {
            //Load file
            string[] lines = System.IO.File.ReadAllLines(@"C:\temp\repo\CodeChallenges\Challenges\AdventOfCode\2018\Day 1\data.txt");
            int frequency = 0;
            foreach (var line in lines)
            {
                int freq = 0;
                if (line.Contains("-"))
                {
                    string number = line.Replace("-", "");
                    freq = int.Parse(number);
                    freq = freq * -1;
                } else if (line.Contains("+"))
                {
                    string number = line.Replace("+", "");
                    freq = int.Parse(number);
                }

                frequency += freq;
            }
            Assert.AreEqual(frequency, 502);
        }
    }
}