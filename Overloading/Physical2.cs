using System;

namespace GameOverrideDemo
{
    public class Physical : Skill
    {
        private float critRate;
        
        public Physical()
        {
            critRate = 0.1f;
            Console.WriteLine(">>Made with default physical constructor<<");
        }

        public Physical(float crit, String name, float basePower, float manaCost) : base(name, basePower, manaCost)
        {
            Console.WriteLine(">>Made with parameted physical constructor<<");
            this.critRate = crit;
        }

        public override float CalculateDamage()
        {
            Console.WriteLine("[PhysicalSkill.CalculateDamage] dari critical hit");
            float damage = basePower * (1 + critRate);
            return damage;
        }

        
        public new void DisplaySkillInfo()
        {
            base.DisplaySkillInfo();
            Console.WriteLine("CRIT RATE : " + (critRate + 100) + "%");
            Console.WriteLine("===================================");
        }
    }
}