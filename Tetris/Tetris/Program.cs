using System;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            int x1 = 2;
            int y1 = 3;
            char ch1 = '*';

            Draw(x1, y1, ch1);

            int x2 = 3;
            int y2 = 4;
            char ch2 = '#';

            Draw(x2, y2, ch2);

            Console.ReadLine();

        }

        static void Draw(int x, int y, char ch)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(ch);
        }
    }
}
