namespace Scripts.Inventory.Equipment.Weapon.Utils
{
    public class Skill
    {
        public string Name { get; }
        public string Description { get; }

        public int Level { get; private set; }

        public int DPSPercent { get; }

        public SkillStun SkillStun { get; }
        public int SkillStunRate { get; }

        public int CoolDown { get; }

        public int[] DPSPercentBonuses { get; private set; }
        public int[] SkillStunRateBonuses { get; private set; }
        public int[] CoolDownBonuses { get; private set; }

        public Skill(string name, string description, int level, int dpsPercent, SkillStun skillStun, int skillStunRate, int coolDown)
        {
            Name = name;
            Description = description;
            Level = level;
            DPSPercent = dpsPercent;
            SkillStun = skillStun;
            CoolDown = coolDown;
        }

        public void SetSkillStunRate(int newRate)
        {
            SkillStunRate = newRate;
        }

        public int GetTotalDPSBonus()
        {
            int totalBonus = 0;
            foreach (int bonus in DPSPercentBonuses)
            {
                totalBonus += bonus;
            }
            return totalBonus;
        }

        public int GetDamage(int dps)
        {
            return (int)(dps * (Math.Log(Level) + 1) * DPSPercent * 0.01 * (1 + GetTotalDPSBonus() * 0.01));
        }
    }
}