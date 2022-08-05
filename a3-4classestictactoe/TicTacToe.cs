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

        public void SetTurn(int turn)
        {
            _turn = turn;
        }

        public List<string> UseSpot(string used) //work in progress. suposed to hold what has been used or not.
        {
            //Usabletic = new List<string>();
            if ((used == "a1" || "a2" == used || used == "a3" || used == "b1" || used == "b2" || used == "b3" || used == "c1" || used == "c2" || used == "c3") && (Usabletic.Contains(used) == false))
            {
                Usabletic.Add(used);
                return used;
            }

           
            //Usabletic.Add("a1");
            //Usabletic.Add("a2");
            //Usabletic.Add("a3");
            //Usabletic.Add("b1");
            //Usabletic.Add("b2");
            //Usabletic.Add("b3");
            //Usabletic.Add("c1");
            //Usabletic.Add("c2");
            //Usabletic.Add("c3");
        }



    }
}
