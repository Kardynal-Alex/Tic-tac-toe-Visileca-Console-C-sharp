using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_tac_toe_console_
{
    class draw_visileca
    {
        private char symbol = '@';
        const int n = 2;
        private readonly int x = Console.WindowWidth;
        private readonly int y = Console.WindowHeight;
        public void draw_wood()
        {
            for (int i = 0; i <= y / 2; i++)
            {
                Console.SetCursorPosition(x / 2, i + 2);
                Console.WriteLine("|");
                Console.SetCursorPosition(x / 2 + i, 1);
                Console.Write("_");
            }
            
            Console.SetCursorPosition(x / 2 + y / 2, 2);
            Console.Write("|");
            Console.SetCursorPosition(x / 2 + y / 2, 3);
            Console.Write("|");
        }
        public void draw_head()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(x / 2 + y / 2 + i, 2 + i / 2 + n);
                Console.Write(symbol);
                Console.SetCursorPosition(x / 2 + y / 2 - i, 2 + i / 2 + n);
                Console.Write(symbol);
                Console.SetCursorPosition(x / 2 + y / 2 + i - 1, 4 + n);
                Console.Write(symbol);
            }
        }
        public void draw_body()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(x / 2 + y / 2, y / 6 + i + n);
                Console.Write(symbol);
            }
        }
        public void draw_left_hand()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(x / 2 + y / 2 - i * 2, y / 6 + i / 2 + 1 + n);
                Console.Write(symbol);
            }
        }
        public void draw_right_hand()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(x / 2 + y / 2 + i * 2, y / 6 + i / 2 + 1 + n);
                Console.Write(symbol);
            }
        }
        public void draw_left_leg()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(x / 2 + y / 2 - i * 2, y / 3 + i + n);
                Console.Write(symbol);
            }
        }
        public void draw_right_leg()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(x / 2 + y / 2 + i * 2, y / 3 + i + n);
                Console.Write(symbol);
            }
        }
    }
}
