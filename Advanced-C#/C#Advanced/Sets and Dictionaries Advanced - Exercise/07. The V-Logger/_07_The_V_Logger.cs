﻿using System;
using System.Collections.Generic;
using System.Linq;

class _07_The_V_Logger
{
    static void Main()
    {
        List<Vlogger> vloggers = new List<Vlogger>();

        while (true)
        {
            string command = Console.ReadLine();
            if (command == "Statistics")
                break;

            string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string vloggerName = tokens[0];
            string action = tokens[1];
            string vloggerToFollowName = tokens[2];

            if (action == "joined")
            {
                if (!vloggers.Any(v => v.Name == vloggerName))
                    vloggers.Add(new Vlogger(vloggerName));
            }
            else
            {
                if (vloggerName == vloggerToFollowName || !vloggers.Any(v => v.Name == vloggerName) ||
                    !vloggers.Any(v => v.Name == vloggerToFollowName))
                    continue;

                Vlogger vlogger = vloggers.Single(v => v.Name == vloggerName);
                vlogger.Following.Add(vloggerToFollowName);

                Vlogger vloggerToFollow = vloggers.Single(v => v.Name == vloggerToFollowName);
                vloggerToFollow.Followers.Add(vloggerName);
            }
        }
        vloggers = vloggers.OrderByDescending(v => v.Followers.Count).ThenBy(v => v.Following.Count).ToList();
        Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

        int count = 1;
        foreach (var vlogger in vloggers)
        {
            Console.WriteLine($"{count}. {vlogger.Name} : {vlogger.Followers.Count} followers, {vlogger.Following.Count} following");
            if (count == 1)
            {
                foreach (var follower in vlogger.Followers)
                    Console.WriteLine($"*  {follower}");
            }
            count++;
        }
    }
}

class Vlogger
{
    public Vlogger(string name)
    {
        Name = name;
        Followers = new SortedSet<string>();
        Following = new HashSet<string>();
    }

    public string Name { get; set; }
    public SortedSet<string> Followers { get; set; }
    public HashSet<string> Following { get; set; }
}