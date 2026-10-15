using MUD.Enemies;
using MUD.Worlds;
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

        public static int EnemyVerticalSelection(List<string> options, Enemy enemy, Player.Player player)
        {
            Console.CursorVisible = false;
            int i = 0;
            ConsoleKeyInfo key;

            if (enemy.name == "Forest Slime") Forest.DrawSlime(player, enemy);

            player.PlayerStatWindow(player);
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
                        if (i < options.Count - 1) { i++; }
                        Console.Clear();
                        if (enemy.name == "Forest Slime") { Forest.DrawSlime(player, enemy); }
                        player.PlayerStatWindow(player);
                        break;

                    case ConsoleKey.UpArrow:
                        if (i > 0) { i--; }
                        Console.Clear();
                        if (enemy.name == "Forest Slime") { Forest.DrawSlime(player, enemy); }
                        player.PlayerStatWindow(player);
                        break;

                    case ConsoleKey.Enter:
                        return i;

                    default:
                        Console.WriteLine(" UP,DOWN,ENTER TO SELECT");
                        Console.Clear();
                        Thread.Sleep(500);
                        if (enemy.name == "Forest Slime") { Forest.DrawSlime(player, enemy); }
                        player.PlayerStatWindow(player);
                        break;
                }
            }

        }

        //public Player.Player GuildSellMenu(List<string> options, Player.Player player)
        //{
        //    Console.WriteLine();

        //    int maxLength = 0;

        //    foreach (var stat in options)
        //    {
        //        if (stat.Length > maxLength)
        //        {
        //            maxLength = stat.Length;
        //        }
        //    }
        //    // 1. Calculate the required width based on text length plus padding
        //    int totalWidth = maxLength + 4; // 2 spaces for padding + 2 characters for borders

        //    // 2. Draw the top border (e.g., ┌────────┐)
        //    Console.WriteLine("┌" + new string('─', totalWidth - 2) + "┐");

        //    // 3. Draw the middle text row (e.g., │ Your Text │)
        //    int i = 0;
        //    int hovering = 0;
        //    int hoveringUpperBound = 0;
        //    hoveringUpperBound = options.Count - 1;

        //    foreach (var stat in options)
        //    {
        //        if(hovering == i) 
        //        {
        //            Console.WriteLine($"│ {Console.ForegroundColor = ConsoleColor.Blue}{options[i].PadRight(maxLength)}{Console.ForegroundColor = ConsoleColor.White} │");
        //            i++;
        //            continue;
        //        }
        //        Console.WriteLine($"│ {options[i].PadRight(maxLength)} │");
        //        i++;
        //    }
        //    // 4. Draw the bottom border (e.g., └────────┘)
        //    Console.WriteLine("└" + new string('─', totalWidth - 2) + "┘");

        //    switch () 
        //    {
                
        //    }
        //}
    }
}
