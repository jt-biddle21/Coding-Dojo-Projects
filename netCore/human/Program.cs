using System;

namespace human
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Vehicle myvehicle = new Vehicle();
            Vehicle myvehicle1 = new Vehicle();
            myvehicle.numPassengers = 3;
            Console.WriteLine("My vehicle can hold " + myvehicle.numPassengers + " people");
            Console.WriteLine("My vehicle1 can hold " + myvehicle1.numPassengers + " people");
        }   
    }
    public class Vehicle
    {
        public int numPassengers = 2;
    }
}
