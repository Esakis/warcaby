using System;
using System.Collections.Generic;
using System.Text;

namespace warcaby.DataManager
{
    class ChooseKey
    {
        public static void InputKey()
        {
            ConsoleKeyInfo input;
            do
            {
                input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Static.Board.MakeBoard();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Static.Board.MakeBoard();
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        DataManager.ChooseSizeOfBoard.SizeBoard();
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        Static.Board.MakeBoard();
                        break;
                }
            } 
            while (input.Key != ConsoleKey.Escape);
        }
    }
}
