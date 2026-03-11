namespace Scripts.Inventory.Equipment.Jewel.Stats
{
    public class Stat
    {
        public MainStatType MainStatType { get; }
        public double Value { get; private set; }

        public static readonly Dictionary<StatType, double> MainStatMaxValue = new Dictionary<StatType, double>
        {
            { StatType.BossDamage, 15 },
            { StatType.PvPDamage, 7 },
            { StatType.PvEDamageReduction, 10 },
            { StatType.MeleeDamage, 5 },
            { StatType.RangedDamage, 5 },
            { StatType.MagicDamage, 5 },
            { StatType.FireDamage, 20 },
            { StatType.WaterDamage, 20 },
            { StatType.EarthDamage, 20 },
            { StatType.WindDamage, 20 },
            { StatType.LightDamage, 20 },
            { StatType.DarkDamage, 20 },
            { StatType.BasicDamage, 20 }
        };

        public MainStat(MainStatType mainStatType, double value)
        {
            MainStatType = mainStatType;
            Value = value;
        }

        public Stat()
        {
            Random random = new Random();
            MainStatType = (MainStatType)random.Next(Enum.GetValues(typeof(MainStatType)).Length);
            Value = random.NextDouble(MainStatMaxValue[StatType]);
        }
    }
}