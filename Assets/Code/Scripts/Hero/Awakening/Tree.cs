namespace Scripts.Hero.Awakening
{
    public class Tree // Awakening tree like a skill tree
    {
        public List<Node> Root { get; }
        public List<Tree> Children { get; private set; }

        public int EvolutionState { get; private set; }

        public Tree(List<Node> root, List<Tree> children, int evolutionState)
        {
            Root = root;
            Children = children;
            EvolutionState = evolutionState;
        }

        public void Evolve()
        {
            EvolutionState++;
        }

        public void AddRoot(Node node)
        {
            Root.Add(node);
        }

        public void AddChild(Tree child)
        {
            Children.Add(child);
        }

        public void RemoveChild(Tree child)
        {
            Children.Remove(child);
        }

        public void RemoveRoot(Node node)
        {
            Root.Remove(node);
        }

        public void Reset()
        {
            EvolutionState = 0;
            foreach (Node node in Root)
            {
                node.IsBought = false;
                node.IsUnlocked = false;
            }
            foreach (Tree child in Children)
            {
                child.Reset();
            }
        }

        public void BuyAllNodes(Inventory inventory)
        {
            foreach (Node node in Root)
            {
                if (!node.IsBought && node.CanBeBought(inventory))
                {
                    node.Buy(inventory);
                }
            }
            foreach (Tree child in Children)
            {
                child.BuyAllNodes(inventory);
            }
        }
    }
}