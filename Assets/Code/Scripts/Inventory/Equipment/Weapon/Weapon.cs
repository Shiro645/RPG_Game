using System.Runtime.CompilerServices;

namespace Scripts.Inventory.Equipment.Weapon
{
    public class Weapon : Equipment
    {
    private Element element;
    private WeaponType weaponType;
    private double constantWeapon;

    private Skill skill;

    private int damage
    {
        get { }
        set
        {
            if (value < 0)
            {
                damage = 0;
            }
            else
            {
                damage = value;
            }
        }
    }
    private int atkSpeed
    {
        get { }
        set
        {
            if (value < 0)
            {
                atkSpeed = 0;
            }
            else
            {
                atkSpeed = value;
            }
        }
    }

    public Weapon(string name, string description, EquipmentRarity equipmentRarity, WeaponType weaponType, Skill skill, int damage, int atkSpeed) : base(name, description, equipmentRarity)
    {
        this.weaponType = weaponType;

        switch (weaponType)
        {
            case OneHandedSword:
                constantWeapon = 1.5;
                break;
            case TwoHandedSword:
                constantWeapon = 2.5;
                break;
            case Bow:
                constantWeapon = 2;
                break;
            case Dagues:
                constantWeapon = 1;
                break;
            case Staff:
                constantWeapon = 2;
                break;
            case Orb:
                constantWeapon = 1.5;
                break;
            case Gauntlet:
                constantWeapon = 2.5;
                break;
            case Rifle:
                constantWeapon = 3;
                break;
            default:
                constantWeapon = 0;
                break;
        }

        this.skill = skill;

        this.damage = damage;
        this.atkSpeed = atkSpeed;
    }

    public Skill GetSkill()
    {
        return skill;
    }

    public int GetDPS()
    {
        return (int)((Math.Log(level) + 1) * damage * atkSpeed * constantWeapon);
    }
    }
}