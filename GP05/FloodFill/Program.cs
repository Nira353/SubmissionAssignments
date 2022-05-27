using System;

namespace Assignement4
{
    class FloodFill
    {
        static int[,] matrix = { { 1, 0, 0, 1, 1},
                                 { 1, 0, 0, 0, 1},
                                 { 0, 0, 0, 0, 1},
                                 { 0, 0, 0, 0, 0},
                                 { 1, 0, 0, 0, 1}};

        static void Main(string[] args)
        {
            Console.WriteLine("Before");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            }

            Fill(2, 2, 3);

            Console.WriteLine("After");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            }
        }

        static void Fill(int _x, int _y, int newN)
        {
            int prevN = matrix[_x, _y];
            Flood(_x, _y, prevN, newN);
        }

        static void Flood( int _x, int _y, int _prevN, int _newN)
        {
            if (_x < 0 || _x > 4 || _y < 0 || _y > 4) return;
            if (_prevN == _newN || matrix[_x, _y] != _prevN) return;

            matrix[_x, _y] = _newN;

            Flood(_x + 1, _y, _prevN, _newN);
            Flood(_x - 1, _y, _prevN, _newN);
            Flood(_x, _y + 1, _prevN, _newN);
            Flood(_x, _y - 1, _prevN, _newN);
        }
    }
}
