using System;
using System.Collections.Generic;
namespace ValueTuplesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var listofplayers = new List<(int playerNo, string playerName, int playerGoals)>();

            listofplayers.Add((6, "James", 33000));
            listofplayers.Add((24, "Bryant", 31000));
            listofplayers.Add((23, "Jordan", 30000));
            listofplayers.Add((7, "Anthony", 23000));
            listofplayers.Sort();
            foreach (var player in listofplayers)
            {
                Console.WriteLine($"{player.playerNo} - {player.playerName} - {player.playerGoals}");
                Console.WriteLine("----------------------------");
            }
            
        }
    }
}
