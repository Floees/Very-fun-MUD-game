using System;
using System.Collections.Generic;
using System.Text;

namespace MUD.Worlds
{
    internal class Forest
    {
        private static readonly Random _rng = new Random();

        public Player.Player SlimeTime(Enemies.Enemy enemy, Player.Player player)
        {
            Enemies.Enemy forestSlime = CreateForestSlime(player);
            int slimeHealthMax = forestSlime.health;
            int slimeDamage = forestSlime.damage;
            int i = 0;

            Console.WriteLine();
            Console.WriteLine($"You encounter a level {forestSlime.level} Forest Slime!");
            Console.WriteLine($"  (o_o)                        Slime health: {forestSlime.health}/{slimeHealthMax}");
            Console.WriteLine($"  <)   )╯                      Slime damage: {slimeDamage}~");
            Console.WriteLine("  /   \\  ");
            Console.WriteLine();
            player.PlayerStatWindow(player);


            switch (i) 
            {
                case 1: //attack
                    break;
                case 2: //flee
                    break;
            }
            return player;
        }

        public Enemies.Enemy CreateForestSlime(Player.Player player)
        {
            var loot = new List<Enemies.Loot>
            {
                new Enemies.Loot("Slime Gel", 5, 1),
                new Enemies.Loot("Mushroom", 3, _rng.Next(0, 3))
            };

            int slimeLevel = _rng.Next(player.playerLevel - 1, player.playerLevel + 2);
            if (slimeLevel < 1) slimeLevel = 1;
            int slimeHealth = 10 + slimeLevel;
            int slimeDamage = 2 + slimeLevel;

            return new Enemies.Enemy("Forest Slime", slimeLevel, slimeHealth, slimeDamage, loot);
        }
    }
}
