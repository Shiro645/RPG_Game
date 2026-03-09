namespace Scripts.Inventory.Equipment.Weapon
{
    public class Skill
    {
        private string name;
        private string description;

        private int dpsPercent
        {
            get { return 0; }
            set
            {
                if (value < 0)
                {
                    dpsPercent = 100;
                }
                else
                {
                    dpsPercent = value;
                }
            }
        }

        private Scripts.Utils.SkillStun skillStun;
        private int skillStunRate
        {
            get { return 0; }
            set
            {
                if (value < 0)
                {
                    skillStunRate = 0;
                }
                else
                {
                    skillStunRate = value;
                }
            }
        }

        public Skill(string name, string description, int dpsPercent, Scripts.Utils.SkillStun skillStun, int skillStunRate)
        {
            this.name = name;
            this.description = description;

            this.dpsPercent = dpsPercent;

            this.skillStun = skillStun;
            this.skillStunRate = skillStunRate;
        }
    }
}