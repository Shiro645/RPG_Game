namespace Scripts.Inventory.Equipment
{
    public class Equipment
    {
        public string Name { get; }
        public string Description { get; }

        public EquipmentRarity Rarity { get; }

        public int EvolutionState
        {
            get;
            private set
            {
                if (value < 1)
                {
                    EvolutionState = 1;
                }
                else
                {
                    EvolutionState = value;
                }
            }
        }
        public int Level
        {
            get; private set
            {
                if (value < 1)
                {
                    Level = 1;
                }
                else
                {
                    Level = value;
                }
            }
        }

        public Equipment(string name, string description, EquipmentRarity equipmentRarity)
        {
            Name = name;
            Description = description;
            Rarity = equipmentRarity;
            EvolutionState = (int)equipmentRarity + 1;
            Level = 1;
        }
    }
}