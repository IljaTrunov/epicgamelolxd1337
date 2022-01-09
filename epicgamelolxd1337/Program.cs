using System;

namespace EPICBATTLE
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] heroes = { "Mario", "Chinese woman", "Donkey", "Shrek", "Bomj", "Patrick", "Deadpool", "Garry Snail", "150kg Pudge" };
            string[] villian = { "Kim Jong-Un", "Putin", "Hitler", "Stalin", "Jew", "Hitman", "Street cleaner", "Lenin", "Trevor from gta 5", "your mother" };
            string[] weapon = { "gaming mouse", "wooden chain", "some random motherfucker", "super mega powers", "atom bomb", "universe explosion", "fingers", "fist", "fly", "gravity control", "your mothers phone", "No u", "Uno reverse card" };

            string randomHero = GetRandomcharacter(heroes);
            string randomVillian = GetRandomcharacter(villian);
            string Heroweapon = GetWeapon(weapon);
            string Villianweapon = GetRandomcharacter(weapon);
            Console.WriteLine($"Your random Hero is {randomHero}");
            Console.WriteLine($"Your random Hero weapon is {Heroweapon}");
            Console.WriteLine($"Your random Villian is {randomVillian}");
            Console.WriteLine($"Your random Villian weapon is {Villianweapon}");
        }

        public static string GetRandomcharacter(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return someArray[randomIndex];

        }
        public static string GetWeapon(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndexOne = rnd.Next(0, someArray.Length);

            return someArray[randomIndexOne];

        }



    }
}