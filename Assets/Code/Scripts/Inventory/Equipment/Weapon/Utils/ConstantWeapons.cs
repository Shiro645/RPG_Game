namespace Scripts.Inventory.Equipment.Weapon.Utils
{
    public static class ConstantWeapons // Base Stat Modifiers of each Weapon Type 
    {
        public static readonly Dictionary<WeaponType, double> Values = new()
        {
            {OneHandedSword,    2.0},
            {TwoHandedSword,    3.0},
            {Bow,               3.5},
            {Dagues,            1.5},
            {Staff,             1.0},
            {Orb,               2.5},
            {Gauntlet,          3.5},
            {Rifle,             4.0}
        };
    }
}