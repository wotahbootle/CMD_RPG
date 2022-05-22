using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal class Mage
    {
        static public int health = 40;
        static public int mana = 50;
        static public int defense = 25;
        static public int magic = 60;

        static public void show()
        {
            Console.WriteLine("================3================");
            Console.WriteLine("M A G E");
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Mana: " + mana);
            Console.WriteLine("Defense: " + defense);
            Console.WriteLine("Magic: " + magic);
        }
    }
}
