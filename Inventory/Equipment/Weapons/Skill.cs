using RPG.SkillStun;

public class Skill
{
    private string name;
    private string description;

    private int dpsPercent
    {
        get { }
        set
        {
            if (value < 0)
            {
                dpsPercent = 100;
            }
            else
            {
                dpsPercent = value;
            }
        }
    }

    private SkillStun skillStun;
    private int skillStunRate
    {
        get {}
        set
        {
            if (value < 0)
            {
                skillStunRate = 0;
            }
            else
            {
                skillStunRate = value;
            }
        }
    }

    public Skill(string name, string description, int dpsPercent, SkillStun skillStun, int skillStunRate)
    {
        this.name = name;
        this.description = description;

        this.dpsPercent = dpsPercent;

        this.skillStun = skillStun;
        this.skillStunRate = skillStunRate;
    }
}