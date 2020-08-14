using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tic_tac_toe_console_
{
    class GAME2:draw_visileca
    {
        private readonly string[] words = { "generous", "light-hearted", "affectionate", "splendid", "exasparated", "irresponsible", "hypothetically", "open-minded", "circumstance","hospitable","incomprehensibilities" };

        private void show_titles_game()
        {
            Console.WriteLine(" >> VISELICA <<\n");
        }
        
        public void start_game_2()
        {
            int n_life = 6;
            Random rand = new Random();

            int choice = rand.Next(0, words.Length - 1);

            char []word = new char[words[choice].Length];
            char [] word_copy = new char[words[choice].Length];
            word_copy = words[choice].ToCharArray();
            

            for (int i = 0; i < words[choice].Length; i++)
            {
                word[i] = '_';
                if (word_copy[i] == '-')
                    word[i] = '-';
            }
            Console.WriteLine();

            char letter;
            int count = 0;
       
            draw_visileca draw = new draw_visileca();
            MENU menu = new MENU();
            do
            {
                Console.Clear();
                show_titles_game();

                Console.Write("[");
                for (int i = 0; i < words[choice].Length; i++)
                {
                    Console.Write(word[i] + " ");
                }
                Console.Write("]");
                Console.Write("\nLife 6/{0}", count);

                switch (count)
                {
                    case 0:
                        { draw.draw_wood(); break; }
                    case 1:
                        { draw.draw_wood(); draw.draw_head(); break; }
                    case 2:
                        { draw.draw_wood(); draw.draw_head(); draw.draw_body(); break; }
                    case 3:
                        { draw.draw_wood(); draw.draw_head(); draw.draw_body(); draw.draw_left_hand(); break; }
                    case 4:
                        { draw.draw_wood(); draw.draw_head(); draw.draw_body(); draw.draw_left_hand(); draw.draw_right_hand(); break; }
                    case 5:
                        { draw.draw_wood(); draw.draw_head(); draw.draw_body(); draw.draw_left_hand(); draw.draw_right_hand(); draw.draw_left_leg(); break; }
                    default:
                        break;
                }

            back:
                try
                {
                    Console.SetCursorPosition(0, 3);
                    Console.Write("\n\nInput letter : ");
                    letter = Console.ReadKey().KeyChar;
                }
                catch(ArgumentException)
                {
                    goto back;
                }
                catch (FormatException)
                {
                    goto back;
                }
                
                bool flag = false;
                
                for (int i = 0; i < word.Length; i++)
                {
                    if (letter == word_copy[i])
                    {
                        word[i] = word_copy[i];
                        Console.Write(word[i]);
                        flag = true; 
                    }
                }
                if (flag == false)
                {
                    ++count;
                }
                if(count==6)
                {
                    Console.SetCursorPosition(0,3);
                    Console.Write("Life 6/6");
                    draw.draw_wood(); draw.draw_head(); draw.draw_body(); draw.draw_left_hand(); draw.draw_right_hand(); draw.draw_left_leg(); draw.draw_right_leg(); break; 
                }

                if(!word.Contains('_'))
                {
                    Console.SetCursorPosition(0, 2);
                    Console.Write("[");
                    for (int i = 0; i < words[choice].Length; i++)
                    {
                        Console.Write(word[i] + " ");
                    }
                    Console.Write("]");
                    break;
                }

            } while (count < n_life);
            if(count<n_life)
            {
                Console.SetCursorPosition(0, 3);
                Console.WriteLine("\n>> You win <<");
            }else
            {
                Console.SetCursorPosition(0, 3);
                Console.WriteLine("\n>> You lose <<");
            }
            Console.SetCursorPosition(0, 4);
            Console.WriteLine("\n>> If you want to exit      |enter 0|\n"
                               +"               to exit_menu |enter 1|");
            back1:
            try
            {
                Console.Write(">>Your choice : ");
                choice = int.Parse(Console.ReadLine());
                if(choice<0||choice>=3)
                {
                    throw new ArgumentException();
                }
            }
            catch(ArgumentException)
            {
                goto back1;
            }
            catch (FormatException)
            {
                goto back1;
            }
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    menu.show_icon();
                    menu.main_menu();
                    break;
                case 0:
                    return;
                default:
                    break;
            }
        }
    }
}
