namespace Scripts.Hero.Awakening.Node.Utils
{
    public class NodePrice // Combination of Gold and all the awakening stones required to buy the node
    {
        public int Gold { get; }
        public Dictionary<AwakeningStone, int> AwakeningStoneList { get; private set; }

        public NodePrice(int gold, Dictionary<AwakeningStone, int> awakeningStoneList)
        {
            Gold = gold;
            AwakeningStoneList = awakeningStoneList;
        }

        public NodePrice()
        {
            Gold = 0;
            AwakeningStoneList = new Dictionary<AwakeningStone, int>();
        }

        public static NodePrice operator +(NodePrice a, NodePrice b) // Add the values of each property of each nodeprice together
        {
            a.Gold += b.Gold;
            foreach (var kv in b.AwakeningStoneList)
            {
                var key = kv.Key;
                var value = kv.Value;
                if (a.AwakeningStoneList.ContainsKey(key))
                {
                    a.AwakeningStoneList[key] += value;
                }
                else
                {
                    a.AwakeningStoneList[key] = value;
                }
            }
            return a;
        }
    }
}