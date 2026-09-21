using MUD.Menu;
using MUD.Worlds;

namespace MUD
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            await StartMenu.Menu();
        }
    }
}