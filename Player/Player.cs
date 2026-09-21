using MUD.Enemies;
using System;
using System.Collections.Generic;
using System.Text;

namespace MUD.Player
{
    class Player
    {
        public int playerLevel;
        public int playerHealth;
        private int playerHealthMax;
        public int playerStrength;
        public int playerDamage;
        public int playerArmorRating;
        public int playerGold;
        private string? playerName;
        public bool alive;
        public List<Loot> playerLoot;

        public Player(string name)
        {
            playerLevel = 1;
            playerHealthMax = 100;
            playerHealth = 100;
            playerStrength = 10;
            playerDamage = 5;
            playerArmorRating = 5;
            playerGold = 0;
            playerLoot = new List<Loot>();
            playerName = name;
            alive = true;
        }

        public void PlayerStatWindow(Player player) 
        {
            Console.WriteLine();

            List<string> stats = new List<string>
            {
                $"Name: {player.playerName}",
                $"Level: {player.playerLevel}",
                $"Health: {player.playerHealth}",
                $"Strength: {player.playerStrength}",
                $"Damage: {player.playerDamage}",
                $"Armor Rating: {player.playerArmorRating}",
                $"Gold: {player.playerGold}"
            };

            int maxLength = 0;

            foreach (var stat in stats)
            {
                if (stat.Length > maxLength)
                {
                    maxLength = stat.Length;
                }
            }
            // 1. Calculate the required width based on text length plus padding
            int totalWidth = maxLength + 4; // 2 spaces for padding + 2 characters for borders

            // 2. Draw the top border (e.g., ┌────────┐)
            Console.WriteLine("┌" + new string('─', totalWidth - 2) + "┐");

            // 3. Draw the middle text row (e.g., │ Your Text │)
            int i = 0;
            foreach (var stat in stats)
            {
            Console.WriteLine($"│ {stats[i].PadRight(maxLength)} │");
                i++;
            }
            // 4. Draw the bottom border (e.g., └────────┘)
            Console.WriteLine("└" + new string('─', totalWidth - 2) + "┘");
        }

        public Enemy PlayerAttack(Player player, Enemy enemy)
        {
            //reduce enemy healt, cw how much damage the player does to the enemy
            return enemy;
        }

    }
}
