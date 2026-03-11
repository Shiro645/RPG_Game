namespace Scripts.Hero
{
    public class Hero
    {
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

        public Hero(string name, string description, Rarity rarity, Role role, Element element, int[] baseStats, PartyBuff[] partyBuffs, int[] partyBuffsValues, ChainSkill chainSkill)
        {
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
            Bonuses = new int[8][5];

            PartyBuffs = partyBuffs;

            ChainSkill = chainSkill;
        }
    }
}