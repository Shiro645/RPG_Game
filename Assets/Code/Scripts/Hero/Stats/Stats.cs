namespace Scripts.Hero.Stats
{
    public class Stats
    {
        public int Atk { get; }
        public int HP { get; }
        public int Def { get; }
        public int Heal { get; }
        public int DamageReduction { get; }
        public int CritRate { get; }
        public int CritMultiplier { get; }
        public int CritResistance { get; }

        public Stats(int atk, int hp, int def, int heal, int damageReduction, int critRate, int critMultiplier, int critResistance)
        {
            Atk = atk;
            HP = hp;
            Def = def;
            Heal = heal;
            DamageReduction = damageReduction;
            CritRate = critRate;
            CritMultiplier = critMultiplier;
            CritResistance = critResistance;
        }
    }
}