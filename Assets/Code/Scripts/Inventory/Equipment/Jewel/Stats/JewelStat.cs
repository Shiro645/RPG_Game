namespace Scripts.Inventory.Equipment.Jewel.Stats
{
    public class JewelStat
    {
        public JewelStatType JewelStatType { get; }
        public int Value { get; }

        public JewelStat(JewelType jewelType)
        {
            switch (jewelType)
            {
                case JewelType.Necklace:
                    JewelStatType = JewelStatType.Atk;
                    Value = 10;
                    break;
                case JewelType.Ring:
                    JewelStatType = JewelStatType.Def;
                    Value = 15;
                    break;
                case JewelType.Earrings:
                    JewelStatType = JewelStatType.HP;
                    Value = 20;
                    break;
                case JewelType.Bracelet:
                    JewelStatType = JewelStatType.CritRate;
                    Value = 7;
                    break;
                case JewelType.Belt:
                    JewelStatType = JewelStatType.CritMultiplier;
                    Value = 25;
                    break;
                default:
                    throw new ArgumentException("jewelType isn't valid");
            }
        }
    }
}