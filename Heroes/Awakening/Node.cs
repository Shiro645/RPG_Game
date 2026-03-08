using System.Runtime.InteropServices;
using Awakening.NodeType;

public class Node
{
    private NodeType nodeType;
    private int value;

    private NodePrice nodePrice;

    private bool unlocked;

    private int evolutionState;

    private List<Node> required;

    public Node(NodeType nodeType, int value, int evolutionState)
    {
        this.nodeType = nodeType;
        this.value = value;

        this.unlocked = false;

        this.evolutionState = evolutionState;

        this.required = new List<Node>();
    }

    public Node(NodeType nodeType, int value, int evolutionState, List<Node> required, NodePrice nodePrice)
    {
        this(nodeType, value, evolutionState);
        this.required = required;
        this.nodePrice = nodePrice;
    }

    public bool isUnlocked()
    {
        return unlocked;
    }

    public (int, AwakeningStoneColor, AwakeningStoneType, int) getPrice()
    {
        return (nodePrice.getGold(), nodePrice.getColor(), nodePrice.getType(), nodePrice.getAmount());
    }

    public (NodeType, int) unlock()
    {
        for (int i = 0; i < parents.length(); i++)
        {
            if (!parents[i].isUnlocked())
            {
                Console.WriteLine("Error: One of the parents isn't unlocked");
                return (null, -1);
            }
        }
        unlocked = true;
        return (nodeType, value);
    }
}