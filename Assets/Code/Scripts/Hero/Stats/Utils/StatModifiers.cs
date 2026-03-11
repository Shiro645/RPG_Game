namespace Scripts.Hero.Stats.Utils
{
    public class StatModifiers
    {
        public double Atk { get; }
        public double HP { get; }
        public double Def { get; }
        public double Heal { get; }
        public double DamageReduction { get; }
        public double CritRate { get; }
        public double CritMultiplier { get; }
        public double CritResistance { get; }

        public StatModifiers(double atk, double hp, double def, double heal, double damageReduction, double critRate, double critMultiplier, double critResistance)
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