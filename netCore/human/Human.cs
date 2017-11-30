using System;

namespace person
{
    public class Human // Creates a 'base' human that all the characters will inherit attributes from
    {
        public string name;
        public int strength = 3;
        public int intelligence = 3;
        public int dexterity = 3;
        public int health = 100;

        public Human(string first)
        {
            name = first;
        }
        public void Attack(Human enemy) // Adds an attack method that all characters can use
        {
            enemy.health -= 5 * strength;
        }
    }
    public class Ninja : Human // Creates a Ninja that inherits from Human class
    {
        // Sets the name of the Ninja that was created, and sets the dexterity to what ninjas have by defaut using 'base'
         public Ninja(string first): base(first) 
        {   
            base.dexterity = 175;
        }
        // Personal method that only the Ninja can use, and attacks a 'human' character
        public void Steal(Human enemy)
        {
            enemy.health -= 10;
            if (health != 100)
            {
                health += 10;
            }
            if (health > 100)
            {
                health = 100;
            }
        }
        public Ninja getAway()
        {
            if (health > 15)
            {
                health -= 15;
            }
            else
            {
                Console.WriteLine("You dont have enough health to preform this move!");
            }
            return this;
        }
    }
    public class Wizard : Human // Creates a Wizard that inherits from Human class
    {
        public Wizard(string first): base(first)
        {
            base.intelligence = 25;
            base.health = 50;
        }
        public Wizard Heal()
        {
            if (health < 50)
            {
                health += 10 * intelligence;
            }
            if (health > 50)
            {
                health = 50;
            }
            return this;
        }
        public void Fireball(Human enemy)
        {
            Random rand = new Random();
            int damage = rand.Next(20, 50);
            enemy.health -= damage;
        }
    }
    public class Samurai : Human
    {
        public Samurai(string first): base(first)
        {
            base.strength = 25;
            base.health = 200;
        }
        public void deathBlow(Human enemy)
        {
            if (enemy.health <= 50)
            {
                enemy.health = 0;
            }
            else
            {
                enemy.health = 2 * strength;
            }
        }
        public void Meditate()
        {
            health += 75;
        }
    }
}