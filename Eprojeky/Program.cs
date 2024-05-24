﻿using System;

namespace Eprojeky
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to my game");
            Console.WriteLine("Your goal is to defeat the monster!");

            Player player = new Player("Hero", 100, 20); //sets player's health
            Enemy enemy = new Enemy("Villain", 150, 15);  //sets enemy's health
            Boss boss = new Boss("Boss", 300, 15);  //sets boss's health

            Console.WriteLine($"Your {player.Name} has {player.Health} hp.");
            Console.WriteLine($"{enemy.Name} has {enemy.Health} hp.\n");

            Console.WriteLine("Let's begin");

            while (player.Health > 0 && enemy.Health > 0) //when the hero and the villain are alive this happens
            {
                Console.WriteLine("Choose an attack");
                Console.WriteLine("1. Normal Attack (80% accuracy)");
                Console.WriteLine("2. Hard Attack (50% accuracy)");
                Console.WriteLine("3. Heal");

                int choice;

                if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3) //validate player's input
                {
                    Console.WriteLine("Invalid Input! Try Again!");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        player.Attack(enemy, 80);
                        break;
                    case 2:
                        player.Attack(enemy, 50);
                        break;
                    case 3:
                        player.Heal();
                        break;
                    default:
                        Console.WriteLine("Wrong choice! Try Again!");
                        break;
                }

                Console.WriteLine($"Your {player.Name} has {player.Health} hp.");
                Console.WriteLine($"{enemy.Name} has {enemy.Health} hp.\n");

                if (enemy.Health <= 0)
                {
                    Console.WriteLine("The villain is defeated, congratulations!");
                    Console.WriteLine("Now you need to fight the boss");
                    Console.WriteLine($"{boss.Name} has {boss.Health} hp.\n");
                    break;
                }

                enemy.Attack(player, 70); // the monster's attack with 70% accuracy

                if (player.Health > 100)
                {
                    player.Health = 100;
                    Console.WriteLine($"{player.Name} has max 100 hp\n");
                }

                Console.WriteLine($"Your {player.Name} has {player.Health} hp.");
                Console.WriteLine($"{enemy.Name} has {enemy.Health} hp.\n");

                if (player.Health <= 0)
                {
                    Console.WriteLine($"You lose! {enemy.Name} defeated you.");
                    break;
                }
            }

            // Boss battle
            while (player.Health > 0 && boss.Health > 0)
            {
                Console.WriteLine("Choose an attack");
                Console.WriteLine("1. Normal Attack (80% accuracy)");
                Console.WriteLine("2. Hard Attack (50% accuracy)");
                Console.WriteLine("3. Heal");

                int choice;

                if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3) //validate player's input
                {
                    Console.WriteLine("Invalid Input! Try Again!");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        player.Attack(boss, 80);
                        break;
                    case 2:
                        player.Attack(boss, 50);
                        break;
                    case 3:
                        player.Heal();
                        break;
                    default:
                        Console.WriteLine("Wrong choice! Try Again!");
                        break;
                }

                Console.WriteLine($"Your {player.Name} has {player.Health} hp.");
                Console.WriteLine($"{boss.Name} has {boss.Health} hp.\n");

                if (boss.Health <= 0)
                {
                    Console.WriteLine("The boss is defeated, congratulations!");
                    break;
                }

                boss.SpecialAttack(player); // boss uses its special attack

                if (player.Health > 100)
                {
                    player.Health = 100;
                    Console.WriteLine($"{player.Name} has max 100 hp\n");
                }

                Console.WriteLine($"Your {player.Name} has {player.Health} hp.");
                Console.WriteLine($"{boss.Name} has {boss.Health} hp.\n");

                if (player.Health <= 0)
                {
                    Console.WriteLine($"You lose! {boss.Name} defeated you.");
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}