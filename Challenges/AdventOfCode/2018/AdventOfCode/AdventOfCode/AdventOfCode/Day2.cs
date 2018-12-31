using System.Collections.Generic;
using NUnit.Framework;

namespace AdventOfCode
{
    public class Day2
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestDay2()
        {
            //Load file
            string[] lines = System.IO.File.ReadAllLines(@"C:\temp\repo\CodeChallenges\Challenges\AdventOfCode\2018\Day 2\data.txt");
            int counttwo = 0;
            int countthree = 0;
            foreach (var text in lines)
            {
                Dictionary<char, int> repetition = new Dictionary<char, int>();
                foreach (var word in text)
                {
                    int value;
                    if (!repetition.TryGetValue(word, out value))
                    {
                        repetition.Add(word, 1);
                    }
                    else
                    {
                        repetition[word]++;
                    }
                }

                foreach (var item in repetition)
                {
                    if (item.Value == 2)
                        counttwo++;
                    if (item.Value == 3)
                        countthree++;
                }

            }

            Assert.AreEqual(countthree*counttwo, 18357);
        }
    }
}
