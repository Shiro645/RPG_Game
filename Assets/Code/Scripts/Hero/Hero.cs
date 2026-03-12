using System.Runtime.CompilerServices;

namespace Scripts.Hero
{
    public class Hero
    {
        public int Id { get; }
        public string Name { get; }
        public string Description { get; }

        public Role Role { get; }
        public Element Element { get; }
        public Rarity Rarity { get; }

        public int Level
        {
            get;
            private set
            {
                if (value < 1)
                {
                    Level = 1;
                }
                else
                {
                    Level = value;
                }
            }
        }

        public int EvolutionState
        {
            get;
            private set
            {
                if (value < 1)
                {
                    EvolutionState = 1;
                }
                else
                {
                    EvolutionState = value;
                }
            }
        }
        public int Evolution
        {
            get;
            private set
            {
                if (value < 0)
                {
                    Evolution = 0;
                }
                else
                {
                    Evolution = value;
                }
            }
        }

        public StatModifiers StatModifiers { get; }

        public Stats BaseStats { get; }
        public Bonuses Bonuses { get; private set; }

        public PartyBuff[] PartyBuffs { get; }

        public ChainSkill ChainSkill { get; }

        public Weapon Weapon { get; private set; }

        public Hero(int id, string name, string description, Rarity rarity, Role role, Element element, int[] baseStats, PartyBuff[] partyBuffs, int[] partyBuffsValues, ChainSkill chainSkill)
        {
            Id = id;
            Name = name;
            Description = description;

            Rarity = rarity;
            Role = role;
            Element = element;

            Level = 1;

            EvolutionState = (int)rarity + 1;
            Evolution = 0;

            StatModifiers = ConstantHeroes.Values[role];
            

            BaseStats = baseStats;
            Bonuses = new Bonuses();

            PartyBuffs = partyBuffs;

            ChainSkill = chainSkill;
        }

        // DPS Related Methods
        // DPS depends on the hero's total attack, crit rate, crit multiplier, and weapon damage.

        public int GetDPS()
        {
            return (GetDPSNoCrit() * (1 - GetCritRate())) + (GetDPSCrit() * GetCritRate());
        }

        public int GetDPSNoCrit()
        {
            return (int)(GetTotalAtk() * (Math.Log(Level) + 1) * (1 + 1 / Enum.GetNames(typeof(Rarity)).Length * (int)Rarity) * GetWeaponDamage());
        }

        public int GetDPSCrit()
        {
            return GetDPS() * GetCritMultiplier();
        }

        public int GetTotalAtk()
        {
            int totalAtkBonus = 0;
            foreach (var bonus in Bonuses.Atk)
            {
                totalAtkBonus += bonus;
            }
            return BaseStats.Atk * Bonuses.Atk * (1 + totalAtkBonus);
        }

        public double GetCritRate()
        {
            int totalCritRateBonus = 0;
            foreach (var bonus in Bonuses.CritRate)
            {
                totalCritRateBonus += bonus;
            }
            return BaseStats.CritRate * 0.01 * (1 + ConstantHeroes.CritRate / ConstantHeroes.MaxValue) * (1 + totalCritRateBonus * 0.01);
        }

        public double GetCritMultiplier()
        {
            int totalCritMultiplierBonus = 0;
            foreach (var bonus in Bonuses.CritMultiplier)
            {
                totalCritMultiplierBonus += bonus;
            }
            return BaseStats.CritMultiplier * 0.01 * (1 + ConstantHeroes.CritMultiplier / ConstantHeroes.MaxValue) * (1 + totalCritMultiplierBonus * 0.01);
        }


        // Damage of the Weapon increases by 10% if the weapon's element matches the hero's element.

        public int GetWeaponDamage()
        {
            if (Weapon == null)
            {
                return 1;
            }
            else if (Weapon.Element == Element)
            {
                return (int)(Weapon.GetDPS() * 1.1);
            }
            return Weapon.GetDPS();
        }
    }
}
