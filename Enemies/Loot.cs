using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text;

namespace MUD.Enemies
{
    public class Loot
    {
        string name;
        int value;
        int amount;

        public Loot(string name, int value, int amount)
        {
            this.name = name;
            this.value = value;
            this.amount = amount;
        }
    }
}
