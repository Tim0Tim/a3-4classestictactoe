using System;
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
        private int pw = 0; // player one wins if = 1 p2 wins if 2 draw if 3
        private int[,] Tic = new int[3, 3];
        private string wmess;
        private string value;
        //private List<string> options;





        private List<string> Usabletic;
        private List<string> options;
        public TicTacToe()
        {
            int[,] Tic = new int[,]{
            { 0, 0, 0 }, {0,0,0}, {0,0,0}
            };
            _used = "";
            Usabletic = new List<string>();
            options = new List<string>();
            //Tic = new int[,];
        }

        public int[,] Getboard()
        {
            //int[,] tic2 = Tic;
            //return tic2; 
            return Tic;
        }

        public List<string> GetOptions()
        {
            AddOptions();
            return options;
        }
        
        public void AddOptions()
        {
            options.Add("a1");
            options.Add("a2");
            options.Add("a3");
            options.Add("b1");
            options.Add("b2");
            options.Add("b3");
            options.Add("c1");
            options.Add("c2");
            options.Add("c3");
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

        public List<string> GetTic()
        {
            return Usabletic;
        }

        public int GetTurn()
        {
            return _turn;
        }

        public int Play1SetWin()
        {
            return pw = 1;
        }

        public int Play2SetWin()
        {
            return pw = 2;
        }

        public int PlayDrawSet()
        {
            return pw = 3;
        }


        public void SetWinMessage()
        {
            if(pw == 1)
            {
                wmess = "Player 1 Wins!";
            }
            if(pw == 2)
            {
                wmess = "Player 2 Wins!";
            }
            if(pw == 3)
            {
                wmess = "Draw";
            }
        }

        public string GetWinMessage()
        {
            return wmess;
        }

        public int CheckForWin()//add virdical conditions.
        {
            if (Usabletic.Count == 5)
            {
                //conditions for player 1 to win
                if ((Usabletic.Contains("a1") && Usabletic.Contains("a2") && Usabletic.Contains("a3") && Tic[0, 0] == 1 && Tic[0, 1] == 1 && Tic[0, 2] == 1) ||
                    (Usabletic.Contains("b1") && Usabletic.Contains("b2") && Usabletic.Contains("b3") && Tic[1, 0] == 1 && Tic[1, 1] == 1 && Tic[1, 2] == 1) ||
                    (Usabletic.Contains("c1") && Usabletic.Contains("c2") && Usabletic.Contains("c3") && Tic[2, 0] == 1 && Tic[2, 1] == 1 && Tic[2, 2] == 1) ||
                    (Usabletic.Contains("a1") && Usabletic.Contains("b2") && Usabletic.Contains("c3") && Tic[0, 0] == 1 && Tic[1, 1] == 1 && Tic[2, 2] == 1) ||
                    (Usabletic.Contains("c1") && Usabletic.Contains("b2") && Usabletic.Contains("a3") && Tic[2, 0] == 1 && Tic[1, 1] == 1 && Tic[0, 2] == 1) ||
                    (Usabletic.Contains("a1") && Usabletic.Contains("b1") && Usabletic.Contains("c1") && Tic[0, 0] == 1 && Tic[1, 0] == 1 && Tic[2, 0] == 1) ||
                    (Usabletic.Contains("a2") && Usabletic.Contains("b2") && Usabletic.Contains("c2") && Tic[0, 2] == 1 && Tic[1, 2] == 1 && Tic[2, 2] == 1) ||
                    (Usabletic.Contains("a2") && Usabletic.Contains("b2") && Usabletic.Contains("c2") && Tic[0, 1] == 1 && Tic[1, 1] == 1 && Tic[2, 1] == 1))
                {
                    Play1SetWin();
                }
                if ((Usabletic.Contains("a1") && Usabletic.Contains("a2") && Usabletic.Contains("a3") && Tic[0, 0] == 2 && Tic[0, 1] == 2 && Tic[0, 2] == 2) ||
                    (Usabletic.Contains("b1") && Usabletic.Contains("b2") && Usabletic.Contains("b3") && Tic[1, 0] == 2 && Tic[1, 1] == 2 && Tic[1, 2] == 2) ||
                    (Usabletic.Contains("c1") && Usabletic.Contains("c2") && Usabletic.Contains("c3") && Tic[2, 0] == 2 && Tic[2, 1] == 2 && Tic[2, 2] == 2) ||
                    (Usabletic.Contains("a1") && Usabletic.Contains("b2") && Usabletic.Contains("c3") && Tic[0, 0] == 2 && Tic[1, 1] == 2 && Tic[2, 2] == 2) ||
                    (Usabletic.Contains("c1") && Usabletic.Contains("b2") && Usabletic.Contains("a3") && Tic[2, 0] == 2 && Tic[1, 1] == 2 && Tic[0, 2] == 2) ||
                    (Usabletic.Contains("a1") && Usabletic.Contains("b1") && Usabletic.Contains("c1") && Tic[0, 0] == 2 && Tic[1, 0] == 2 && Tic[2, 0] == 2) ||
                    (Usabletic.Contains("a2") && Usabletic.Contains("b2") && Usabletic.Contains("c2") && Tic[0, 2] == 2 && Tic[1, 2] == 2 && Tic[2, 2] == 2) ||
                    (Usabletic.Contains("a2") && Usabletic.Contains("b2") && Usabletic.Contains("c2") && Tic[0, 1] == 2 && Tic[1, 1] == 2 && Tic[2, 1] == 2))
                {
                    Play2SetWin();
                }// draw conditions
                if (Tic[0, 0] != 0 && Tic[0, 1] != 0 && Tic[0, 2] != 0 && Tic[1, 0] != 0 && Tic[1, 1] != 0 && Tic[1, 2] != 0 && Tic[2, 0] != 0 && Tic[2, 1] != 0 && Tic[2, 2] != 0 && pw == 0)
                {
                    PlayDrawSet();
                }
            }
            return pw;
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
       
            public void ChangeticValue(string value)
            {
                if (value == "a1")
                {
                    Tic[0, 0] = GetTurn();
                }
                else if (value == "a2")
                {
                    Tic[0, 1] = GetTurn();
                }
                else if (value == "a3")
                {
                    Tic[0, 2] = GetTurn();
                }
                else if (value == "b1")
                {
                    Tic[1, 0] = GetTurn();
                }
                else if (value == "b2")
                {
                    Tic[1, 1] = GetTurn();
                }
                else if (value == "b3")
                {
                    Tic[1, 2] = GetTurn();
                }
                else if (value == "c1")
                {
                    Tic[2, 0] = GetTurn();
                }
                else if (value == "c2")
                {
                    Tic[2, 1] = GetTurn();
                }
                else if (value == "c3")
                {
                    Tic[2, 2] = GetTurn();
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
                ChangeticValue(SetChangeValue(value));
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