using System;
namespace GameOverrideDemo
{
    public class Skill
    {
        protected String skillName;
        protected float basePower;
        protected float manaCost;

        public Skill()
        {
            skillName = "Basic Skill";
            basePower = 1000;
            manaCost = 140;
            Console.WriteLine(">>Made with default constructor<<");
        }

        public Skill(String name, float basePwr, float cost)
        {
            skillName = name;
            basePower = basePwr;
            manaCost = cost;
            Console.WriteLine(">>Made with parameted constructor<<");
        }

        public virtual float CalculateDamage()
        {
            Console.WriteLine("[Skill.CalculateDamage] Menghitung damage dasar...");
            return basePower;
        }

        public float CalculateDamage(float multiplier)
        {
            Console.WriteLine($"Menghitung damage dengan multiplier {multiplier}");
            return multiplier;
        }

        public float CalculateDamage(float multiplier, float targetDefense)
        {
            Console.WriteLine($"Menghitung dengan multiplier {multiplier} dan targetDefense {targetDefense}");
            float damage = basePower * multiplier;
            damage = targetDefense * 0.5f;
            if (damage < 0) damage = 0;
            return damage;
        }

        public float CalculateDamage(String damageType)
        {
            Console.WriteLine($"Menghitung damage dengan damage tipe: {damageType}");
            float damage = basePower;
            if (damageType == "Piercing")
            damage *= 1.3f;

            else if (damageType == "Blunt")
            damage *= 1.1f;

            return damage;
        }
        public void DisplaySkillInfo()
        {
            Console.WriteLine("SKILL NAME : " + skillName);
            Console.WriteLine("BASE POWER : " + basePower);
            Console.WriteLine("MANA COST : " + manaCost);
        }
    }
}