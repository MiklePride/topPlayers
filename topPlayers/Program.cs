using System;
using System.Collections.Generic;
using System.Linq;

namespace topPlayers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>
            {
                new Player("mike"),
                new Player("john"),
                new Player("piter"),
                new Player("sino"),
                new Player("kookie"),
                new Player("razor"),
                new Player("mimo"),
                new Player("kazo"),
                new Player("rakoon"),
                new Player("dirk"),
                new Player("azoo")
            };

            var sortPlayersByLevel = players.OrderByDescending(player => player.Level);
            var top3PlayersByLevel = sortPlayersByLevel.Take(3);

            var sortPlayerByPower = players.OrderByDescending(player => player.Power);
            var top3PlayersByPower = sortPlayerByPower.Take(3);

            Console.WriteLine("Топ 3 игроков по левелу:");

            foreach (var player in top3PlayersByLevel) 
            {
                player.ShowInfo();
            }

            Console.WriteLine("Топ 3 игроков по силе:");

            foreach (var player in top3PlayersByPower)
            {
                player.ShowInfo();
            }
        }
    }
}

class Player
{
    private static Random _random = new Random();
    private string _name;

    public Player(string name)
    {
        int minimumLevel = 1;
        int maximumLevel = 101;
        int maximumPower = 81;

        _name = name;
        Level = _random.Next(minimumLevel, maximumLevel);
        Power = _random.Next(maximumPower);
    }

    public int Level { get; private set; }
    public int Power { get; private set; }

    public void ShowInfo()
    {
        Console.WriteLine($"Имя: {_name} | Уровень: {Level} | Сила: {Power}");
    }
}
