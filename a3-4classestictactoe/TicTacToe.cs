﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a3_4classestictactoe
{
    public class TicTacToe
    {
        private int _turn;
        private string _used;
        private int p1w = 0; // player one wins if = 1
        private int p2w = 0; // player two wins if = 1
        private int draw = 0;
        private int[,] Tic = new int[3, 3];
        private string wmess;
        private string value;

        private List<string> Usabletic;
        public TicTacToe()
        {
            int[,] Tic = new int[,]{
            { 0, 0, 0 }, {0,0,0}, {0,0,0}
            };
            _used = "";
            Usabletic = new List<string>();
            //Tic = new int[,];
        }

        public int[,] Getboard()
        {
            //int[,] tic2 = Tic;
            //return tic2; 
            return Tic;
        }

        public int ChangeTurn(int turn)
        {

            if(GetTurn() == 1)
            {
                SetTurn(2);
                turn = GetTurn();
            }
            else if(GetTurn() == 2)
            {
                SetTurn(1);
                turn = GetTurn();
            }
            return turn;
        }

        public int GetTurn()
        {
            return _turn;
        }

        public int Play1SetWin()
        {
            return p1w = 1;
        }

        public int Play2SetWin()
        {
            return p2w = 1;
        }

        public int PlayDrawSet()
        {
            return draw = 1;
        }

        public void SetWinMessage()
        {
            if(p1w == 1)
            {
                wmess = "Player 1 Wins!";
            }
            if(p2w == 1)
            {
                wmess = "Player 2 Wins!";
            }
            if(draw == 1)
            {
                wmess = "Draw";
            }
        }

        public string GetWinMessage()
        {
            return wmess;
        }

        public void CheckForWin()
        {
            if (Usabletic.Count == 5)
            {
                //conditions for player 1 to win
                if ((Usabletic.Contains("a1") && Usabletic.Contains("a2") && Usabletic.Contains("a3") && Tic[0, 0] == 1 && Tic[0, 1] == 1 && Tic[0, 2] == 1) ||
                    (Usabletic.Contains("b1") && Usabletic.Contains("b2") && Usabletic.Contains("b3") && Tic[1, 0] == 1 && Tic[1, 1] == 1 && Tic[1, 2] == 1) ||
                    (Usabletic.Contains("c1") && Usabletic.Contains("c2") && Usabletic.Contains("c3") && Tic[2, 0] == 1 && Tic[2, 1] == 1 && Tic[2, 2] == 1) ||
                    (Usabletic.Contains("a1") && Usabletic.Contains("b2") && Usabletic.Contains("c3") && Tic[0, 0] == 1 && Tic[1, 1] == 1 && Tic[2, 2] == 1) ||
                    (Usabletic.Contains("c1") && Usabletic.Contains("b2") && Usabletic.Contains("a3") && Tic[2, 0] == 1 && Tic[1, 1] == 1 && Tic[0, 2] == 1))
                {
                    Play1SetWin();
                }
                if ((Usabletic.Contains("a1") && Usabletic.Contains("a2") && Usabletic.Contains("a3") && Tic[0, 0] == 2 && Tic[0, 1] == 2 && Tic[0, 2] == 2) ||
                    (Usabletic.Contains("b1") && Usabletic.Contains("b2") && Usabletic.Contains("b3") && Tic[1, 0] == 2 && Tic[1, 1] == 2 && Tic[1, 2] == 2) ||
                    (Usabletic.Contains("c1") && Usabletic.Contains("c2") && Usabletic.Contains("c3") && Tic[2, 0] == 2 && Tic[2, 1] == 2 && Tic[2, 2] == 2) ||
                    (Usabletic.Contains("a1") && Usabletic.Contains("b2") && Usabletic.Contains("c3") && Tic[0, 0] == 2 && Tic[1, 1] == 2 && Tic[2, 2] == 2) ||
                    (Usabletic.Contains("c1") && Usabletic.Contains("b2") && Usabletic.Contains("a3") && Tic[2, 0] == 2 && Tic[1, 1] == 2 && Tic[0, 2] == 2))
                {
                    Play2SetWin();
                }
            }
        }

        public void SetTurn(int turn)
        {
            _turn = turn;
        }

        public string GetChangeValue()
        {
            return _used;
        }

        public string SetChangeValue( string used)
        {
            return _used = used;
        }
        
        
        public void ChangeticValue(string value, int turn)
        {
            if (UseSpot(value) == "a1")
            {
                Tic[0, 0] = turn;
            }
            else if(UseSpot(value) == "a2")
            {
                Tic[0,1] = GetTurn();
            }
            else if(UseSpot(value) == "a3")
            {
                Tic[0,2] = GetTurn();
            }
            else if (UseSpot(value) == "b1")
            {
                Tic[1,0] = GetTurn();
            }
            else if (UseSpot(value) == "b2")
            {
                Tic[1, 1] = GetTurn();
            }
            else if (UseSpot(value) == "b3")
            {
                Tic[1, 2] = GetTurn();
            }
            else if (UseSpot(value) == "c1")
            {
                Tic[1, 0] = GetTurn();
            }
            else if (UseSpot(value) == "c2")
            {
                Tic[1, 1] = GetTurn();
            }
            else if (UseSpot(value) == "c3")
            {
                Tic[1, 2] = GetTurn();
            }
        }
        public string UseSpot(string used) //work in progress. suposed to hold what has been used or not.
        {
            //Usabletic = new List<string>();
            if ((used == "a1" || "a2" == used || used == "a3" || used == "b1" || used == "b2" || used == "b3" || used == "c1" || used == "c2" || used == "c3") && (Usabletic.Contains(used) == false))
            {
                value = used;
                Usabletic.Add(used);
                //string T = GetTurn().ToString();
                ChangeticValue(SetChangeValue(value),GetTurn());
                //ChangeTurn(GetTurn());
                return used;

            }
            else
            {
                return null;
            }

        }



    }
}
//if (p1w == 1)
//{
//    Console.WriteLine("Player 1 Wins"); win messages
//}
//else if (p2w == 1)
//{

//}