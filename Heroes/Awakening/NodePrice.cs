using System.Reflection;
using Awakening.AwakeningStone.AwakeningStoneColor;
using Awakening.AwakeningStone.AwakeningStoneType;

public class NodePrice
{
    private int gold
    {
        get {}
        set
        {
            if (value < 0)
            {
                gold = 0;
            }
            else
            {
                gold = value;
            }
        }
    }
    private AwakeningStoneColor awakeningStoneColor;
    private AwakeningStoneType awakeningStoneType;
    private int amount
    {
        get {}
        set
        {
            if (value < 0)
            {
                amount = 0;
            }
            else
            {
                amount = value;
            }
        }
    }

    public NodePrice(int gold, AwakeningStoneColor awakeningStoneColor, AwakeningStoneType awakeningStoneType, int amount)
    {
        this.gold = gold;
        this.awakeningStoneColor = awakeningStoneColor;
        this.awakeningStoneType = awakeningStoneType;
        this.amount = amount;
    }

    public int getGold()
    {
        return gold;
    }

    public AwakeningStoneColor getColor()
    {
        return awakeningStoneColor;
    }

    public AwakeningStoneType getType()
    {
        return awakeningStoneType;
    }

    public int getAmount()
    {
        return amount;
    }
}