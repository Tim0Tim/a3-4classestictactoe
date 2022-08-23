using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using a3_4classestictactoe;

namespace a3_4classestictactoe
{
    internal class Program
    {
        //0,0 = 1
        //1,1 = 5
        //2,2 = 9
        //1 2 3   a
        //4 5 6   b
        //7 8 9   c  will change all numbers to zero when complete
        static void Main()
        {
            TicTacToe ttt = new TicTacToe();
            int player = 0;
            int i = 0;

            while (i < 10)
            {

                Console.Write(ttt.Getboard().GetValue(0, 0)); Console.Write(ttt.Getboard().GetValue(0, 1)); Console.WriteLine(ttt.Getboard().GetValue(0, 2));
                Console.Write(ttt.Getboard().GetValue(1, 0)); Console.Write(ttt.Getboard().GetValue(1, 1)); Console.WriteLine(ttt.Getboard().GetValue(1, 2));
                Console.Write(ttt.Getboard().GetValue(2, 0)); Console.Write(ttt.Getboard().GetValue(2, 1)); Console.WriteLine(ttt.Getboard().GetValue(2, 2));
                if (i == 0)
                {

                    while (player == 0)
                    {
                        Console.WriteLine("Which player will go first? (1 or 2)");
                        player = Int32.Parse(Console.ReadLine());
                        if (player == 1 || player == 2)
                        {
                            Console.WriteLine($"Player {player} starts");
                            ttt.SetTurn(player);
                        }
                        else
                        {
                            player = 0;
                        }
                    }
                }
                int mm = 0;
                //start game here
                while (mm == 0)
                {
                    Console.WriteLine("What Location would you like to use? (a b c = _A_ , 1 2 3 = <>");
                    string choice = Console.ReadLine();
                    if (ttt.GetTic().Contains(choice) == false && ttt.GetOptions().Contains(choice)) //creat tic options
                    {
                        ttt.UseSpot(choice);
                        mm = 1;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input try again");
                    }
                }
                //Console.WriteLine("What Location would you like to use? (a b c = _A_ , 1 2 3 = <>");
                //string choice = Console.ReadLine();
                //        ttt.UseSpot(choice);
                    if (ttt.CheckForWin() != 0)
                    {
                        ttt.SetWinMessage();
                        Console.WriteLine(ttt.GetWinMessage());
                        i = 11;
                    }
                //ttt.SetChangeValue(choice);
                if(ttt.CheckForWin() != 0)
                {
                    int t = player;
                    player = ttt.ChangeTurn(t);
                    Console.WriteLine($"Player {player} turn");
                }

                //Console.WriteLine(1);
               
                

                

                i++;
            }
        }
    }
}
