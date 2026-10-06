using System;

namespace GameOverrideDemo
{
    public class Heal : Skill
    {
        private float bonusHeal;
        
        public Heal()
        {
            bonusHeal = 20f;
            Console.WriteLine(">>Made with default heal constructor<<");
        }

        public Heal(float heal, String name, float basePower, float manaCost) : base(name, basePower, manaCost)
        {
            Console.WriteLine(">>Made with parameted heal constructor<<");
            this.bonusHeal = heal;
        }

        public override float CalculateDamage()
        {
            Console.WriteLine("[HealSkill.CalculateDamage] dari heal yang diberikan");
            float healAmount = basePower + bonusHeal;
            return healAmount;
        }
        public new void DisplaySkillInfo()
        {
            base.DisplaySkillInfo();
            Console.WriteLine("HEAL BONUS : " + bonusHeal);
            Console.WriteLine("===================================");
        }
    }
}