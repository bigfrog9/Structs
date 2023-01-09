using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    internal class Program
    {

        //Programming:
        //1) Data -- stores things
        //2) code -- does things (to/with data)
        
        //Encapsulation
        //1) data -- structs. classes, ...
        //2) code -- methods!

        struct Vector2
        {
            // when you don't put "public" it defaults to "private"
            public int x;
            public int y;
        }

        // details of weapon
        struct Weapon
        {
            // when you don't put "public" it defaults to "private"
            public string name;
            public int durability;
            public int strength;
            public int speed;
            public bool sharp;
        }

        //different weapons, each has the struct
        static Weapon sword;
        static Weapon hammer;

        //player
        static Vector2 playerPosition;
        static int health;
        static int shield;
        static int lives;
        static string name; //name

        //enemies
        static Vector2 enemy1Position;
        static Vector2 enemy2Position;
        static Vector2 enemy3position;

        static void Main(string[] args)
        {
            sword.name = "Sword";
            sword.strength = 50;
            sword.speed = 10;
            sword.durability = 98;
            sword.sharp = true;

            Console.WriteLine("Weapon: " + sword.name);
            Console.WriteLine();
            Console.WriteLine("Strength: " + sword.strength);
            Console.WriteLine();
            Console.WriteLine("Speed: " + sword.speed);
            Console.WriteLine();
            Console.WriteLine("Durability: " + sword.durability);
            Console.WriteLine();
            Console.WriteLine("Sharp? " + sword.sharp);

            Console.ReadKey(true);
        }
    }
}
