using System;
using System.Collections.Generic;
using System.Text;

namespace warcaby.DataManager
{
    class Game
    {
        public const int Size = 8;

        private const char draughtChar = 'o';
        private const ConsoleColor blackColor = ConsoleColor.Blue;
        private const ConsoleColor whiteColor = ConsoleColor.White;
        private const ConsoleColor whiteCage = ConsoleColor.White;


        private List<List<int>> a;
        private bool turnFlag;

        public Game()
        {
            a = new List<List<int>>();
            turnFlag = false;
            for (int i = 0; i < Size; i++)
            {
                a.Add(new List<int>());
                for (int j = 0; j < Size; j++)
                    a[i].Add(0);
            }
            setDefault();
        }
        //=============================== 
        void TurnCheck()
        {
            Console.Write("    Now is turn: ");
            Console.BackgroundColor = turnFlag ? whiteColor : blackColor;
            Console.Write("   ");
            Console.ResetColor();
        }
        //========================================


        public void PrintBoard()
        {
            char top = 'A';
            int left = Size;

            Console.Clear();
            Console.Write(Environment.NewLine + Environment.NewLine);
            //numbers in top
            for (int j = 0; j < Size + 1; j++)
                if (j == 0)
                    Console.Write("       ");
                else
                {
                    Console.Write(" " + top + " ");
                    top++;
                }

            Console.WriteLine();

            //playing area
            for (int i = 0; i < Size; i++)
            {
                Console.Write("   " + left + "   ");
                left--;
                for (int j = 0; j < Size; j++)
                {
                    if ((i + j) % 2 == 0)
                        Console.BackgroundColor = whiteCage;
                    Console.Write(" " + intToChar(a[i][j]) + " ");
                    Console.ResetColor();
                }
                if (i == 2)
                    TurnCheck();
                Console.WriteLine();
            }
            return;
        }
        //============================================
        private char intToChar(int number)
        {
            switch (number)
            {
                case 1: return draughtChar;
                case -1: Console.ForegroundColor = blackColor; return draughtChar;
                default: return ' ';
            }
        }

        //============================================

        public bool turn(string fromStr, string toStr)
        {


            turnFlag = !turnFlag; //next player turn
            return true;
        }

        //=========================================
        private void setDefault()
        {
            for (int i = 0; i < Size; i++)
                for (int j = 0; j < Size; j++)
                    if ((i + j) % 2 != 0)
                    {
                        switch (i)
                        {
                            case 0:
                            case 1:
                            case 2:
                                a[i][j] = -1;
                                break;
                            case 5:
                            case 6:
                            case 7:
                                a[i][j] = 1;
                                break;
                            default:
                                a[i][j] = 0;
                                break;
                        }
                    }
        }
        //===================================




    }
}
