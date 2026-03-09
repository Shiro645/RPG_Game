namespace Scripts.Hero.Party
{
    public class Party
    {
        public PartyMember[] Members { get; private set; }
        public int MembersCount { get; private set; }

        public static int DEFAULT_PARTY_SIZE = 4;

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
            if (MembersCount > Members.Length)
            {
                throw new Exception("Party is full");
            }
            Members[MembersCount++] = new PartyMember(hero);
        }

        public void ReplaceHero(Hero hero, int position)
        {
            if (position < 0 || position >= Members.Length)
            {
                throw new ArgumentOutOfRangeException("Position out of bounds");
            }
            else if (position > MembersCount)
            {
                Members[MembersCount++] = new PartyMember(hero);
            }
            Members[position] = new PartyMember(hero);
        }
    }
}