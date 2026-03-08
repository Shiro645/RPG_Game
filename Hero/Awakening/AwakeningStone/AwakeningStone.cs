using RPG.Hero.Awakening.AwakeningStone.AwakeningStoneType;
using RPG.Hero.Awakening.AwakeningStone.AwakeningStoneColor;

public class AwakeningStone
{
    public AwakeningStoneType Type {get;}
    public AwakeningStoneColor Color {get;}

    public AwakeningStone(AwakeningStoneType type, AwakeningStoneColor color)
    {
        bool isSpecialType = type == AwakeningStoneType.Special;
        bool isSpecialColor = type == AwakeningStoneColor.Special;

        if (isSpecialType != isSpecialColor)
        {
            throw new ArgumentException("Special stones must use Special color and Special Type together.");
        }
        Type = type;
        Color = color;
    }

    public override bool Equals(AwakeningStone stone)
    {
        return Color == stone.Color && Type == stone.Type;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Color, Type);
    }
}