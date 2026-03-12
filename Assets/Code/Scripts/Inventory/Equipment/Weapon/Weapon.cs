namespace Scripts.Inventory.Equipment.Weapon
{
    public class Weapon : Equipment
    {
        public Element ElementDamage { get; }
        public WeaponType WeaponType { get; }
        public double ConstantWeapon { get; }

        public Skill Skill { get; }

        public int BaseDamage { get; }
        public int BaseAtkSpeed { get; }

        public int[] DamageBonus { get; private set; }
        public int[] AtkSpeedBonus { get; private set; }

        public static int MAX_BONUS_COUNT = 3;

        public Weapon(string name, string description, EquipmentRarity equipmentRarity, WeaponType weaponType, Skill skill, int damage, int atkSpeed) : base(name, description, equipmentRarity)
        {
            WeaponType = weaponType;
            ElementDamage = ElementDamage;
            ConstantWeapon = ConstantWeapons.Values[weaponType];
            Skill = skill;
            BaseDamage = damage;
            BaseAtkSpeed = atkSpeed;
            DamageBonus = new int[MAX_BONUS_COUNT];
            AtkSpeedBonus = new int[MAX_BONUS_COUNT];
        }

        // DPS related methods
        // DPS depends on the weapon's damage, attack speed, and any bonuses applied to them.

        public int GetDPS()
        {
            GetTotalDamage() * GetTotalAtkSpeed();
        }

        public int GetTotalDamage()
        {
            int totalDamage = (int)(BaseDamage * (Math.Log(Level) + 1) * ConstantWeapon * (1 + 1 / Enum.GetNames(typeof(EquipmentRarity)).Length * (int)Rarity) * (1 + GetDamageBonus() * 0.01));
        }

        public int GetDamageBonus()
        {
            int totalBonus = 0;
            foreach (var bonus in DamageBonus)
            {
                totalBonus += bonus;
            }
            return totalBonus;
        }

        public int GetTotalAtkSpeed()
        {
            return (int)(BaseAtkSpeed * (1 + GetAtkSpeedBonus() * 0.01));
        }

        public int GetAtkSpeedBonus()
        {
            int totalBonus = 0;
            foreach (var bonus in AtkSpeedBonus)
            {
                totalBonus += bonus;
            }
            return totalBonus;
        }


        // Bonuses related methods

        public void AddDamageBonus(int bonus)
        {
            int minIndex = 0;
            for (int i = 1; i < DamageBonus.Length; i++)
            {
                if (DamageBonus[i] < DamageBonus[minIndex])
                {
                    minIndex = i;
                }
            }
            if (bonus > DamageBonus[minIndex])
            {
                DamageBonus[minIndex] = bonus;
            }
        }

        public void AddAtkSpeedBonus(int bonus)
        {
            int minIndex = 0;
            for (int i = 1; i < AtkSpeedBonus.Length; i++)
            {
                if (AtkSpeedBonus[i] < AtkSpeedBonus[minIndex])
                {
                    minIndex = i;
                }
            }
            if (bonus > AtkSpeedBonus[minIndex])
            {
                AtkSpeedBonus[minIndex] = bonus;
            }
        }
    }
}