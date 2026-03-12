namespace Scripts.Hero.Stats.Utils
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

        public static int MAX_BONUS_COUNT = 5;

        public Bonuses()
        {
            Atk = new int[MAX_BONUS_COUNT];
            HP = new int[MAX_BONUS_COUNT];
            Def = new int[MAX_BONUS_COUNT];
            Heal = new int[MAX_BONUS_COUNT];
            DamageReduction = new int[MAX_BONUS_COUNT];
            CritRate = new int[MAX_BONUS_COUNT];
            CritMultiplier = new int[MAX_BONUS_COUNT];
            CritResistance = new int[MAX_BONUS_COUNT];
        }
    }
}