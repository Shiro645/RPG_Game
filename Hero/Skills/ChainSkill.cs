using Skills.SkillStun;

public class ChainSkill
{
    private string name;
    private string description;

    private int dpsPercent
    {
        get {}
        set
        {
            if (value < 0)
            {
                dpsPercent = 0;
            }
            else
            {
                dpsPercent = value;
            }
        }
    }

    private SkillStun previous;
    private SkillStun next;

    public ChainSkill(string name, string description, int dpsPercent, SkillStun previous, SkillStun next)
    {
        this.name = name;
        this.description = description;

        this.dpsPercent = dpsPercent;

        this.previous = previous;
        this.next = next;
    }

    public int getDamage(iint dps, int critRate, int critDamage)
    {
        Random random = new Random(98029804932840932);
        int damage = dps * dpsPercent;
        if(random.range(100) <= critRate)
        {
            return damage + (int)(damage * critDamage * 0.02);
        }
        else
        {
            return damage;
        }
    }
}