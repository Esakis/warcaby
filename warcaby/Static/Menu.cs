using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace warcaby.Static
{
    class Menu
    {
        static string[] posMenu = { "         Play 1 on 1                ", "         Play Computer               ",
            "         Choose size board           ", "         Exit                 "};
        static int actPosMenu = 0;

        public static void PrintMain()
        {
            Console.Title = "-------------   Draughts  ---------------";
            Console.CursorVisible = false;
            while (true)
            {
                PrintMenu();
                Option();
                Mainchoose();
            }
        }

        public static void PrintMenu()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("   ###################################");
            Console.WriteLine("   ###########   Draughts  ###########");
            Console.WriteLine("   ###################################");
            Console.WriteLine("");
            Console.WriteLine("               CHOOSE GAME            ");
            Console.WriteLine("");

            for (int i = 0; i < posMenu.Length; i++)
            {
                if (i == actPosMenu)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("{0, -35}", posMenu[i]);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else
                {
                    Console.WriteLine(posMenu[i]);
                }
            }
        }

       static void Option()
        {
            do
            {
                ConsoleKeyInfo arrow1 = Console.ReadKey();
                if (arrow1.Key == ConsoleKey.UpArrow)
                {
                    actPosMenu = (actPosMenu > 0) ? actPosMenu - 1 : posMenu.Length - 1;
                    PrintMenu();
                }
                else if (arrow1.Key == ConsoleKey.DownArrow)
                {
                    actPosMenu = (actPosMenu + 1) % posMenu.Length;
                    PrintMenu();
                }
                else if (arrow1.Key == ConsoleKey.Escape)
                {
                    actPosMenu = posMenu.Length - 1;
                    break;
                }
                else if (arrow1.Key == ConsoleKey.Enter)
                    break;

            }
            while (true);
        }

       static void Mainchoose()
        {
            switch(actPosMenu)
            {
                case 0:
                    Console.Clear();
                    Static.Board.MakeBoard();
                    DataManager.FunctionPawnMove.Game();
                    break;
                case 1:
                    Console.Clear();
                    Static.Board.MakeBoard();
                    break;
                case 2:
                    Console.Clear();
                    DataManager.ChooseSizeOfBoard.SizeBoard();
                    break;
                case 3:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
