namespace Scripts.Inventory.AwakeningStone
{
    public class AwakeningStone
    {
        public AwakeningStoneType Type { get; }
        public AwakeningStoneColor Color { get; }

        public AwakeningStone(AwakeningStoneType type, AwakeningStoneColor color)
        {
            bool isSpecialType = type == AwakeningStoneType.Special;
            bool isSpecialColor = color == AwakeningStoneColor.Special;

            if (isSpecialType != isSpecialColor)
            {
                throw new System.ArgumentException("Special stones must use Special color and Special Type together.");
            }
            Type = type;
            Color = color;
        }

        public override bool Equals(object obj)
        {
            if (obj is AwakeningStone stone)
                return Color == stone.Color && Type == stone.Type;
            return false;
        }

        public override int GetHashCode()
        {
            return System.HashCode.Combine(Color, Type);
        }
    }
}