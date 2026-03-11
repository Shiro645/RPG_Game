namespace Scripts.Hero.Party.Utils
{
    public class PartyMember
    {
        public Hero Hero {get; private set;}
        public int Position {get; private set;}
        public Dictionary<Hero, PartyBuffs[]> PartyBuffSet { get; private set; }

        public PartyMember(Hero hero, int position, Dictionary<Hero, PartyBuffs[]> partyBuffSet)
        {
            Hero = hero;
            Position = position;
            PartyBuffSet = partyBuffSet;
        }

        public IsLeader()
        {
            return Position == 0;
        }
    }
}