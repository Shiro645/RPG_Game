namespace Scripts.Inventory.Equipment
{
    public class Equipment
    {
    protected string name;
    protected string description;
    protected EquipmentRarity equipmentRarity;
    protected int evolutionState
    {
        get { }
        set
        {
            if (value < 1)
            {
                evolutionState = 1;
            }
            else
            {
                evolutionState = value;
            }
        }
    }
    protected int level
    {
        get { }
        set
        {
            if (value < 1)
            {
                level = 1;
            }
            else
            {
                level = value;
            }
        }
    }

    public Equipment(string name, string description, EquipmentRarity equipmentRarity)
    {
        this.name = name;
        this.description = description;
        this.equipmentRarity = equipmentRarity;
        this.evolutionState = (int)equipmentRarity + 1;
        this.level = 1;
    }

    public string getName()
    {
        return name;
    }

    public string getDescription()
    {
        return description;
    }

    public EquipmentRarity getRarity()
    {
        return equipmentRarity;
    }

    public int getEvolutionState()
    {
        return evolutionState;
    }

    public void setEvolutionState(int evolutionState)
    {
        this.evolutionState = evolutionState;
    }

    public int getLevel()
    {
        return level;
    }

    public void setLEvel(int level)
    {
        this.level = level;
    }

    public string toString()
    {
        return "Name : " + name + "\nDescription : " + description + "\nRarity : " + equipmentRarity + "\nEvolution : " + evolutionState + "\nLevel : " + level;
    }
}