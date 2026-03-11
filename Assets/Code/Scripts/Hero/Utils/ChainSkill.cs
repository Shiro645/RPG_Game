namespace Scripts.Hero.Utils
{
    public class ChainSkill
    {
        public string Name {get;}
        public string Description {get;}

        public int DPSPercent {get;}

        public SkillStun Previous {get;}
        public SkillStun Next {get;}

        public ChainSkill(string name, string description, int dpsPercent, SkillStun previous, SkillStun next)
        {
            Name = name;
            Description = description;
            DPSPercent = dpsPercent;
            Previous = previous;
            Next = next;
        }
    }
}