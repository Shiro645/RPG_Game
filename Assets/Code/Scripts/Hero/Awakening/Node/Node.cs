using System.Collections.Generic;

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

        public List<Node> Required { get; }
        public List<Node> Children { get; }

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

        public NodePrice Buy() // Return the price to buy the node
        {
            if (!IsUnlocked)
            {
                return null;
            }
            foreach (Node node in Required)
            {
                if (!node.IsBought)
                {
                    return null;
                }
            }
            IsBought = true;
            return NodePrice;
        }
    }
}