namespace Scripts.Inventory
{
    public class Inventory
    {
        public int Gold { get; }
        public int Gems { get; }
        public System.Collections.Generic.Dictionary<AwakeningStone, int> AwakeningStones { get; }
    }
}