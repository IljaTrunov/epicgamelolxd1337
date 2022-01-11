using System;
using System.IO;

namespace EPICBATTLE
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\opilane\Samples";
            string[] heroes = GetDataFromFile(rootPath + "heroes.txt");
            string[] villian = GetDataFromFile(rootPath + "villians.txt");
            string[] weapon = GetDataFromFile(rootPath + "villainWeapon.txt");





            //string[] heroes = { "Mario", "Chinese woman", "Donkey", "Shrek", "Bomj", "Patrick", "Deadpool", "Garry Snail", "150kg Pudge", "your dad", "bob the builder" };
            //string[] villian = { "Kim Jong-Un", "Putin", "Hitler", "Stalin", "Jew", "Hitman", "Street cleaner", "Lenin", "Trevor from gta 5", "your mother" };
            //string[] weapon = { "gaming mouse", "wooden chain", "some random motherfucker", "super mega powers", "atom bomb", "universe explosion", "fingers", "fist", "fly", "gravity control", "your mothers phone", "No u", "Uno reverse card","middle finger", "fuck you" };

            string randomHero = GetRandomcharacter(heroes);
            string randomVillian = GetRandomcharacter(villian);
            string Heroweapon = GetWeapon(weapon);
            string Villianweapon = GetRandomcharacter(weapon);
            Console.WriteLine($"Your random Hero is {randomHero}");
            Console.WriteLine($"Your random Hero weapon is {Heroweapon}");
            Console.WriteLine($"Your random Villian is {randomVillian}"     );
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

        public static string[] GetDataFromFile(string Filepath)
        {
            string[] dataFromFile = File.ReadAllLines(Filepath);
            return dataFromFile;

        }



    }
}
