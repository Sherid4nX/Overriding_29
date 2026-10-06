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

        public void DisplaySkillInfo()
        {
            Console.WriteLine("SKILL NAME : " + skillName);
            Console.WriteLine("BASE POWER : " + basePower);
            Console.WriteLine("MANA COST : " + manaCost);
        }
    }
}