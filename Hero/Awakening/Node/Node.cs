public class Node
{
    public NodeType NodeType {get;}
    public int Value {get;}

    public int EvolutionStateRequired {get;}
    public bool IsUnlocked {get; private set;}

    public NodePrice NodePrice {get;}
    public bool IsBought {get; private set;}

    public List<Node> Required {get;}
    public List<Node> Children {get;}

    public Node(NodeType nodeType, int value, int evolutionStateRequired, NodePrice nodePrice)
    {
        NodeType = nodeType;
        Value = value;

        EvolutionStateRequired = evolutionStateRequired;
        IsUnlocked = false;

        NodePrice = nodePrice;
        IsBought = false;

        Required = new List<Node>();
    }

    public Node(NodeType nodeType, int value, int evolutionStateRequired, NodePrice nodePrice, List<Node> required)
    {
        this(nodeType, value, evolutionStateRequired, nodePrice);
        Required = required;
    }

    public void Unlock()
    {
        IsUnlocked = true;
    }

    public NodePrice Buy()
    {
        if (!IsUnlocked)
        {
            return -1;
        }
        foreach (Node node in Required)
        {
            if (!node.IsBought)
            {
                return 0;
            }
        }
        IsBought = true;
        return NodePrice;
    }
}