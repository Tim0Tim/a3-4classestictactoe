﻿using System;
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


            //int[,] Tic = /*new int[,]*/{
            //{ 1, 2, 3 }, {4,5,6}, {7,8,9}
            //};

            TicTacToe ttt = new TicTacToe();
     

            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(1);
                i++;
            }
        }
    }
}
