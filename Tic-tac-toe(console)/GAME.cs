using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_tac_toe_console_
{
    class GAME
    {
        private char[] field = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private int player;
 
        private void show_board()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t>> TIC-TAC-TOE <<\n");
            Console.WriteLine("Player1 - X | Player2 - O \n");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  " + field[1] + "  |  " + field[2] + "  |  " + field[3]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  " + field[4] + "  |  " + field[5] + "  |  " + field[6]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  " + field[7] + "  |  " + field[8] + "  |  " + field[9]);
            Console.WriteLine("     |     |     ");
        }

        public void start_game()
        {
            char mark = ' ';
            int choice = 1; 
            int a = 0;
            int i = 0;
            do
            {
                player = 1;
                zero();
                do
                {
                    bool flag = false;

                back0:
                    show_board();
                    
                        try
                        {
                            Console.Write("Player" + (player == 1 ? 1 : 2) + " : ");
                            choice = int.Parse(Console.ReadLine());
                            if (choice <= 0 || choice > 9)
                                throw new ArgumentOutOfRangeException();
                        }
                        catch(ArgumentOutOfRangeException)
                        {
                            Console.Clear();  
                            player = player == 1 ? 1 : 2;
                            goto back0;
                        }
                        catch (FormatException)
                        {
                            Console.Clear();
                            player = player == 1 ? 1 : 2;
                            goto back0;
                        }
                        
                        mark = player == 1 ? 'X' : 'O';

                    if (choice == 1 && field[1] == '1')
                        { field[1] = mark; flag = true; }
                    else if (choice == 2 && field[2] == '2')
                        { field[2] = mark;flag = true; }
                    else if (choice == 3 && field[3] == '3')
                        { field[3] = mark;flag = true; }
                    else if (choice == 4 && field[4] == '4')
                        { field[4] = mark; flag = true; }
                    else if (choice == 5 && field[5] == '5')
                        {field[5] = mark;flag = true; }
                    else if (choice == 6 && field[6] == '6')
                        {field[6] = mark;flag = true; }
                    else if (choice == 7 && field[7] == '7')
                        {field[7] = mark;flag = true; }
                    else if (choice == 8 && field[8] == '8')
                        {field[8] = mark;flag = true; }
                    else if (choice == 9 && field[9] == '9')
                        {field[9] = mark;flag = true; }

                    if(!flag)
                    {
                        goto back0;
                    }
                    i = chech_win();

                    player = player == 1 ? 0 : 1;
                    flag = false;

                } while (i == -1);
                show_board();
                if (i == 1)
                    Console.WriteLine("Win Player" + (player == 1 ? 2 : 1));
                else
                    Console.WriteLine("Draw");

            back:
                try
                {
                    Console.Write(">> If you want to repeat enter 1 : ");
                    a = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    goto back;
                }

            } while (a == 1);
            
            MENU mn = new MENU();
         back2:   
            try
            {
                Console.WriteLine(">> To exit in menu enter 1 <<");
                Console.WriteLine(">> To exit enter 0<<");
                Console.Write(">> Your choice : ");
                a = int.Parse(Console.ReadLine());
                if (a == 1)
                {
                    Console.Clear();
                    mn.show_icon();
                    mn.main_menu();
                }
                else if (a == 0)
                    return;
                else throw new ArgumentOutOfRangeException();
            }
            catch (ArgumentOutOfRangeException)
            {
                goto back2;
            }
            catch(FormatException)
            {
                goto back2;
            }

        }
        private int chech_win()
        {
            if (field[1] == field[2] && field[2] == field[3])
                return 1;
            else if (field[4] == field[5] && field[5] == field[6])
                return 1;
            else if (field[7] == field[8] && field[8] == field[9])
                return 1;
            else if (field[1] == field[4] && field[4] == field[7])
                return 1;
            else if (field[2] == field[5] && field[5] == field[8])
                return 1;
            else if (field[3] == field[6] && field[6] == field[9])
                return 1;
            else if (field[1] == field[5] && field[5] == field[9])
                return 1;
            else if (field[3] == field[5] && field[5] == field[7])
                return 1;
            else if (field[1] != '1' && field[2] != '2' && field[3] != '3'
                  && field[4] != '4' && field[5] != '5' && field[6] != '6'
                  && field[7] != '7' && field[8] != '8' && field[9] != '9')
                return 0;
            else return -1;
        }
        private void zero()
        {
            field[1] = '1'; field[2] = '2'; field[3] = '3';
            field[4] = '4'; field[5] = '5'; field[6] = '6';
            field[7] = '7'; field[8] = '8'; field[9] = '9';
        }
    }
}
