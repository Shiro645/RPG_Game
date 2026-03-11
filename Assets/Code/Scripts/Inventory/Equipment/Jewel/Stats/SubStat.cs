namespace Scripts.Inventory.Equipment.Jewel.Stats
{
    public class SubStat
    {
        public SubStatType SubStatType { get; }
        public double Value { get; private set; }

        public static readonly Dictionary<SubStatType, float> SubStatMaxValues = new Dictionary<StatType, Double>
        {
            { SubStatType.Atk, 5 },
            { SubStatType.HP, 7 },
            { SubStatType.Def, 5 },
            { SubStatType.Heal, 7 },
            { SubStatType.DamageReduction, 20 },
            { SubStatType.CritRate, 10 },
            { SubStatType.CritMultiplier, 30 },
            { SubStatType.CritResistance, 25 }
        };

        public SubStat(SubStatType subStatType, double value)
        {
            SubStatType = subStatType;
            Value = value;
        }

        public SubStat()
        {
            Random random = new Random();
            SubStatType = (SubStatType)random.Next(Enum.GetValues(typeof(SubStatType)).Length);
            Value = random.NextDouble(SubStatMaxValues[SubStatType]);
        }

        public void Reroll()
        {
            Random random = new Random();
            SubStatType = (SubStatType)random.Next(Enum.GetValues(typeof(SubStatType)).Length);
            Value = random.NextDouble(SubStatMaxValues[SubStatType]);
        }
    }
}