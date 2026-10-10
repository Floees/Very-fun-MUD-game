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
        public List<Loot> loot;

        public Enemy(string name, int level, int health, int healthMax, int damage, List<Loot> loot)
        {
            this.name = name;
            this.level = level;
            this.health = health;
            this.healthMax = healthMax;
            this.damage = damage;
            this.loot = loot;
        }

        public Player.Player EnemyAttack(Enemy enemy, Player.Player player)
        {
            player.playerHealth -= enemy.damage + enemy.level;

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
    }
}
