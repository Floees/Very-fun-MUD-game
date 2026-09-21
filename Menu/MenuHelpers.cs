using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MUD.Menu
{
    internal class MenuHelpers
    {
        public static int VerticalSelection(List<string> options)
        {
            Console.CursorVisible = false;
            int i = 0;
            ConsoleKeyInfo key;

            while (true) 
            {
                foreach (string option in options) 
                {
                    if (option == options[i]) 
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(option);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                        Console.WriteLine(option);
                }

                key = Console.ReadKey(true);

                switch (key.Key) 
                {
                    case ConsoleKey.DownArrow:
                        if (i < options.Count) { i++; }
                        Console.Clear();
                        break;

                    case ConsoleKey.UpArrow:
                        if (i > 0) { i--; }
                        Console.Clear();
                        break;

                    case ConsoleKey.Enter:
                        Console.Clear();
                        return i;

                    default: Console.WriteLine(" UP,DOWN,ENTER TO SELECT");
                            Thread.Sleep(500);
                            Console.Clear();
                        break;
                }
            }

        }

        public static int VerticalSelection(List<string> options, string currentlocation, Player.Player player)
        {
            Console.CursorVisible = false;
            int i = 0;
            ConsoleKeyInfo key;

            while (true)
            {
                foreach (string option in options)
                {
                    if (option == options[i])
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(option);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                        Console.WriteLine(option);
                }

                key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.DownArrow:
                        if (i < options.Count-1) { i++; }
                        Console.Clear();
                        if (currentlocation == "HubWorld") { Art.Town.DrawTown(); }
                        player.PlayerStatWindow(player);
                        break;

                    case ConsoleKey.UpArrow:
                        if (i > 0) { i--; }
                        Console.Clear();
                        if (currentlocation == "HubWorld") { Art.Town.DrawTown(); }
                        player.PlayerStatWindow(player);
                        break;

                    case ConsoleKey.Enter:
                        Console.Clear();
                        return i;

                    default:
                        Console.WriteLine(" UP,DOWN,ENTER TO SELECT");
                        Console.Clear();
                        Thread.Sleep(500);
                        if (currentlocation == "HubWorld") { Art.Town.DrawTown(); }
                        player.PlayerStatWindow(player);
                        break;
                }
            }

        }
    }
}
