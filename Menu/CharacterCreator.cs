using MUD.Worlds;
using System;
using System.Collections.Generic;
using System.Text;

namespace MUD.Menu
{
    internal class CharacterCreator
    {
        public static void StartCharacterCreator()
        {
            StartCharacterCreator:

            Console.CursorVisible = false;
            Console.WriteLine("You wake up in a unfamiliar town...");
            Thread.Sleep(500);
            Console.WriteLine("Someone is trying to talk to you in a language you somehow barely understand.\n\n Old man: Are you okay? Tell me your name");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Enter your name: ");

            Console.CursorVisible = true;
            string name = Console.ReadLine();

                if (!IsValidName(name))
                {
                    Console.WriteLine("Invalid name. Please enter a valid name (only letters and spaces are allowed).");
                    Thread.Sleep(2000);
                    Console.Clear();
                    goto StartCharacterCreator; // Restart the character creation process
                }

            Console.CursorVisible = false;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Old man: What an odd name, {name}. Glad you seem okay though, you looked like you had passed out. Now off with you, you're scaring my customers away!");
            Player.Player player = new Player.Player(name);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Press enter to continue...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();

            Console.Clear();
            HubWorld.HubWorldMenu(player);

        }

        private static bool IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return false;
            // Check for invalid characters (only allow letters and spaces)
            foreach (char c in name)
            {
                if (!char.IsLetter(c) && c != ' ')
                    return false;
            }
            return true;
        }
    }
}
