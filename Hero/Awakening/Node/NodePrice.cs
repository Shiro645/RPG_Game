using RPG.Hero.Awakening.AwakeningStone.AwakeningStoneColor;
using RPG.Hero.Awakening.AwakeningStone.AwakeningStoneType;

public class NodePrice
{
    public int Gold {get;}
    public AwakeningStoneColor AwakeningStoneColor {get;}
    public awakeningStoneType AwakeningStoneType {get;}
    public int Amount {get;}

    public NodePrice(int gold, AwakeningStoneColor awakeningStoneColor, AwakeningStoneType awakeningStoneType, int amount)
    {
        Gold = gold;
        AwakeningStoneColor = awakeningStoneColor;
        AwakeningStoneType = awakeningStoneType;
        Amount = amount;
    }
}