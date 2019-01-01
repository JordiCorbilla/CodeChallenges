using System;

namespace TestingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] matrix = new char[1000][];
            for (int i = 0; i < 1000; i++)
            {
                matrix[i] = new char[1000];
            }

            for (int i = 0; i < 1000; i++)
            {
                string row = "";
                for (int j = 0; j < 1000; j++)
                {
                    matrix[i][j] = '.';
                    row += matrix[i][j];
                }
                Console.WriteLine(row);
            }

            Console.ReadKey();
        }
    }
}
