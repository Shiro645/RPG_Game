public class Hero
{
    private string name;
    private string description;

    private Rarity rarity;
    private Type type;
    private Element element;

    private int level
    {
        get { }
        set
        {
            if (value < 1)
            {
                level = 1;
            }
            else
            {
                level = value;
            }
        }
    }

    private int evolution
    {
        get { }
        set
        {
            if (value < 0)
            {
                evolution = 0;
            }
            else
            {
                evolution = value;
            }
        }
    }
    private int evolutionState
    {
        get { }
        set
        {
            if (value < 1)
            {
                evolutionState = 1;
            }
            else if (value > 7)
            {
                evolutionState = 7;
            }
            else
            {
                evolutionState = value;
            }
        }
    }

    private int atk;
    private int hp;
    private int def;
    private int heal;

    private int totalAtk
    {
        get { }
        set
        {
            if (value < 0)
            {
                totalAtk = 0;
            }
            else
            {
                totalAtk = value;
            }
        }
    }
    private int totalHP
    {
        get { }
        set
        {
            if (value < 0)
            {
                totalHP = 0;
            }
            else
            {
                totalHP = value;
            }
        }
    }
    private int totalDef
    {
        get { }
        set
        {
            if (value < 0)
            {
                totalDef = 0;
            }
            else
            {
                totalDef = value;
            }
        }
    }
    private int totalHeal
    {
        get { }
        set
        {
            if (value < 0)
            {
                totalHeal = 0;
            }
            else
            {
                totalHeal = value;
            }
        }
    }

    private int atkBonuses
    {
        get { }
        set
        {
            if (value < 0)
            {
                totalAtk = 0;
            }
            else
            {
                totalAtk = value;
            }
        }
    }
    private int hpBonuses
    {
        get { }
        set
        {
            if (value < 0)
            {
                totalHP = 0;
            }
            else
            {
                totalHP = value;
            }
        }
    }
    private int defBonuses
    {
        get { }
        set
        {
            if (value < 0)
            {
                totalDef = 0;
            }
            else
            {
                totalDef = value;
            }
        }
    }
    private int healBonuses
    {
        get { }
        set
        {
            if (value < 0)
            {
                totalHeal = 0;
            }
            else
            {
                totalHeal = value;
            }
        }
    }

    private int critRate
    {
        get { }
        set
        {
            if (value < 0)
            {
                critRate = 0;
            }
            else
            {
                critRate = value;
            }
        }
    }
    private int critDamage
    {
        get { }
        set
        {
            if (value < 100)
            {
                critDamage = 100;
            }
            else
            {
                critDamage = value;
            }
        }
    }

    private int damageReduction
    {
        get { }
        set
        {
            if (value < 0)
            {
                damageReduction = 0;
            }
            else
            {
                damageReduction = value;
            }
        }
    }

    private double constantHero
    {
        get { }
        set
        {
            if (value < 0)
            {
                constantHero = 0;
            }
            else
            {
                constantHero = value;
            }
        }
    }

    private PartyBuff[] pbs;
    private int[] partyBuffValues;

    private Skill skill;
    private ChainSkill chainSkill;

    private Weapon weapon;
    private int weaponDPS
    {
        get {} 
        set
        {
            if (value < 0)
            {
                weaponDPS = 0;
            }
            else
            {
                weaponDPS = value;
            }
        }
    }

    public Hero(string name, string description, Rarity rarity, Type type, Element element, 
                int atk, int hp, int def, int heal, int critRate, int critDamage, int damageReduction, 
                double constantHero, PartyBuff[] pbs, int[] partyBuffValues, ChainSkill chainSkill)
    {
        this.name = name;
        this.description = description;

        this.rarity = rarity;
        this.type = type;
        this.element = element;

        this.level = 1;

        this.evolution = 0;
        this.evolutionState = (int)rarity + 1;

        this.atk = atk;
        this.hp = hp;
        this.def = def;
        this.heal = heal;

        this.totalAtk = atk;
        this.totalHP = hp;
        this.totalDef = def;
        this.totalHeal = heal;

        this.critRate = critRate;
        this.critDamage = critDamage;

        this.damageReduction = damageReduction;

        this.constantHero = constantHero;

        this.pbs = pbs;
        this.partyBuffValues = partyBuffValues;

        this.chainSkill = chainSkill;
    }

    public int getDpsNoCrit()
    {
        return (int)((Math.Log(level) + 1) * totalAtk * constantHero * weaponDPS);
    }

    public int getDpsCrit()
    {
        return (int)(getDpsNoCrit() * critDamage * 0.01);
    }

    public int getTotalDps()
    {
        return getDpsCrit() * (critRate * 0.01) + getDpsNoCrit() * (1 - critRate * 0.01);
    }

    public void equipWeapon(Weapon weapon)
    {
        this.weapon = weapon;
        this.weaponDPS = weapon.getDPS();
        this.skill = weapon.getSkill();
        
    }
}