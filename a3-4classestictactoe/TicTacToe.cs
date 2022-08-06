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
        private int p1w = 0; // player one wins if = 1
        private int p2w = 0; // player two wins if = 1

        private List<string> Usabletic;
        public TicTacToe()
        {
            int[,] Tic = {
            { 0, 0, 0 }, {0,0,0}, {0,0,0}
            };

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

        public void CheckForWin()
        {
            if (Usabletic.Count == 5)
            {

            }
        }

        public void SetTurn(int turn)
        {
            _turn = turn;
        }

        public string UseSpot(string used) //work in progress. suposed to hold what has been used or not.
        {
            //Usabletic = new List<string>();
            if ((used == "a1" || "a2" == used || used == "a3" || used == "b1" || used == "b2" || used == "b3" || used == "c1" || used == "c2" || used == "c3") && (Usabletic.Contains(used) == false))
            {
                Usabletic.Add(used);
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