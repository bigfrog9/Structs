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
            int durability;
            public int strength;
            int speed;
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
            sword.strength = 50;

            Console.ReadKey(true);
        }
    }
}
