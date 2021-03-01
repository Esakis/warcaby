using System;
using System.Collections.Generic;
using System.Text;

namespace warcaby.Static
{
    public class Board
    {
        public static void MakeBoard()

        {
            
            //string[] board = new string[] {".", ".", ".", ".", ".", ".", ".", ".", "."};
            //Array.ForEach(board, Console.WriteLine)

            //INIT BPARD
            int size = 8;
            string[,] board = new string[size, size];
            for (int i = 0; i < size; i++)
            {
                
                for (int j = 0; j < size; j++)
                {
                    board[i, j] = " ";
                }
            };
            //----------

            //GET PAWNS
            PawnWhite whiteIcon = new PawnWhite();
            PawnBlack blackIcon = new PawnBlack();
            for (int i = 0; i <= size - 1; i += 2)
            {
                board[size - 1, i] = whiteIcon.icon;
                board[size - 3, i] = whiteIcon.icon;
            }
            for (int i = 1; i <= size - 1; i += 2)
            {
                board[0, i] = blackIcon.icon;
                board[2, i] = blackIcon.icon;
            }

            for (int i = 1; i <= size - 1; i += 2)
            {
                board[size - 2, i] = whiteIcon.icon;             
            }
            for (int i = 0; i <= size - 1; i += 2)
            {
                board[1, i] = blackIcon.icon;
            }


            //PRINT BOARD
            Console.Write(Environment.NewLine + Environment.NewLine);
            Console.Write("       Tutaj trzeba wypisac literki od A do size");
            Console.Write(Environment.NewLine);
            Console.Write("________________________________________________________________");
            Console.Write(Environment.NewLine);
            for (int i = 0; i < size; i++)
            {
                Console.Write(string.Format(i+1 + "    |"));
                for (int j = 0; j < size; j++)
                {
                    
                    Console.Write(string.Format(" {0}  |", board[i, j]));
                   
                }


                Console.Write(Environment.NewLine);
                Console.Write("     ");
                for(int k = 0; k < size; k++)
                {
                    Console.Write("-----");
                }
                Console.Write(Environment.NewLine);
                
            }
          
        }

    }

}

