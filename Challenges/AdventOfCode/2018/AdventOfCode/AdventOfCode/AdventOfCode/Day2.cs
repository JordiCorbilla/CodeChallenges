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
        public void TestDay2Part1()
        {
            //Load file
            string[] lines = System.IO.File.ReadAllLines(@"C:\temp\repo\CodeChallenges\Challenges\AdventOfCode\2018\Day 2\data.txt");
            int counttwo = 0;
            int countthree = 0;


            foreach (var word in lines)
            {
                var letterCounts = new Dictionary<char, int>();

                bool doubleFound = false;
                bool tripleFound = false;

                foreach (char c in word)
                {
                    letterCounts.TryGetValue(c, out var current);
                    letterCounts[c] = current + 1;
                }

                foreach (var count in letterCounts.Values)
                {
                    if (count == 2 && !doubleFound)
                    {
                        doubleFound = true;
                        ++counttwo;
                    }
                    else if (count == 3 && !tripleFound)
                    {
                        tripleFound = true;
                        ++countthree;
                    }
                }
            }

            Assert.AreEqual(counttwo*countthree, 7163);
        }

        [Test]
        public void TestDay2Part2()
        {
            //Load file
            string[] lines = System.IO.File.ReadAllLines(@"C:\temp\repo\CodeChallenges\Challenges\AdventOfCode\2018\Day 2\data.txt");

            string totalwords = "";
            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = i + 1; j < lines.Length; j++)
                {
                    //compare two strings
                    string box = lines[i];
                    string nextBox = lines[j];
                    int distance = DistancebetweenBoxes(box, nextBox, out var same);
                    if (distance == 1)
                    {
                        totalwords += same;
                    }
                }
            }

            Assert.AreEqual(totalwords, "ighfbyijnoumxjlxevacpwqtr");
        }

        public int DistancebetweenBoxes(string box, string nextBox, out string same)
        {
            int difference = 0;
            same = "";
            for (int i = 0; i < box.Length; i++)
            {
                if (box[i] != nextBox[i])
                {
                    difference++;
                }
                else
                {
                    same += box[i];
                }
                    
            }

            return difference;
        }
    }
}
