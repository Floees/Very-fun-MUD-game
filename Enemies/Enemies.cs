using System;
using System.Collections.Generic;
using System.Text;

namespace MUD.Enemies
{
    public class Enemies
    {
        public string? name;
        public int level;
        public int health;
        public int damage;
        public List<Loot> loot;

        public Enemies(string name, int level, int health, int damage, List<Loot> loot)
        {
            this.name = name;
            this.level = level;
            this.health = health;
            this.damage = damage;
            this.loot = loot;
        }
    }
}
