using System;
using System.Threading;
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
                Console.WriteLine("Welcome to FIGHT CLUB");
                Console.WriteLine("BRAD PITT NOT INVITED");
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
                Console.WriteLine("Enter in name for Player 1");
                string p1name = Console.ReadLine();
                person.Ninja Player1 = new person.Ninja($"{p1name}");
                Console.WriteLine("<>Player1<> Initializing!");
                Thread.Sleep(interval);
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                ClearCurrentConsoleLine();
                Console.WriteLine("Enter in name for Player 2");
                string p2name = Console.ReadLine();
                person.Samurai Player2 = new person.Samurai($"{p2name}");
                Console.WriteLine("><Player2>< Initializing!");
                Thread.Sleep(interval);
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                ClearCurrentConsoleLine();
                Console.WriteLine("Enter in name for Player 3");
                string p3name = Console.ReadLine();
                if (p3name == "Brad")
                {
                    Console.WriteLine("Brad... You're not invited man...");
                    Console.WriteLine("Please enter another name");
                    p3name = Console.ReadLine();
                }
                person.Wizard Player3 = new person.Wizard($"{p3name}");
                //
                Console.WriteLine("<>Player3<> Initializing!");
                Thread.Sleep(mili);
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                ClearCurrentConsoleLine();
                Console.WriteLine("[|]-All players are initialized and ready to go!-[|]");
                Console.WriteLine("Starting Game...");
                string input = "";
                int x = 1;
                while (input != "Quit")
                {
                    int counter = 0;
                    int p3death = 0;
                    int p2death = 0;
                    int p1death = 0;
                    if (input == "quit")
                    {
                        Console.WriteLine("You need to type 'Q'uit");
                        input = Console.ReadLine();
                    }
                    if (input == "Quit")
                    {
                        break;
                    }
                    int deaths = 0;
                    while (counter != 21)
                    {
                        if (x == 1)
                        {
                            if (Player1.health <= 0)
                            {
                                p1death = 1;
                                Console.WriteLine($"{Player1.name} is dead!");
                            }
                            if (deaths == 2)
                            {
                                break;
                            }
                            if (Player1.health > 0 && p1death == 0)
                            {
                                Console.WriteLine($"{Player1.name}'s Turn...");
                                string Pl2 = Player2.name;
                                string Pl3 = Player3.name;
                                int player2health = Player2.health;
                                int player3health = Player3.health;
                                Console.WriteLine($"Enemy Health:{Pl2}: {player2health} ||| {Pl3}: {player3health} ");
                                Console.WriteLine("Which enemy would you like to attack?");
                                Console.WriteLine($"Type 'p2' to attack {Player2.name} or 'p3' to attack {Player3.name}");
                                string p1attack = Console.ReadLine();
                                if (p1attack == "p2") //Attacks player 2
                                // check if they type in somehting other that p2 and p3
                                {
                                    Console.WriteLine($"Which Attack would you like to preform on {Pl2}?");
                                    Console.WriteLine("p2a1: <>Basic Attack<> #5 Damage * Strength#");
                                    Console.WriteLine("p2a2: <>Absorb Health<> #10 Damage, +10 health#");
                                    Console.WriteLine("p2a3: <>Abandon<> #-15 health#");
                                    p1attack = Console.ReadLine();
                                }
                                if (p1attack == "p2a1")
                                {
                                    Player1.Attack(Player2);
                                    Console.WriteLine($"{Player1.name} tickled {Player2.name}, and his health is now {Player2.health}");
                                }
                                if (p1attack == "p2a2")
                                {
                                    Player1.Steal(Player2);
                                    Console.WriteLine($"{Player1.name} stole from {Player2.name}, and his health is now {Player2.health}");
                                }
                                if (p1attack == "p2a3")
                                {
                                    Player1.getAway();
                                    Console.WriteLine($"{Player1.name} chosen not to attack.");
                                }
                                if (p1attack == "p3") //Attacks player 3
                                {
                                    Console.WriteLine($"Which Attack would you like to preform on {Pl3}?");
                                    Console.WriteLine("p3a1: <>Basic Attack<> #5 Damage * Strength#");
                                    Console.WriteLine("p3a2: <>Absorb Health<> #10 Damage, +10 health#");
                                    Console.WriteLine("p3a3: <>Abandon<> #-15 health#");
                                    p1attack = Console.ReadLine();
                                }
                                if (p1attack == "p3a1")
                                {
                                    Player1.Attack(Player3);
                                    Console.WriteLine($"{Player1.name} tickled {Player3.name}, and his health is now {Player3.health}");
                                }
                                if (p1attack == "p3a2")
                                {
                                    Player1.Steal(Player3);
                                    Console.WriteLine($"{Player1.name} stole from {Player3.name}, and his health is now {Player3.health}");
                                }
                                if (p1attack == "p3a3")
                                {
                                    Player1.getAway();
                                    Console.WriteLine($"{Player1.name} chosen not to attack.");
                                }
                            }
                            counter++;
                            if (deaths < 2)
                            {
                                x = 2;
                            } 
                        }
                        if (x == 2)
                        {
                             if (Player2.health <= 0)
                            {
                                p2death = 1;
                                Console.WriteLine($"{Player2.name} is dead!");
                            }
                            if (deaths == 2)
                            {
                                break;
                            }
                            if (Player2.health > 0 && p2death == 0)
                            {
                                Console.WriteLine($"{Player2.name}'s Turn...");
                                string Pl1 = Player1.name;
                                string Pl3 = Player3.name;
                                int player1health = Player1.health;
                                int player3health = Player3.health;
                                Console.WriteLine($"Enemy Health:{Pl1}: {player1health} ||| {Pl3}: {player3health} ");
                                Console.WriteLine("Which enemy would you like to attack?");
                                Console.WriteLine($"Type 'p1' to attack {Player1.name} or 'p3' to attack {Player3.name}");
                                string p2attack = Console.ReadLine();
                                if (p2attack == "p1") //Attacks player 1
                                {
                                    Console.WriteLine($"Which Attack would you like to preform on {Pl1}?");
                                    Console.WriteLine("p1a1: <>Basic Attack<> #5 Damage * Strength#");
                                    Console.WriteLine("p1a2: <>Demolish<> #Insta-kill if player health < 50, otherwise 2 damage * strength#");
                                    Console.WriteLine("p1a3: <>Health Regeneration<> #Regenerate Health#");
                                    p2attack = Console.ReadLine();
                                }
                                if (p2attack == "p1a1")
                                {
                                    Player2.Attack(Player1);
                                    Console.WriteLine($"{Player2.name} sliced {Player1.name}, and his health is now {Player1.health}");
                                }
                                if (p2attack == "p1a2")
                                {
                                    Player2.deathBlow(Player1);
                                    Console.WriteLine($"{Player2.name} squashed {Player1.name}, and his health is now {Player1.health}");
                                }
                                if (p2attack == "p1a3")
                                {
                                    Player2.Meditate();
                                    Console.WriteLine($"{Player2.name} chosen not to attack, and has regenerated some of his health!");
                                }
                                if (p2attack == "p3") //Attacks player 3
                                {
                                    Console.WriteLine($"Which Attack would you like to preform on {Pl1}?");
                                    Console.WriteLine("p3a1: <>Basic Attack<> #5 Damage * Strength#");
                                    Console.WriteLine("p3a2: <>Demolish<> #Insta-kill if player health < 50, otherwise 2 damage * strength#");
                                    Console.WriteLine("p3a3: <>Health Regeneration<> #Regenerate Health#");
                                    p2attack = Console.ReadLine();
                                }
                                if (p2attack == "p3a1")
                                {
                                    Player2.Attack(Player3);
                                    Console.WriteLine($"{Player2.name} sliced {Player3.name}, and his health is now {Player3.health}");
                                }
                                if (p2attack == "p3a2")
                                {
                                    Player2.deathBlow(Player3);
                                    Console.WriteLine($"{Player2.name} squashed {Player3.name}, and his health is now {Player3.health}");
                                }
                                if (p2attack == "p3a3")
                                {
                                    Player2.Meditate();
                                    Console.WriteLine($"{Player2.name} chosen not to attack, and has regenerated some of his health!");
                                }
                            }
                            counter++;
                            if (deaths < 2)
                            {
                                x = 3;
                            } 
                        }
                        if (x == 3)
                        {
                             if (Player3.health <= 0)
                            {
                                p3death = 1;
                                Console.WriteLine($"{Player3.name} is dead!");
                            }
                            if (deaths == 2)
                            {
                                break;
                            }
                            if (Player3.health > 0 && p3death == 0)
                            {
                                Console.WriteLine($"{Player3.name}'s Turn...");
                                string Pl1 = Player1.name;
                                string Pl2 = Player2.name;
                                int player1health = Player1.health;
                                int player2health = Player2.health;
                                Console.WriteLine($"Enemy Health:{Pl1}: {player1health} ||| {Pl2}: {player2health} ");
                                Console.WriteLine("Which enemy would you like to attack?");
                                Console.WriteLine($"Type 'p1' to attack {Player1.name} or 'p2' to attack {Player2.name}");
                                string p3attack = Console.ReadLine();
                                if (p3attack == "p1")
                                {
                                    Console.WriteLine($"Which Attack would you like to preform on {Pl1}?");
                                    Console.WriteLine("p1a1: <>Basic Attack<> #5 Damage * Strength#");
                                    Console.WriteLine("p1a2: <>Hat Rabbit<> #Random damage from 20 - 50hp#");
                                    Console.WriteLine("p1a3: <>Pray<> #Heals 10 * intelligence#");
                                    p3attack = Console.ReadLine();
                                }
                                if (p3attack == "p1a1")
                                {
                                    Player3.Attack(Player1);
                                    Console.WriteLine($"{Player3.name} smacked {Player1.name}, and his health is now {Player1.health}");
                                }
                                if (p3attack == "p1a2")
                                {
                                    Player3.Fireball(Player1);
                                    Console.WriteLine($"{Player3.name} set his rabbit on {Player1.name}, and his health is now {Player1.health}");
                                }
                                if (p3attack == "p1a3")
                                {
                                    Player3.Heal();
                                    Console.WriteLine($"{Player3.name} chosen not to attack, and has regenerated some of his health!");
                                }
                                if (p3attack == "p2")
                                {
                                    Console.WriteLine($"Which Attack would you like to preform on {Pl2}?");
                                    Console.WriteLine("p2a1: <>Basic Attack<> #5 Damage * Strength#");
                                    Console.WriteLine("p2a2: <>Hat Rabbit<> #Random damage from 20 - 50hp#");
                                    Console.WriteLine("p2a3: <>Pray<> #Heals 10 * intelligence#");
                                    p3attack = Console.ReadLine();
                                }
                                if (p3attack == "p2a1")
                                {
                                    Player3.Attack(Player2);
                                    Console.WriteLine($"{Player3.name} smacked {Player2.name}, and his health is now {Player2.health}");
                                }
                                if (p3attack == "p2a2")
                                {
                                    Player3.Fireball(Player2);
                                    Console.WriteLine($"{Player3.name} set his rabbit {Player2.name}, and his health is now {Player2.health}");
                                }
                                if (p3attack == "p2a3")
                                {
                                    Player3.Heal();
                                    Console.WriteLine($"{Player3.name} chosen not to attack, and has regenerated some of his health!");
                                }
                            }
                            counter++;
                            if (deaths < 2)
                            {
                                x = 1; //Resets backs to player 1's turn         
                            } 
                        }
                        if (counter >= 5)
                        {
                            Console.WriteLine("Type 'Quit' whenever, to exit the fight!");
                        }
                    }
                    deaths = p1death + p2death + p3death;
                    if (deaths == 2)
                    {
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
                        input = "Quit";
                    }
                }
                Console.WriteLine($"If you want to play again, Type 'yes or no'");
                string playagain = Console.ReadLine();
                if (playagain == "yes")
                {
                    keepplaying = true;
                    Console.WriteLine("Restarting...");
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    ClearCurrentConsoleLine();
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
