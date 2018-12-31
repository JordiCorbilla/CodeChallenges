using System.Collections.Generic;
using NUnit.Framework;
using NUnit.Framework.Internal.Execution;

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
            Dictionary<char, int> two = new Dictionary<char, int>();
            Dictionary<char, int> three = new Dictionary<char, int>();
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
                    {
                        int value;
                        if (!two.TryGetValue(item.Key, out value))
                            two.Add(item.Key, item.Value);
                        //counttwo++;
                    }

                    if (item.Value == 3)
                    {
                        int value;
                        if (!three.TryGetValue(item.Key, out value))
                            three.Add(item.Key, item.Value);
                        countthree++;
                    }
                }

            }

            Assert.AreEqual(two.Count*three.Count, 494);
        }
    }
}
