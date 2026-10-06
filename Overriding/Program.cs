using System;

namespace GameOverrideDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DEMO OVERRIDING (GAME SKILL) ==");

            Console.WriteLine("1. Membuat objek Physical");
            Physical Slash = new Physical(0.3f, "Regular slash", 100, 50);
            Slash.DisplaySkillInfo();
            float slashDamage = Slash.CalculateDamage();
            Console.WriteLine("Damage yang dihasilkan : " + slashDamage + "\n");

            Console.WriteLine("2. Membuat objek Magiical");
            Magic Fireball = new Magic("Fire", "Fireball", 100, 50);
            Fireball.DisplaySkillInfo();
            float fireballhDamage = Fireball.CalculateDamage();
            Console.WriteLine("Damage yang dihasilkan : " + fireballhDamage + "\n");

            Console.WriteLine("3. Membuat objek Heal Skill");
            Heal Regen = new Heal(30f, "Regeneration", 50f, 20f);
            Regen.DisplaySkillInfo();
            float healAmount = Regen.CalculateDamage();
            Console.WriteLine("Heal yang diberikan : " + healAmount + "\n");
            
            Console.ReadKey();
        }
    }
}