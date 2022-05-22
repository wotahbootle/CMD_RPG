using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal class Berserker
    {
        static public int health = 75;
        static public int fury = 35;
        static public int defense = 40;
        static public int strenght = 45;

        static public void show()
        {
            Console.WriteLine("================2================");
            Console.WriteLine("B E R S E R K E R");
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Fury :" + fury);
            Console.WriteLine("Defense: " + defense);
            Console.WriteLine("Strenght: " + strenght);
        }
    }

}
