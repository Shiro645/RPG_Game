namespace Scripts.Hero.Stats.Utils
{
    public static class ConstantHeroes // Base Stat Modifiers of each Role 
    {
        public static readonly int MaxValue = 5;

        public static readonly Dictionary<Role, StatModifiers> Values = new()
        {
            {Role.Warrior,  new StatModifiers(3.5, 3.0, 2.5, 1.0, 2.0, 2.5, 3.0, 2.0)},
            {Role.Ranged,   new StatModifiers(5.0, 2.0, 1.5, 1.0, 1.0, 3.5, 4.0, 1.0)},
            {Role.Assassin, new StatModifiers(2.5, 2.0, 1.5, 1.0, 0.5, 2.5, 4.5, 1.0)},
            {Role.Mage,     new StatModifiers(3.0, 2.0, 2.5, 2.5, 1.5, 3.0, 3.5, 1.5)},
            {Role.Support,  new StatModifiers(1.0, 1.5, 2.0, 5.0, 1.0, 2.0, 1.0, 0.5)},
            {Role.Tank,     new StatModifiers(1.5, 4.0, 5.0, 1.0, 3.5, 1.5, 1.5, 3.5)}
        };
    }
}