namespace Scripts.Inventory.Equipment.Weapon
{
    public class ExclusiveWeapon : Weapon
    {
        public string Owner { get; }

        public ExclusiveWeapon(string name, string description, WeaponRarity weaponRarity, WeaponType weaponType, int damage, string owner) : base(name, description, weaponRarity, weaponType, damage)
        {
            Owner = owner;
        }
    }
}