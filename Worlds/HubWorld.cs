using System;
using System.Collections.Generic;
using System.Text;

namespace MUD.Worlds
{
    internal class HubWorld
    {
        public static void HubWorldMenu()
        {
            List<string> menuOptions = new List<string>();
            menuOptions.Add("Go to the dungeon"); // explore 3 floors with monsters and loot, depending on quest. Kill boss on 3rd floor to complete game.
            menuOptions.Add("Go to the forest"); // kill slimes
            menuOptions.Add("Go to the adventurer's guild"); //sell loot, get dungeon quests.
            menuOptions.Add("Go to the tavern"); // rest recover health
            menuOptions.Add("Go to the blacksmith"); // buy weapons and armor
            menuOptions.Add("Quit");
        here:
            int i = Menu.MenuHelpers.VerticalSelection(menuOptions);
            switch (i)
            {
                case 0:
                    Console.WriteLine("\nW.I.P coming in update 4.0.9");
                    System.Threading.Thread.Sleep(1500);
                    Console.Clear();
                    goto here;
                case 1:
                    Console.WriteLine("\nW.I.P coming in update 4.0.9");
                    System.Threading.Thread.Sleep(1500);
                    Console.Clear();
                    goto here;
                case 2:
                    Console.WriteLine("\nW.I.P coming in update 4.0.9");
                    System.Threading.Thread.Sleep(1500);
                    Console.Clear();
                    goto here;
                case 3:
                    break;
            }
        }
    }
}
