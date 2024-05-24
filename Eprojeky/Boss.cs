class Boss : Enemy
    {
        public Boss(string name, int health, int attackPower)
            : base(name, health, attackPower)
        {
        }

        public void SpecialAttack(Player player)
        {
            Random rnd = new Random();
            if (rnd.Next(0, 100) < 60) // 60% accuracy for special attack
            {
                int damage = AttackPower * 2; // special attack does double damage
                player.Health -= damage;
                Console.WriteLine($"{Name} uses special attack on {player.Name} for {damage} damage!");
            }
            else
            {
                Console.WriteLine($"{Name} missed the special attack!");
            }
        }
    }
