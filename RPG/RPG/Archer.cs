using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal class Archer
    {
        static public int health = 50;
        static public int mana = 30;
        static public int defense = 30;
        static public int dexterity = 45;

        static public void show()
        {
            Console.WriteLine("================1================");
            Console.WriteLine("A R C H E R");
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Mana: " + mana);
            Console.WriteLine("Defense: " + defense);
            Console.WriteLine("Dexterity: " + dexterity);
        }

    }

}
