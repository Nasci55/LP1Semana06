using System;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Enemy loki = new Enemy("Loki");

            loki.SetName(args[0]);
        }
    }
}
