namespace Scripts.Inventory.Equipment.Weapon
{
    public class ExclusiveWeapon : Weapon
    {
        private string owner;

        public ExclusiveWeapon(string name, string description, WeaponRarity weaponRarity, WeaponType weaponType, int damage, string owner) : base(name, description, weaponRarity, weaponType, damage)
        {
            this.owner = owner;
        }
    }
}