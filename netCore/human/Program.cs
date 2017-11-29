using System;
using System.Threading;
using person;
namespace human
{
    public class Program
    {
        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth)); 
            Console.SetCursorPosition(0, currentLineCursor);
        }
        public static void Main(string[] args)
        {
            bool keepplaying = true;
            while (keepplaying == true)
            {
                int mili = 2000;
                int loading = 550;
                int interval = 1000;
                Console.WriteLine("Welcome to the Game!");
                Thread.Sleep(mili);
                Console.WriteLine("Loading 0%[]");
                Thread.Sleep(interval);
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                ClearCurrentConsoleLine();
                Console.WriteLine("Loading 25%[--]");
                Thread.Sleep(loading);
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                ClearCurrentConsoleLine();
                Console.WriteLine("Loading 30%[-----]");
                Thread.Sleep(loading);
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                ClearCurrentConsoleLine();
                Console.WriteLine("Loading 50%[--------]");
                Thread.Sleep(loading);
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                ClearCurrentConsoleLine();
                Console.WriteLine("Loading 75%[-----------]");
                Thread.Sleep(loading);
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                ClearCurrentConsoleLine();
                Console.WriteLine("Loading 100%[-------------]");
                Thread.Sleep(loading);
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                ClearCurrentConsoleLine();
                person.Ninja Player1 = new person.Ninja("Ningee");
                Console.WriteLine("Player1 Initializing!");
                Thread.Sleep(interval);
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                ClearCurrentConsoleLine();
                person.Samurai Player2 = new person.Samurai("Masumade");
                Console.WriteLine("Player2 Initializing!");
                Thread.Sleep(interval);
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                ClearCurrentConsoleLine();
                person.Human Player3 = new person.Human("Justin");
                Console.WriteLine("Player3 Initializing!");
                Thread.Sleep(mili);
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                ClearCurrentConsoleLine();
                Console.WriteLine("You can type '1' for Player 1's options, '2' for Player 2's options, or '3' for Player 3's options");
                string input = Console.ReadLine(); //User will input their character number
                int x = 0;
                if (x > 3)
                {
                    Console.WriteLine("You need to enter in '1', '2', or '3'!");
                }
                while (input != "Quit")
                {
                    if (input == "quit")
                    {
                        Console.WriteLine("You need to type 'Q'uit");
                        input = Console.ReadLine();
                    }
                    if (input == "Quit")
                    {
                        break;
                    }
                    int counter = 0;
                    while (counter != 20)
                    {
                        while (!int.TryParse(input, out x))
                        {
                            Console.WriteLine("You need to enter in a number!");
                            input = Console.ReadLine();
                        }
                        if (x == 1)
                        {
                            Console.WriteLine("Which enemy would you like to attack?");
                            Console.WriteLine($"Type 'p2' to attack {Player2.name} or 'p3' to attack {Player3.name}");
                            string attack = Console.ReadLine();
                            if (attack == "p2")
                            {
                                Console.WriteLine("Which Attack would you like to preform?");
                                Console.WriteLine("p1a1: <>Basic Attack<> #5 Damage * Strength#");
                                Console.WriteLine("p1a2: <>Steal<> #10 Damage, +10 health#");
                                Console.WriteLine("p1a3: <>Dodge<> #-15 health#");
                            }
                            Player1.Attack(Player2);
                            Console.WriteLine($"{Player3.name} has damaged {Player2.name}, and his health is now {Player2.health}");
                            counter++;
                            input = Console.ReadLine();
                        }
                        if (x == 2)
                        {
                            Player3.Attack(Player1);
                            Console.WriteLine($"{Player3.name} has damaged {Player1.name}, and his health is now {Player1.health}");
                            counter++;
                            input = Console.ReadLine();                  
                        }
                        if (x == 3)
                        {
                            Player2.Attack(Player1);
                            Console.WriteLine($"{Player2.name} has damaged {Player1.name}, and his health is now {Player1.health}");
                            counter++;
                            input = Console.ReadLine();                    
                        }
                        if (counter >= 5)
                        {
                            Console.WriteLine("Type 'Quit' whenever, to exit the fight!");
                        }
                    }
                    if (counter == 10)
                    {
                        input = "Quit";
                        int winner = 0;
                        if (Player2.health <= 0 && Player3.health <= 0)
                        {
                            winner = 1;
                            Console.WriteLine($"Game Over! Player {winner} Won!");
                            break;
                        }
                        if (Player1.health <= 0 && Player3.health <= 0)
                        {
                            winner = 2;
                            Console.WriteLine($"Game Over! Player {winner} Won!");
                            break;
                        }
                        if (Player1.health <= 0 && Player2.health <= 0)
                        {
                            winner = 3;
                            Console.WriteLine($"Game Over! Player {winner} Won!");
                            break;
                        }
                    }
                }
                Console.WriteLine($"If you want to play again, Type 'yes or no'");
                string playagain = Console.ReadLine();
                if (playagain == "yes")
                {
                    keepplaying = true;
                    Console.WriteLine("Restarting...");
                }
                else if (playagain == "no")
                {
                    keepplaying = false;
                    Console.WriteLine("Thank you for playing!");
                    break;
                }
                else
                {
                    Console.WriteLine("You need to type 'yes' or 'no'!");
                }
            }
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
