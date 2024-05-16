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

  
}