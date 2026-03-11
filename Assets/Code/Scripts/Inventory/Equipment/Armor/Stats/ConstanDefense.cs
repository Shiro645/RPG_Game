namespace Scripts.Inventory.Equipment.Armor.Stats
{
    public static class ConstantDefense
    {
        public static readonly Dictionary<DefenseType, DefenseModifiers> Values = new Dictionary<DefenseType, DefenseModifiers>
        {
            { DefenseType.GeneralDefense,   new DefenseModifiers(33, 33, 33) },
            { DefenseType.MeleeDefense,     new DefenseModifiers(50, 25, 10) },
            { DefenseType.RangedDefense,    new DefenseModifiers(15, 50, 15) },
            { DefenseType.MagicDefense,     new DefenseModifiers(10, 10, 75) }
        };
    }
}