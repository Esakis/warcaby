using System;
using System.Collections.Generic;
using System.Text;

namespace warcaby.DataManager
{
    class FunctionPawnMove
    {
        public static void Game()
        {
            int X = DataManager.PawnMove.PrintMoveX();
            int Y = DataManager.PawnMove.PrintMoveY();
            Console.WriteLine("");
            Console.WriteLine(Y);
            Console.WriteLine(X);
            Console.WriteLine("");


        }
    }
}
