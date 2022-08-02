using System;
using System.Linq;
using System.Collections.Generic;

namespace a3_4classestictactoe
{
    internal class Program
    {
        int p1w = 0; // player one wins if = 1
        int p2w = 0; // player two wins if = 1

        //0,0 = 1
        //1,1 = 5
        //2,2 = 9

        //1 2 3   a
        //4 5 6   b
        //7 8 9   c  will change all numbers to zero when complete
        static void Main()
        {
            List<string> Usabletic = new List<string>(); 
            Usabletic.Add("a1");
            Usabletic.Add("a2");
            Usabletic.Add("a3");
            Usabletic.Add("b1");
            Usabletic.Add("b2");
            Usabletic.Add("b3");
            Usabletic.Add("c1");
            Usabletic.Add("c2");
            Usabletic.Add("c3");


            int[,] Tic = /*new int[,]*/{
            { 1, 2, 3 }, {4,5,6}, {7,8,9}
            };



            int i = 0;
            while (i < 10)
            {

                i++;
            }
        }
    }
}
