using MUD.Menu;
using MUD.Worlds;

namespace MUD
{
    internal class Program
    {
        public static readonly Random _rng = new Random();
        static async Task Main(string[] args)
        {
            await StartMenu.Menu();
        }
    }
}