namespace Scripts.Inventory.Equipment.Armor
{
    public class Leggings : ArmorPiece
    {
        public const int Participation = 5;

        public Leggings(string name, string description, EquipmentRarity rarity, DefenseType defenseType, int defenseValue) : base(name, description, rarity, defenseType, defenseValue) { }

        public override int GetDefense(DamageType type)
        {
            return base.GetDefense(type) * Participation;
        }
    }
}