namespace Scripts.Hero.Party.Utils
{
    public class PartyBuff
    {
        public PartyBuffType BuffType { get; private set; }
        public int Value { get; private set; }

        public PartyBuff(PartyBuffType buffType, int value)
        {
            BuffType = buffType;
            Value = value;
        }
    }
}