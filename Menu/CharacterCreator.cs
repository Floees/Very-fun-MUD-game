using System;
using System.Collections.Generic;
using System.Text;

namespace MUD.Menu
{
    internal class CharacterCreator
    {
        public static void StartCharacterCreator()
        {
            Console.CursorVisible = false;
            Console.WriteLine("You wake up in a unfamiliar town...");
            Thread.Sleep(500);
            Console.WriteLine("Someone is trying to talk to you in a language you somehow barely understand.\n\n Old man: Are you okay? Tell me your name");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Enter your name: ");

            Console.CursorVisible = true;
            string name = Console.ReadLine();
            Console.CursorVisible = false;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Old man: What an odd name, {name}. Glad you seem okay though, you looked like you had passed out. Now off with you, you're scaring my customers away!");
            Console.ReadKey();
        }
    }
}
