namespace Scripts.Inventory.Equipment.Jewel
{
    public class Jewel : Equipment
    {
        public JewelType JewelType { get; }

        public JewelStat JewelStat { get; }

        public MainStat MainStat { get; private set; }

        public SubStat[] SubStats
        {
            get
            {
                SubStat[] subStats = new SubStat[subStatCount];
                for (int i = 0; i < subStatCount; i++)
                {
                    subStats[i] = SubStats[i];
                }
                return subStats;
            }
            private set;
        }
        public int SubStatCount {get; private set;}

        public Jewel(string name, string description, EquipmentRarity equipmentRarity, JewelType jewelType) : base(name, description, equipmentRarity)
        {
            JewelType = jewelType;
            JewelStat = new JewelStat(jewelType);
            MainStat = new MainStat();
            SubStats = new SubStat[5];
            SubStatCount = 0;
            SubStats[SubStatCount++] = new SubStat();
        }
    }
}