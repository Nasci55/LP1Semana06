using System;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Enemy loki = new Enemy(args[0]);

            loki.SetName(args[0]);
        }
    }
}
