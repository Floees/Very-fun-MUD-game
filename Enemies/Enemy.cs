using MUD.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace MUD.Enemies
{
    class Enemy
    {
        public string? name;
        public int level;
        public int health;
        public int healthMax;
        public int damage;
        public int xp;
        public List<Loot> loot;

        public Enemy(string name, int level, int health, int healthMax, int damage,int xp, List<Loot> loot)
        {
            this.name = name;
            this.level = level;
            this.health = health;
            this.healthMax = healthMax;
            this.damage = damage;
            this.xp = xp;
            this.loot = loot;
        }

        public Player.Player EnemyAttack(Enemy enemy, Player.Player player)
        {
            player.playerHealth -= enemy.damage + enemy.level; // do something with armorrating

            if (player.playerHealth <= 0)
            {
                player.alive = false;
                Console.WriteLine($"You have been defeated by {enemy.name}!");
                Thread.Sleep(5000);
                Console.Clear();
                StartMenu.Menu("a");
            }
            else
            {
                Console.WriteLine($"{enemy.name} attacks you for {enemy.damage + enemy.level} damage!");
                Thread.Sleep(2000);
            }
            return player;
        }

        public Player.Player GivePlayerLoot(Player.Player player, Enemy enemy) 
        {
            bool addedItem = false;
            Console.WriteLine($"Congratulations! You defeated the {enemy.name}");
            if ((player.CurrentXp + enemy.xp >= player.XpMax))
            {
                player.CurrentXp += enemy.xp;

                player.playerLevel += 1;
                player.CurrentXp -= player.XpMax;

                player.XpMax += 10;
                player.StatPoints += 1;
                Console.WriteLine($"You leveled up! You are now level {player.playerLevel} with {player.CurrentXp}/{player.XpMax}xp");
                Console.WriteLine("You revieved:");
            }
            else
            {
                Console.WriteLine("You revieved:");
                Console.WriteLine($"{enemy.xp} xp, your current xp is {player.CurrentXp}/{player.XpMax}");
            }

            foreach (Loot E in enemy.loot) 
            {
                addedItem = false;

                Console.WriteLine($"{E.name} {E.amount}x worth {E.value} gold each!");

                foreach(Loot P in player.playerLoot) 
                {
                    if (P.name == E.name)
                    {
                        P.amount += E.amount;
                        addedItem = true;
 
                    }
                }

                if (!addedItem)
                {
                    player.playerLoot.Add(E);
                }
            }
            Console.WriteLine("\n\n\n Press ENTER to continue");
            Console.ReadLine();
            return player;
        }
    }
}
