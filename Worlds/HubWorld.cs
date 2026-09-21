using System;
using System.Collections.Generic;
using System.Text;

namespace MUD.Worlds
{
    internal class HubWorld
    {
        public static void HubWorldMenu(Player.Player player)
        {
            string currentLocation = "HubWorld";
            List<string> menuOptions = new List<string>();
            menuOptions.Add("Go to the dungeon"); // explore 3 floors with monsters and loot, depending on quest. Kill boss on 3rd floor to complete game.
            menuOptions.Add("Go to the forest"); // kill slimes
            menuOptions.Add("Go to the adventurer's guild"); //sell loot, get dungeon quests.
            menuOptions.Add("Go to the tavern"); // rest recover health
            menuOptions.Add("Go to the blacksmith"); // buy weapons and armor
            menuOptions.Add("Save and quit (W.I.P)");

        here:
            Art.Town.DrawTown();
            player.PlayerStatWindow(player);
            int i = Menu.MenuHelpers.VerticalSelection(menuOptions, currentLocation, player);
            switch (i)
            {
                case 0:
                    //Dungeon.DungeonMenu();
                    Console.Clear();
                    break;
                case 1:
                    //Forest.ForestMenu();
                    Console.Clear();
                    break;
                case 2:
                    //AdventurerGuild.AdventurerGuildMenu();
                    Console.Clear();
                    break;
                case 3:
                    //Tavern.TavernMenu();
                    Console.Clear();
                    break;
                case 4:
                    //Blacksmith.BlacksmithMenu();
                    Console.Clear();
                    break;
                case 5:
                    //Save and quit functionality
                    Console.Clear();
                    goto here;
            }
        }
    }
}
