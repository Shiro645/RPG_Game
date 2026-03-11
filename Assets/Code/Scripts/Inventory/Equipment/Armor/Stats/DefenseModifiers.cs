namespace Scripts.Inventory.Equipment.Armor.Stats
{
    public class DefenseModifiers
    {
        public int PhysicalDefense { get; }
        public int ProjectileDefense { get; } 
        public int MagicalDefense { get; }

        public DefenseModifiers(int physicalDefense, int projectileDefense, int magicalDefense)
        {
            PhysicalDefense = physicalDefense;
            ProjectileDefense = projectileDefense;
            MagicalDefense = magicalDefense;
        }

        public int GetDefense(DamageType type)
        {
            return type switch
            {
                DamageType.Melee => PhysicalDefense,
                DamageType.Ranged => ProjectileDefense,
                DamageType.Magical => MagicalDefense,
                default => throw new ArgumentException("Invalid damage type")
            };
        }
    }
}