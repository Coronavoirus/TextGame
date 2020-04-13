using System;

namespace ConsoleApp1
{
    class Player
    {
        public string Role { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public int Money { get; set; }
        public int Stealth { get; set; }
        public int Magic { get; set; }

        public Player(string role, int health, int damage, int money, int stealth, int magic)
        {
            Role = role;
            Health = health;
            Damage = damage;
            Money = money;
            Stealth = stealth;
            Magic = magic;
        }
    }

    class Program
    {
        public static Player player = new Player("", 0, 0, 0, 0, 0);

        static void Main(string[] args)
        {
            Initialize();
        }

        static void Initialize()
        {
            Console.WriteLine("Choose your role:                                                                                              (R)ogue \n                                                                                                               (K)night\n                                                                                                               (M)age  ");
            string role = Console.ReadLine();

            switch (role) {
                case "r":
                    player.Role = "Rogue";
                    player.Health = 50;
                    player.Damage = 25;
                    player.Money = 0;
                    player.Stealth = 75;
                    player.Magic = 5;
                    break;
                case "k":
                    player.Role = "Knight";
                    player.Health = 75;
                    player.Damage = 45;
                    player.Money = 0;
                    player.Stealth = 25;
                    player.Magic = 0;
                    break;
                case "m":
                    player.Role = "Mage";
                    player.Health = 25;
                    player.Damage = 25;
                    player.Money = 0;
                    player.Stealth = 50;
                    player.Magic = 10;
                    break;
            }

            Village1();
        }

        static void Village1()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the village.");
            Console.ReadLine();
        }
    }
}