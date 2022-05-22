using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace RPG
{
    internal class Program
    {
        [System.Serializable]
        struct Character
        {
            public string name;
            public string gender;
            public int option;
        }
        static List<Character> character1 = new List<Character>();


        enum menu {create = 1, contnue, delete, exit }
        enum opcao { archer = 1, berserker, mage }

        static void Main(string[] args)
        {
            load();

            bool close = false;
            while (!close)
            {
                Console.WriteLine("LEGEND OF YOU");
                Console.WriteLine("\n1 - NEW HERO\n2 - CONTINUE\n3 - DELETE HERO\n4 - EXIT GAME");

                menu option = (menu)int.Parse(Console.ReadLine());

                switch (option)
                {
                    case menu.create:
                        create();
                        break;

                    case menu.contnue:
                        contnue();
                            break;

                    case menu.delete:
                        delete();
                        break;

                    case menu.exit:
                        close = true;
                        break;

                }
                Console.Clear();

            }


         
        }
        static void create()
        {
            Console.Clear();
            Character characters = new Character();
            Console.Write("Name: ");
            characters.name = (Console.ReadLine());
            Console.WriteLine("Gender: [M] [F]");
            characters.gender = Console.ReadLine();
            Console.WriteLine("Classes: ");

            Archer.show();
            Berserker.show();
            Mage.show();

            Console.Write("Option: ");
            characters.option = int.Parse(Console.ReadLine());

            Console.Clear();
            if (characters.option == 1)
            {
                Archer.show();
            }
            else if (characters.option == 2)
            {
                Berserker.show();
            }
            else if (characters.option == 3)
            {
                Mage.show();
            }
            Console.WriteLine("\nConfirm choice? \n[Y] [N]");
            string choice = Console.ReadLine();
            if (choice == "n" || choice =="N")
            {
                create();
            }
            else if(choice == "y" || choice == "Y")
            {
                character1.Add(characters);
                save();
            }
            
            
        }
        static void save()
        {
            FileStream stream = new FileStream("RpgOfYou.sad", FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();

            encoder.Serialize(stream, character1);

            stream.Close();
        }

        static void load()
        {
            FileStream stream = new FileStream("RpgOfYou.sad", FileMode.OpenOrCreate);

            try
            {
                BinaryFormatter encoder = new BinaryFormatter();
                character1 = (List<Character>)encoder.Deserialize(stream);

                if (character1 == null)
                {
                    character1 = new List<Character>();

                }
            }
            catch (Exception)
            {
                character1 = new List<Character>();
            }
            stream.Close();
        }
        static void contnue()
        {
            Console.Clear();
            
            if (character1.Count > 0)
            {

                list();
                
            }
            else
            {
                Console.WriteLine("No Heroes yet! Try to create one.");
                Console.ReadLine();
                create();
            }
            Console.ReadLine();
        }
        static void delete()
        {
            list();
            Console.WriteLine("\nDelete Hero by ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("\nSelected ID: " + id);
            Console.WriteLine("Confirm? \n[Y] [N]");
            string conf = Console.ReadLine();

            if(conf == "y" || conf == "Y")
            {
                if (id >= 0 && id < character1.Count)
                {
                    character1.RemoveAt(id);
                    Console.Clear();
                    Console.WriteLine("DELETED");
                    Console.ReadLine();
                    save();
                }
                else
                {
                    Console.WriteLine("Invalid ID");

                }
            }
            else if(conf == "n" || conf == "N")
            {
                save();
            }
        }
        static void list()
        {
            int id = 0;
            Console.WriteLine("H E R O E S");
            Console.WriteLine("Archer 1 || Berserker 2 || Mage 3");
            foreach (Character character in character1)
            {
                Console.WriteLine("===============================");
                Console.WriteLine("ID: " + id);
                Console.WriteLine("Name: " + character.name);
                Console.WriteLine("\nHealth: " + Berserker.health);         
                Console.WriteLine("Gender: " + character.gender);
                Console.WriteLine("Class: " + character.option);
                id++;
            }
           
        }
    }
}
