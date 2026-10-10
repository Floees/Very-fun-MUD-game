using MUD.Enemies;
using MUD.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace MUD.Worlds
{
    internal class Forest
    {
        private static readonly Random _rng = new Random();

        public static void SlimeTime(Player.Player player)
        {
            Enemies.Enemy forestSlime = CreateForestSlime(player);
            int slimeHealthMax = forestSlime.health;
            int slimeDamage = forestSlime.damage;
            int i = 0;

        Here:
            //if slime dead do something else and return player with loot and gold..
            i = MenuHelpers.EnemyVerticalSelection(new List<string> { "Attack", "Flee" }, forestSlime, player);


            switch (i)
            {
                case 0:
                    player.PlayerAttack(player, forestSlime);
                    if (forestSlime.health <= 0) 
                    {
                        Console.Clear();
                        Worlds.HubWorld.HubWorldMenu(player);
                    }
                    
                    forestSlime.EnemyAttack(forestSlime, player);
                    Console.Clear();
                    goto Here;
                case 1: //flee
                    break;
            }
            return;
        }

        public static Enemies.Enemy CreateForestSlime(Player.Player player)
        {
            var loot = new List<Enemies.Loot>
            {
                new Enemies.Loot("Slime Gel", 5, 1),
                new Enemies.Loot("Mushroom", 3, _rng.Next(0, 3))
            };

            int slimeLevel = _rng.Next(player.playerLevel - 1, player.playerLevel + 2);
            if (slimeLevel < 1) slimeLevel = 1;
            int slimeHealth = 15 + slimeLevel;
            int slimeDamage = 8 + slimeLevel;

            return new Enemies.Enemy("Forest Slime", slimeLevel, slimeHealth, slimeHealth, slimeDamage, loot);
        }

        public static void DrawSlime(Player.Player player, Enemies.Enemy forestSlime)
        {
            Console.WriteLine();
            Console.WriteLine($"You encounter a level {forestSlime.level} Forest Slime!");
            Console.WriteLine($"  (o_o)                                   Slime health: {forestSlime.health}/{forestSlime.healthMax}");
            Console.WriteLine($"  <)   )╯                                 Slime damage: {forestSlime.damage}~");
            Console.WriteLine("  /   \\  ");
            Console.WriteLine();
        }
    }
}
