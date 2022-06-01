using System;
using System.Collections.Generic;
namespace Delegates
{
    public delegate void DisplayPlayer(Dictionary<int, string> players);
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> listofplayers = new Dictionary<int, string>();
            listofplayers.Add(23, "Jordan");
            listofplayers.Add(24, "Bryant");
            listofplayers.Add(30, "O'neal");

            DisplayPlayer player = new DisplayPlayer(DisplayPlayerInfo);
            player(listofplayers);

        }

        public static void DisplayPlayerInfo(Dictionary<int, string> players)
        {
            foreach (var player in players)
            {
                Console.WriteLine($"Player no: {player.Key} , Player Name : {player.Value}");
            }
        }
    }
}
