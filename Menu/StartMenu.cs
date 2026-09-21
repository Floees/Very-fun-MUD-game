using AngleSharp.Io;
using MUD.Cutscenes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MUD.Menu
{
    internal class StartMenu
    {
        public static async Task Menu() 
        {
            List<string> menuOptions = new List<string>();

            menuOptions.Add("New game");
            menuOptions.Add("Load game");
            menuOptions.Add("Quit");

            here:
            int i = MenuHelpers.VerticalSelection(menuOptions);

            switch (i) 
            {
                case 0:
                    await Videoplayer.PlayVideo();
                    CharacterCreator.StartCharacterCreator();
                    break;
                case 1:
                    Console.WriteLine("\nW.I.P coming in update 4.0.9");
                    Thread.Sleep(1500);
                    Console.Clear();
                    goto here;
                case 2:
                    break;
            }

        }

    }
}
