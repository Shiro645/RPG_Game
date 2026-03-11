namespace Scripts.Hero.Awakening.Node
{
    public class Node // Node of the Awakening Tree
    {
        public NodeType NodeType { get; }
        public int Value { get; }

        public int EvolutionStateRequired { get; }
        public bool IsUnlocked { get; private set; }

        public NodePrice NodePrice { get; }
        public bool IsBought { get; private set; }

        public List<Node> Required { get; private set; }

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
            : this(nodeType, value, evolutionStateRequired, nodePrice)
        {
            Required = required;
        }

        public void Unlock()
        {
            IsUnlocked = true;
        }

        public bool CanBeBought(Inventory inventory)
        {
            if (!IsUnlocked)
            {
                return false;
            }
            foreach (Node node in Required)
            {
                if (!node.IsBought)
                {
                    return false;
                }
            }
            if (!inventory.CanAfford(NodePrice))
            {
                return false;
            }
            return true;
        }

        public NodePrice Buy(Inventory inventory) // Return the price to buy the node
        {
            if (!CanBeBought(inventory))
            {
                throw new InvalidOperationException("Node cannot be bought.");
            }
            IsBought = true;
            return NodePrice;
        }
    }
}