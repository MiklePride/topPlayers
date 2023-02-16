using System;
using System.Collections.Generic;
using System.Linq;

namespace topPlayers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server();

            server.ShowTop3PlayersByLevel();
            server.ShowTop3PlayersByPower();
            Console.ReadLine();
        }
    }
}

class Server
{
    List<Player> players;

    public Server()
    {
        players = new List<Player>
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
    }

    public void ShowTop3PlayersByLevel()
    {
        int topPlayerCount = 3;
        var sortPlayersByLevel = players.OrderByDescending(player => player.Level);
        var top3PlayersByLevel = sortPlayersByLevel.Take(topPlayerCount);

        Console.WriteLine("Топ 3 игроков по левелу:");

        foreach (var player in top3PlayersByLevel)
        {
            player.ShowInfo();
        }
    }

    public void ShowTop3PlayersByPower()
    {
        int topPlayerCount = 3;
        var sortPlayerByPower = players.OrderByDescending(player => player.Power);
        var top3PlayersByPower = sortPlayerByPower.Take(topPlayerCount);

        Console.WriteLine("Топ 3 игроков по силе:");

        foreach (var player in top3PlayersByPower)
        {
            player.ShowInfo();
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
