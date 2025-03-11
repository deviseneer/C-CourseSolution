using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
    public class Point2D
    {
        private int x;
        private int y;

        public Point2D(int x, int y)
        {
            this.x = x; // this classe's fields
            this.y = y; // private int x and y
        }
    }
    public class Character
    {
        // const and readonly used to defend us from ourself's mistakes
        private const int speed = 10; // cannot be changed
        private readonly int speed2; // can be left not initialized or cannot be changed if initialzed as const
        private Race elf;

        public Character(string race, int armor, int speed2)
        {
            Race = race;
            Armor = armor;
            this.speed2 = speed2;
        }
        public void Hit2(int damage, int speed2) // readonly - from method cannot be assigned
        {
            speed2 = speed2;
        }






        public string Race { get; private set; }
        public int Armor { get; private set; }

        public Character(string race)
        {
            Race = race;
            Armor = 30;
        }

        public Character(string race, int armor)
        {
            Race = race;
            Armor = armor;
        }

        public Character(Race elf)
        {
            this.elf = elf;
        }







        //private static int speed = 10;

        //public int PrintSpeed()
        //{
        //    return speed;
        //}
        //public void IcreaseSpeed()
        //{
        //    speed += 10;
        //}



        // Access Modifiers

        /*private can be only method. all methods and variables private by default */
        //public can be Class and Method
        //internal can be Class and Method. all classes are internal by default
        //protected can be only method.

        //1//private int health = 100; // private fields with lower register in C#

        //public int Health  // (property)свойвства всегда public
        //{
        //    get
        //    {
        //        return health;
        //    }
        //    private set
        //    {
        //        health = value;
        //    }
        //}

        //2// the property expressed by two methods 
        //public int GetHealth()
        //{
        //    return health;
        //}
        //private void SetHealth(int value)
        //{
        //    health = value;
        //}

        /*3 the shortest option ctrl + . on hover*/
        public int Health { get; private set; } = 100;
          


        public void Hit(int damage) // void method doesn't return anything
        {
            //var health = GetHealth() - damage;
            //SetHealth(health);
            if (damage > Health)
                damage = Health;
            //health -= damage;
            Health -= damage;
        }
    }
}
