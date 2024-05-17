public class Player : Character 
{
    public Player(string name, int health, int damage) : base(name, health, damage)
    {
    }

    public override void Attack(Character target, int accuracy)
    {
        base.Attack(target, accuracy);
    }

    public void Heal()
    {
        int healingAmount = 20;

     
        if (Health + healingAmount > 100)
        {
            healingAmount = 100 - Health;
        }

        Health += healingAmount;
        Console.WriteLine($"{Name} is healing {healingAmount} hp!");
        Console.WriteLine($"{Name} has {Health} hp.\n");
    }
}