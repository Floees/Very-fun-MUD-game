using System;
using System.Collections.Generic;
using System.Text;

namespace MUD.Worlds
{
    internal class Forest
    {
        public void DrawForestSlime(Enemies.Enemies enemy)
        {
            Console.WriteLine($"You encounter a level {enemy.level} Forest Slime!");
            Console.WriteLine($"  (o_o)  ");
            Console.WriteLine("  <)   )╯");
            Console.WriteLine("  /   \\  ");
        }
    }
}
