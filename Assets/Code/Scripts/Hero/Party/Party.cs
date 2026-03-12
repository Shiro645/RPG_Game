namespace Scripts.Hero.Party
{
    public class Party
    {
        public PartyMember[] Members { get; private set; }
        public int MembersCount { get; private set; }

        public Dictionary<Hero, PartyBuff[]> PartyBuffSet { get; private set; }

        public static int DEFAULT_PARTY_SIZE = 4;

        public Dictionary<PartyMember, PartyBuff[]> PartyBuffs { get; private set; }

        public Party(int partySize)
        {
            Members = new PartyMember[partySize];
            MembersCount = 0;
        }

        public Party()
        {
            this(DEFAULT_PARTY_SIZE);
        }

        public void Leader()
        {
            return Members[0];
        }

        public void AddHero(Hero hero)
        {
            if (MembersCount >= Members.Length)
            {
                throw new Exception("Party is full");
            }
            PartyBuffSet.Add(hero, hero.PartyBuffs);
            Members[MembersCount++] = new PartyMember(hero, MembersCount, PartyBuffSet);
        }

        public void ReplaceHero(Hero hero, int position)
        {
            if (position < 0 || position >= Members.Length)
            {
                throw new ArgumentOutOfRangeException("Position out of bounds");
            }
            else if (position >= MembersCount)
            {
                AddHero(hero);
            }
            else
            {
                PartyBuffSet.Remove(Members[position]);
                Members[position] = new PartyMember(hero);
            }
        }

        public void RemoveHero(int position)
        {
            if (position < 0 || position >= MembersCount)
            {
                throw new ArgumentOutOfRangeException("Position out of bounds");
            }
            for (int i = position; i < MembersCount - 1; i++)
            {
                Members[i] = Members[i + 1];
            }
            PartyBuffSet.Remove(Members[MembersCount]);
            Members[MembersCount--] = null;
        }
    }
}