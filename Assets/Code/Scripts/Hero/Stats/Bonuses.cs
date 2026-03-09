namespace Scripts.Hero.Stats
{
    public class Bonuses
    {
        public int[] Atk { get; private set; }
        public int[] HP { get; private set; }
        public int[] Def { get; private set; }
        public int[] Heal { get; private set; }
        public int[] DamageReduction { get; private set; }
        public int[] CritRate { get; private set; }
        public int[] CritMultiplier { get; private set; }
        public int[] CritResistance { get; private set; }

        public Bonuses()
        {
            Atk = new int[5];
            HP = new int[5];
            Def = new int[5];
            Heal = new int[5];
            DamageReduction = new int[5];
            CritRate = new int[5];
            CritMultiplier = new int[5];
            CritResistance = new int[5];
        }
    }
}