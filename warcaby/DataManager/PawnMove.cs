using System;
using System.Collections.Generic;
using System.Text;

namespace warcaby.DataManager
{
    public class PawnMove
    {
        public static int PrintMoveX()
        {

            Console.WriteLine(" ");
            Console.WriteLine("    Choose the coordinates for the pawn X(1-8):  ");
            Console.WriteLine(" ");
            int fieldx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Your coordinates it: " + fieldx);     
            return fieldx;
        }

        public static int PrintMoveY()
        {

            Console.WriteLine(" ");
            Console.WriteLine("   Choose the coordinates for the pawn Y(A-Z):  ");
            Console.WriteLine(" ");
            int fieldy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Your coordinates it: " + fieldy);
            return fieldy;
        }
    }
}
