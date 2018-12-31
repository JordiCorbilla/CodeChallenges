using System.Collections.Generic;
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
        public void TestDay1Part1()
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

        [Test]
        public void TestDay1Part2()
        {
            //Load file
            string[] lines = System.IO.File.ReadAllLines(@"C:\temp\repo\CodeChallenges\Challenges\AdventOfCode\2018\Day 1\data.txt");
            List<int> frequencies = new List<int>();
            int frequency = 0;
            foreach (var line in lines)
            {
                int freq = 0;
                if (line.Contains("-"))
                {
                    string number = line.Replace("-", "");
                    freq = int.Parse(number);
                    freq = freq * -1;
                }
                else if (line.Contains("+"))
                {
                    string number = line.Replace("+", "");
                    freq = int.Parse(number);
                }

                frequencies.Add(freq);
            }

            //Now we have a list of frequencies.
            Dictionary<int, bool> frequencyReached = new Dictionary<int, bool>();
            bool found = false;
            do
            {
                foreach (var item in frequencies)
                {
                    frequency += item;
                    bool value;
                    if (!frequencyReached.TryGetValue(frequency, out value))
                    {
                        frequencyReached.Add(frequency, true);
                    }
                    else
                    {
                        //Frequency found twice
                        //exit loop
                        found = true;
                        break;
                    }
                }
            } while (!found);


            Assert.AreEqual(frequency, 71961);
        }
    }
}