using MUD.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace MUD.Worlds
{
    internal class Tavern
    {
        public static Player.Player TavernMenu(Player.Player player) 
        {
            int price = 5 * player.playerLevel;
            List<String> MenuOptions = new List<String>();
            MenuOptions.Add($"Pay {price} gold to stay the night.");
            MenuOptions.Add($"Ask innkeeper for information. 40 gold requiered.");
            MenuOptions.Add($"Leave");
            int i = 0;



            i = MenuHelpers.VerticalSelection(MenuOptions);

            if (i == 0 && player.playerGold > price)
            {
                Rest(player, price);
                HubWorld.HubWorldMenu(player);
            }
            if (i == 1 && player.playerGold >= 40)
                //do something
                return player;

            HubWorld.HubWorldMenu(player);
            return player; //????????????
        }

        public static void Rest(Player.Player player, int price) 
        {
            //write blah blah you rest your hp has been recovered.pay 20 gpöd fpr room.
            Console.Clear();
            Console.WriteLine($"You pay {price} to stay the night.");
            Thread.Sleep(1000);
            Console.WriteLine($"Your health is now {player.playerHealth}/100");
            Thread.Sleep(1000);
            player.playerHealth = 100;
            player.playerGold -= price;
        }
    }
}
