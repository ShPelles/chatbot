﻿using BasePlugin;
using BasePlugin.Interfaces;
using BasePlugin.Records;
using CountDown;
using Dals;
using DiceRoller;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new Host(new MemoryDal(), new PluginsMenu(), new PluginsManager());
            Console.WriteLine(host.Run("HelP", ""));

            Console.WriteLine(host.Run("4", ""));
            Console.WriteLine(host.Run("test", ""));
            Console.WriteLine(host.Run("again", ""));
            Console.WriteLine(host.Run("and again...", ""));
            Console.WriteLine(host.Run("exit", ""));

            Console.WriteLine(host.Run("3", ""));
            Console.WriteLine(host.Run("3", ""));
            Console.WriteLine(host.Run("7", ""));
            Console.WriteLine(host.Run("ht", ""));

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
