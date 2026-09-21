using System;
using System.Collections.Generic;
using System.Text;

namespace MUD.Player
{
    class Player
    {
        private int playerLevel;
        private int playerHealth;
        private int playerStrength;
        private int playerDamage;
        private int playerArmorRating;
        private int playerGold;
        private string? playerName;
        private bool alive;

        public Player(string name)
        {
            playerLevel = 1;
            playerHealth = 100;
            playerStrength = 10;
            playerDamage = 5;
            playerArmorRating = 5;
            playerGold = 0;
            playerName = name;
            alive = true;
        }

    }
}
