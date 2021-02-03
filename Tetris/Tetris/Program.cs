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
            //char ch1 = '*';

            Console.SetCursorPosition(x1,y1);
            //Console.WriteLine(ch1);

            Console.ReadLine();

        }
    }
}
