using System;
using System.Collections.Generic;
using System.Text;

namespace MUD.Menu
{
    internal class StartMenu
    {
        public static void Menu() 
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
                    //Character Creator
                        break;
                case 1:
                    Console.WriteLine("\nW.I.P coming in update 4.0.9");
                    Thread.Sleep(1000);
                    Console.Clear();
                    goto here;
                case 2:
                    break;
            }

        }

    }
}
