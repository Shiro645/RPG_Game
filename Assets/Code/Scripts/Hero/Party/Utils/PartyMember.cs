namespace Scripts.Hero.Party.Utils
{
    public class PartyMember : Hero
    {
        public Dictionary<Hero, Dictionnary<PartyBuff, int>> PartyBuffs { get; private set; }

        public PartyMember(Hero hero) : base(hero.Name, hero.Description, hero.Role, hero.Element, hero.Rarity, hero.Level, hero.EvolutionState, hero.Evolution, hero.StatModifiers)
        {
            PartyBuffs = new Dictionary<Hero, Dictionnary<PartyBuff, int>>();
        }

        public void AddPartyBuff(Hero hero, PartyBuff partyBuff, int value)
        {
            if (PartyBuffs.ContainsKey(hero))
            {
                PartyBuffs[hero][partyBuff] = value;
            }
            else
            {
                PartyBuffs[hero] = new Dictionnary<PartyBuff, int>();
                PartyBuffs[hero][partyBuff] = value;
            }
        }

        public void RemovePartyBuff(Hero hero, PartyBuff partyBuff)
        {
            if (PartyBuffs.ContainsKey(hero))
            {
                if (PartyBuffs[hero].ContainsKey(partyBuff))
                {
                    PartyBuffs[hero].Remove(partyBuff);
                }
            }
        }
    }
}