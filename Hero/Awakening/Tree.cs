using RPG.Hero.Awakening.AwakeningStone.AwakeningStoneType;
using RPG.Hero.Awakening.AwakeningStone.AwakeningStoneColor;

public class Tree
{
    public Dictionary<Node, (int, int)> Tree {get;}
    public List<Node> NodeList {get;}
    public int EvolutionState {get; private set;}

    public Tree(Dictionary<Node, (int, int)> tree, int evolutionState)
    {
        Tree = tree;
        EvolutionState = evolutionState;
        foreach (KeyValuePair node in Tree)
        {
            NodeList.Append(node.key);
        }
    }

    public Evolvle()
    {
        EvolutionState++;
    }

    public NodePrice UnlockAll(int gold)
    {
        NodePrice nodePrice = new NodePrice();
        while (goldRequired < gold)
        {
            
        }
    }
}