namespace Scripts.Inventory.Equipment
{
    public class Equipment
    {
        public string Name { get; }
        public string Description { get; }
        
        public EquipmentRarity Rarity { get; }

        public int EvolutionState { get; private set; }
        public int Level { get; private set; }

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