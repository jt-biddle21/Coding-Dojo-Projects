using System;
using person;
namespace human
{
    public class Program
    {
        public static void Main(string[] args)
        {
            person.Human Player3 = new person.Human("Justin");
            person.Ninja Player1 = new person.Ninja("Ningee");
            person.Samurai Player2 = new person.Samurai("Masumade");
            Player1.Steal(Player2);
            Console.WriteLine($"{Player1.name} has damaged {Player2.name}, and his health is now {Player2.health}");
            Player2.deathBlow(Player1);
            Console.WriteLine($"{Player2.name} has damaged {Player1.name}, and his health is now {Player1.health}");
            Player1.getAway();
            Console.WriteLine($"{Player1.name} has got away!, and his health is now {Player1.health}");
            Player2.deathBlow(Player1);
            Console.WriteLine($"{Player2.name} has damaged {Player1.name}, and his health is now {Player1.health}");
        }   
        private string _name;
        private int _health, _strength, _intelligence, _dexterity;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name.Length == 0)
                {
                    throw new ArgumentOutOfRangeException("Name null");
                }
                else
                {
                    _name = value;
                }
            }            
        }
        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                if (_health < 0 || _health > 200)
                {
                    throw new ArgumentOutOfRangeException("Health too high!");
                }
                else
                {
                    _health = value;
                }
            }            
        }
        public int Strength
        {
            get
            {
                return _strength;
            }
            set
            {
                if (_strength < 0 || _strength > 200)
                {
                    throw new ArgumentOutOfRangeException("Strength too high!");
                }
                else
                {
                    _strength = value;
                }
            }            
        }
        public int Intelligence
        {
            get
            {
                return _intelligence;
            }
            set
            {
                if (_intelligence < 0 || _intelligence > 200)
                {
                    throw new ArgumentOutOfRangeException("Intelligence too high!");
                }
                else
                {
                    _intelligence = value;
                }
            }            
        }
        public int Dexterity
        {
            get
            {
                return _dexterity;
            }
            set
            {
                if (_dexterity < 0 || _dexterity > 200)
                {
                    throw new ArgumentOutOfRangeException("Dexterity too high!");
                }
                else
                {
                    _dexterity = value;
                }
            }            
        }
    }
}
