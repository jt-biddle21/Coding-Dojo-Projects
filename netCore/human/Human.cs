using System;

namespace person
{
    public class Person
    {
        public string name;
        public int strength = 3;
        public int intelligence = 3;
        public int dexterity = 3;
        public int health = 100;

        public Person(string first, int str, int intel, int dex, int h)
        {
            name = first;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            health = h;
        }
        public void Attack(Person enemy)
        {
            enemy.health -= 5 * strength;
        }
    }
}