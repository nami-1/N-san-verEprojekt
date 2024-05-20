﻿using System;
using Eprojeky;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("Welocome to my game");
        System.Console.WriteLine("Your goal is to defeat the monster!");

        Player player = new Player("Hero", 100, 20); //sets players health 
        Enemy enemy = new Enemy("Villian", 150, 15);  //sets enemy health 
        Boss boss = new Boss("Boss", 300, 15);  //sets boss health 



        Console.WriteLine($"Your {player.Name} has {player.Health} hp.");
        Console.WriteLine($"{enemy.Name} has {enemy.Health} hp.\n");

        Console.WriteLine("Lets begin");
while (player.Health > 0 && enemy.Health > 0) //when the hero and the villian is alive this happens
{
    Console.WriteLine("Choose an attack"); //lets the player decide which type of attack to make eventually heal too
    Console.WriteLine("1. Normal Attack (80% accurancy)");
    Console.WriteLine("2. Hard Attack (50% accurancy)");
    Console.WriteLine("3. Heal");
   
    int choice;

    if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)    //validate player's input and ensure it is a number between 1 and 3
    {
        Console.WriteLine("Invalid Input! Try Again!");
        // skips the loop if the player enters an incorrect value
        continue;
    }

    switch (choice)  //does what the player chose
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

    if (enemy.Health <= 0) // if the villans hp is/below 0 the game ends
    {
        Console.WriteLine("The villian is deafeated congratulations !");

        Console.WriteLine("Now you need to fight the boss");
        
        Console.WriteLine($"{boss.Name} has {boss.Health} hp.\n");


        break;
    }

    
    enemy.Attack(player, 70); // this means that the monster got a 70% accurancy

    // this does so that that the players health doesnt go over 100
    if (player.Health > 100)
    {
        player.Health = 100;
        Console.WriteLine($"{player.Name} got max 100 hp\n");
    }

    
    if (player.Health <= 0)
    {
        Console.WriteLine($"You lose! {enemy.Name} defeated you.");
        break;
    }
}

        Console.ReadLine(); 
    }

    static int GetPlayerChoice()
    {
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice)) //loop until a valid integer is entered

        {
            Console.WriteLine("Incorrect value, please try entering a number");
        }
        return choice; 
    }
}