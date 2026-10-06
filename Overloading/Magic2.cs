using System;

namespace GameOverrideDemo
{
    public class Magic : Skill
    {
        private String elementType;
        
        public Magic()
        {
            elementType = "Earth";
            Console.WriteLine(">>Made with default magical constructor<<");
        }

        public Magic(String element, String name, float basePower, float manaCost) : base(name, basePower, manaCost)
        {
            Console.WriteLine(">>Made with parameted magical constructor<<");
            this.elementType = element;
        }

        public override float CalculateDamage()
        {
            Console.WriteLine("[MagicSkill.CalculateDamage] dari tenaga dalam");
            float damage = basePower;
            if (elementType == "Fire")
            {
                damage = 1.5f;
                Console.WriteLine("Bonus elemen Fire! Bonus damage 1.5 kali!");
            }

            else if (elementType == "Ice")
            {
                damage = 1.2f;
                Console.WriteLine("Bonus elemen Ice! Bonus damage 1,2 kali!");
            }

            return damage;
        }

        public new void DisplaySkillInfo()
        {
            base.DisplaySkillInfo();
            Console.WriteLine("ELEMENT TYPE : " + elementType);
            Console.WriteLine("===================================");
        }
    }
}