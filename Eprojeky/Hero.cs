 class Player : Character
    {
        public int AttackPower { get; set; }

        public Player(string name, int health, int attackPower)
            : base(name, health)
        {
            AttackPower = attackPower;
        }

        public void Attack(Character character, int accuracy)
        {
            Random rnd = new Random();
            if (rnd.Next(0, 100) < accuracy)
            {
                character.Health -= AttackPower;
                Console.WriteLine($"{Name} attacks {character.Name} for {AttackPower} damage!");
            }
            else
            {
                Console.WriteLine($"{Name} missed the attack!");
            }
        }

        public void Heal()
        {
            Health += 20;
            Console.WriteLine($"{Name} heals for 20 hp!");
        }
    }
