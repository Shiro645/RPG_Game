namespace Scripts.Inventory.Equipment.Weapon
{
    public class ExclusiveWeapon : Weapon
    {
        public int OwnerId { get; }

        public ExclusiveWeapon(string name, string description, WeaponRarity weaponRarity, WeaponType weaponType, int damage, int ownerId) : base(name, description, weaponRarity, weaponType, damage)
        {
            OwnerId = ownerId;
        }
    }
}