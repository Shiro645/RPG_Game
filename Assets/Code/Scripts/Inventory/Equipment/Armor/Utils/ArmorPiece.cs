namespace Scripts.Inventory.Equipment.Armor.Utils
{
	public class ArmorPiece : Equipment
	{
		public Defense DefenseType { get; }

		public DefenseModifiers DefenseModifiers { get; }

		public ArmorPiece(string name, string description, EquipmentRarity rarity, DefenseType defenseType) : base(name, description, rarity)
		{
			DefenseType = defenseType;

			DefenseModifiers = ConstantArmor.Values[defenseType];
		}

		public GetDefense(DamageType type)
		{
			return  (Math.Log(Level)  + 1) * DefenseModifiers.GetDefense(type);
		}
	}
}