public class Player : Character 
{
    public Player(string name, int health, int damage) : base(name, health, damage) //constructor for the player class that takes name, health, and damage as parameters
    {
    }

    public override void Attack(Character target, int accuracy) //this method takes a target character and an accuracy value as parameters
    {
        base.Attack(target, accuracy);  //call the base class's Attack method
    }

    public void Heal() 
    {
        int healingAmount = 20;  //define the amount of health to restore

     
        if (Health + healingAmount > 100)
        {
            healingAmount = 100 - Health;   // this adjust the healing amount to avoid exceeding maximum health
        }

        Health += healingAmount;
        Console.WriteLine($"{Name} is healing {healingAmount} hp!");
        Console.WriteLine($"{Name} has {Health} hp.\n");
    }
}