using RPG.Hero.Awakening.AwakeningStone.AwakeningStoneType;
using RPG.Hero.Awakening.AwakeningStone.AwakeningStoneColor;

public class NodePrice
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

    public void Normalize()
    {
        Dictionary<AwakeningStone, int> newAwakeningStoneList = new Dictionary<AwakeningStone, int>();
        foreach (var (key, value) in AwakeningStoneList)
        {
            if (key.Type == AwakeningStoneType.Special)
            {
                newAwakeningStoneList.Add(key, value);
            }
            else if (key.Type == AwakeningStoneType.Small)
            {
                if (value >= 550)
                {
                    AwakeningStone largeStone = new AwakeningStone(AwakeningStoneType.Large, key.Color);
                    int largeStoneAmount = value / 500;

                    AwakeningStone mediumStone = new AwakeningStone(AwakeningStoneType.Medium, key.Color);
                    int mediumStoneAmount = value % 500 / 50;

                    AwakeningStone smallStone = new AwakeningStone(AwakeningStoneType.Small, key.Color);
                    int smallStoneAmount = value % 50;

                    if (newAwakeningStoneList.ContainsKey(largeStone))
                    {
                        newAwakeningStoneList[largeStone] = largeStoneAmount;
                    }
                    else
                    {
                        newAwakeningStoneList[largeStone] += largeStoneAmount;
                    }

                    if (newAwakeningStoneList.ContainsKey(mediumStone))
                    {
                        newAwakeningStoneList[mediumStone] = mediumStoneAmount;
                    }
                    else
                    {
                        newAwakeningStoneList[mediumStone] += mediumStoneAmount;
                    }

                    if (newAwakeningStoneList.ContainsKey(smallStone))
                    {
                        newAwakeningStoneList[smallStone] = smallStoneAmount;
                    }
                    else
                    {
                        newAwakeningStoneList[smallStone] += smallStoneAmount;
                    }
                }
                else if (value >= 500)
                {
                    AwakeningStone largeStone = new AwakeningStone(AwakeningStoneType.Large, key.Color);
                    int largeStoneAmount = value / 500;

                    AwakeningStone smallStone = new AwakeningStone(AwakeningStoneType.Small, key.Color);
                    int smallStoneAmount = value % 50;

                    if (newAwakeningStoneList.ContainsKey(largeStone))
                    {
                        newAwakeningStoneList[largeStone] = largeStoneAmount;
                    }
                    else
                    {
                        newAwakeningStoneList[largeStone] += largeStoneAmount;
                    }

                    if (newAwakeningStoneList.ContainsKey(smallStone))
                    {
                        newAwakeningStoneList[smallStone] = smallStoneAmount;
                    }
                    else
                    {
                        newAwakeningStoneList[smallStone] += smallStoneAmount;
                    }
                }
                else if (value >= 50)
                {
                    AwakeningStone mediumStone = new AwakeningStone(AwakeningStoneType.Medium, key.Color);
                    int mediumStoneAmount = value % 500 / 50;

                    AwakeningStone smallStone = new AwakeningStone(AwakeningStoneType.Small, key.Color);
                    int smallStoneAmount = value % 50;

                    if (newAwakeningStoneList.ContainsKey(mediumStone))
                    {
                        newAwakeningStoneList[mediumStone] = mediumStoneAmount;
                    }
                    else
                    {
                        newAwakeningStoneList[mediumStone] += mediumStoneAmount;
                    }

                    if (newAwakeningStoneList.ContainsKey(smallStone))
                    {
                        newAwakeningStoneList[smallStone] = smallStoneAmount;
                    }
                    else
                    {
                        newAwakeningStoneList[smallStone] += smallStoneAmount;
                    }
                }
                else
                {
                    if (newAwakeningStoneList.ContainsKey(key))
                    {
                        newAwakeningStoneList[key] = value;
                    }
                    else
                    {
                        newAwakeningStoneList[key] += value;
                    }
                }
            }
        }
        AwakeningStoneList = newAwakeningStoneList;
    }

    public void ReverseNomalize()
    {
        Dictionary<AwakeningStone, int> newAwakeningStoneList = new Dictionary<AwakeningStone, int>();
        foreach (var (key, value) in AwakeningStoneList)
        {
            AwakeningStone smallStone = new AwakeningStone(AwakeningStoneType.Small, key.Color);
            int newValue = value;

            if (key.Type == AwakeningStoneType.Large)
            {
                newValue = value * 500;
            }
            else if (key.Type == AwakeningStoneType.Small)
            {
                newValue = value * 50;
            }

            if (newAwakeningStoneList.ContainsKey(smallStone))
            {
                newAwakeningStoneList[smallStone] = newValue;
            }
            else
            {
                newAwakeningStoneList[smallStone] += newValue;
            }
        }
        AwakeningStoneList = newAwakeningStoneList;
    }

    public NodePrice operator +(NodePrice a, NodePrice b)
    {
        NodePrice newNodePrice = new NodePrice();
        newNodePrice.Gold = a.Gold + b.Gold;
        foreach (var (key, value) in a.AwakeningStoneList)
        {
            newNodePrice.AwakeningStoneList.Add(key, value);
        }
        foreach (var (key, value) in b.AwakeningStoneList)
        {
            if (newNodePrice.AwakeningStoneList.ContainsKey(key))
            {
                newNodePrice.AwakeningStoneList[key] += value;
            }
            else
            {
                newNodePrice.AwakeningStoneList[key] = value;
            }
        }
        return newNodePrice;
    }
}