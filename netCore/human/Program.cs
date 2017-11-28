using System;
using person;
namespace human
{
    public class Program
    {
        public static void Main(string[] args)
        {
            person.Person Player1 = new person.Person("Justin", 10, 10, 10, 100);
            person.Person Player2 = new person.Person("Person2", 5, 5, 5, 100);
            Player1.Attack(Player2);
            Console.WriteLine($"{Player1.name} has damaged {Player2.name}, and his health is now {Player2.health}");
            // Vehicle car = new Vehicle(5);
            // Vehicle bike = new Vehicle(1);
            // Console.WriteLine(car.distance);
            // Console.WriteLine(bike.distance);
            // car.Move(70.8);
            // Console.WriteLine(car.distance);
            // Console.WriteLine(bike.distance);
        }   
    }
    // public class Vehicle
    // {
    //     public int numPassengers;
    //     public double distance = 0.0;
    //     public Vehicle(int val)
    //     {
    //         numPassengers = val;
    //     }
    //     public Vehicle(int val, double odo)
    //     {
    //         numPassengers = val;
    //         distance = odo;

    //     }
    //     public int Move(double miles)
    //     {
    //         distance += miles;
    //         return (int)distance;
    //     }
    //     public int Move(double miles, bool km)
    //     {
    //         if (km == true)
    //         {
    //             miles = miles * 0.62;
    //         }
    //         return Move(miles);
    //     }
    // }
    // private string _name;
    // private int _health, _strength, _intelligence, _dexterity;

    // public string Name
    // {
    //     get
    //     {
    //         return _name;
    //     }
    //     set
    //     {
    //         if (_name.Length == 0)
    //         {
    //             throw new ArgumentOutOfRangeException("Name null");
    //         }
    //         else
    //         {
    //             _name = value;
    //         }
    //     }            
    // }
    // public string Health
    // {
    //     get
    //     {
    //         return _health;
    //     }
    //     set
    //     {
    //         if (_health < 0 || _health > 200)
    //         {
    //             throw new ArgumentOutOfRangeException("Health too high");
    //         }
    //         else
    //         {
    //             _health = value;
    //         }
    //     }            
    // }
    // public string Strength
    // {
    //     get
    //     {
    //         return _strength;
    //     }
    //     set
    //     {
    //         if (_strength < 0 || _strength > 200)
    //         {
    //             throw new ArgumentOutOfRangeException("Name null");
    //         }
    //         else
    //         {
    //             _name = value;
    //         }
    //     }            
    // }
    // public string Name
    // {
    //     get
    //     {
    //         return _name;
    //     }
    //     set
    //     {
    //         if (_name.Length == 0)
    //         {
    //             throw new ArgumentOutOfRangeException("Name null");
    //         }
    //         else
    //         {
    //             _name = value;
    //         }
    //     }            
    // }
    // public string Name
    // {
    //     get
    //     {
    //         return _name;
    //     }
    //     set
    //     {
    //         if (_name.Length == 0)
    //         {
    //             throw new ArgumentOutOfRangeException("Name null");
    //         }
    //         else
    //         {
    //             _name = value;
    //         }
    //     }            
    // }
    }
