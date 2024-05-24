  class Enemy : Character
    {
        protected int AttackPower { get; set; } // Changed to protected

        public Enemy(string name, int health, int attackPower)
            : base(name, health)
        {
            AttackPower = attackPower;
        }

        public void Attack(Player player, int accuracy)
        {
            Random rnd = new Random();
            if (rnd.Next(0, 100) < accuracy)
            {
                player.Health -= AttackPower;
                Console.WriteLine($"{Name} attacks {player.Name} for {AttackPower} damage!");
            }
            else
            {
                Console.WriteLine($"{Name} missed the attack!");
            }
        }
    }