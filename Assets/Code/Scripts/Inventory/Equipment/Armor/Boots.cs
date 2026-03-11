namespace Scripts.Inventory.Equipment.Armor
{
    public class Boots : ArmorPiece
    {
        public const int Participation = 2;

        public Boots(string name, string description, EquipmentRarity rarity, DefenseType defenseType, int defenseValue) : base(name, description, rarity, defenseType, defenseValue) { }

        public override int GetDefense(DamageType type)
        {
            return base.GetDefense(type) * Participation;
        }
    }
}