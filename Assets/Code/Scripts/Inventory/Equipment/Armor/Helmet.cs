namespace Scripts.Inventory.Equipment.Armor
{
    public class Helmet : ArmorPiece
    {
        public const int Participation = 3;

        public Helmet(string name, string description, EquipmentRarity rarity, DefenseType defenseType, int defenseValue) : base(name, description, rarity, defenseType, defenseValue) { }

        public override int GetDefense(DamageType type)
        {
            return base.GetDefense(type) * Participation;
        }
    }
}