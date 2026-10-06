using System;

namespace GameOverrideDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DEMO OVERLOADING (GAME SKILL) ==");

            Physical slash = new Physical(0.3f, "Slash", 50f, 15f);
            slash.DisplaySkillInfo();

            Console.WriteLine("Menguji overloading method");

            float dmg1 = slash.CalculateDamage();
            Console.WriteLine("Damage (tanpa parameter): " + dmg1);

            float dmg2 = slash.CalculateDamage(2.0f);
            Console.WriteLine("Damage (multiplier 2.0): " + dmg2);

            float dmg3 = slash.CalculateDamage(1.5f, 20f);
            Console.WriteLine("Damage (multiplayer 1.5 defense 20): " + dmg3);

            float dmg4 = slash.CalculateDamage("Piercing");
            Console.WriteLine("Damage (Piercing): " + dmg4);

            float dmg5 = slash.CalculateDamage("Blunt");
            Console.WriteLine("Damage (tanpa parameter): " + dmg5);
            Console.ReadKey();
        }
    }
}