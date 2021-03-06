﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Tic_tac_toe_console_
{
    class MENU
    {
        private readonly string[] icon = { "Menu :", ">> [1] Start(Tic-tac-toe)", ">> [2] Start(Visileca)", ">> [3] Exit" };
        private readonly int y = Console.WindowHeight;
        private readonly int x = Console.WindowWidth;
        
        public void show_icon()
        {
            for (int i = 0; i < icon.Length; i++)
            {
                Console.SetCursorPosition(x / 2 - 20, y / 2-5 + i);
                Console.Write(icon[i]);
            }   
        }


        public void main_menu()
        {
            show_icon();
            KeyEvent kevt = new KeyEvent();
            // кнопа
            ConsoleKeyInfo key;
            // обработчик
            char mod=' ';
            kevt.KeyPress += (sender, e) =>
            {
                char ch = e.key.KeyChar;
                if (!char.IsDigit(ch) && ch != '.')
                {
                    e.Handled = true;
                }
                else mod = ch;
            };
           
            key = Console.ReadKey(true);
            // событие произошло
            kevt.OnKeyPress(key);
            
            GAME game = new GAME();
            GAME2 game2 = new GAME2();

            switch (mod)
            {
                case '1':
                    {
                        Console.Clear();
                        game.start_game();
                        break;
                    }
                case '2':
                    {
                        Console.Clear();
                        game2.start_game_2();
                        break;
                    }
                case '3':
                    {
                        break;
                    }
                default:
                    {
                        Console.Clear();
                        show_icon();
                        main_menu();
                        break;
                    }
            }
        }
    
    }
    class myKeyEventArgs : HandledEventArgs
    {
        // нажатая кнопка
        public ConsoleKeyInfo key;
        public myKeyEventArgs(ConsoleKeyInfo _key)
        {
            key = _key;
        }
    }
    // класс события
    class KeyEvent
    {
        // событие нажатия
        public event EventHandler<myKeyEventArgs> KeyPress;
        // метод запуска события
        public void OnKeyPress(ConsoleKeyInfo _key)
        {
            KeyPress(this, new myKeyEventArgs(_key));
        }
    }
}
