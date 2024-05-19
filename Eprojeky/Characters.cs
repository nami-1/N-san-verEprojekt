using System;

public class Character
{
    public string Name { get; set; } // hp, name and damage
    public int Health { get; set; }
    public int Damage { get; set; }

    protected Character(string name, int health, int damage) //characters characteristics 
    {
        Name = name;
        Health = health;
        Damage = damage;
    }

    public virtual void Attack(Character target, int accuracy)
    {
        Random random = new Random();
        int chance = random.Next(1, 101); // random number generator

        if (chance <= accuracy) // if the attack connects 
        {
            Console.WriteLine($"{Name} attacks {target.Name} and deals {Damage} damage!");
            target.Health -= Damage;  //minus the damage from the target's health
        }
        else
        {
            Console.WriteLine($"{Name} missed!\n"); // if the attack misses
        }

        Console.WriteLine($"{target.Name} have {target.Health} health left.\n"); // remaining health
    }
}