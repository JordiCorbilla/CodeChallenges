﻿using System;
using System.Diagnostics;
using System.Globalization;

namespace TestingConsole
{
    class Program
    {
        public static char[][] Matrix;

        static void Main(string[] args)
        {
            Matrix = new char[1000][];
            for (int i = 0; i < 1000; i++)
            {
                Matrix[i] = new char[1000];
            }

            //Load the data
            string[] lines = System.IO.File.ReadAllLines(@"C:\temp\repo\CodeChallenges\Challenges\AdventOfCode\2018\Day 3\data.txt");

            //Parse the data
            foreach (var item in lines)
            {
                var tokens = item.Split(' ');
                int left = 0;
                int top = 0;
                int width = 0;
                int height = 0;
                foreach (var token in tokens)
                {
                    if (token.Contains(","))
                    {
                        var positions = token.Split(",");
                        left = int.Parse(positions[0]);
                        top = int.Parse(positions[1].Replace(":", ""));
                    }

                    if (token.Contains("x"))
                    {
                        var positions = token.Split("x");
                        width = int.Parse(positions[0]);
                        height = int.Parse(positions[1]);
                    }
                }

                PopulateMatrix(left, top, width, height);

            }

            RenderMatrix();
            FlushMatrix();
            Console.ReadKey();
        }

        public static void PopulateMatrix(int left, int top, int width, int height)
        {
            for(int i=left; i<left+width; i++)
            {
                for(int j=top; j<top+height; j++)
                {
                    if (Matrix[i][j] != '.')
                        Matrix[i][j] = 'x';
                    else
                        Matrix[i][j] = '+';
                }
            }
        }

        public static void RenderMatrix()
        {
            for (int i = 0; i < 1000; i++)
            {
                string row = "";
                for (int j = 0; j < 1000; j++)
                {
                    Matrix[i][j] = '.';
                    row += Matrix[i][j];
                }
                Console.WriteLine(row);
            }
        }

        public static void FlushMatrix()
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\temp\repo\CodeChallenges\Challenges\AdventOfCode\2018\Day 3\Matrix.txt"))
            {
                for (int i = 0; i < 1000; i++)
                {
                    string row = "";
                    for (int j = 0; j < 1000; j++)
                    {
                        Matrix[i][j] = '.';
                        row += Matrix[i][j];
                    }
                    file.WriteLine(row);
                }
            }
        }
    }
}
 