using Scripts.Inventory.AwakeningStone;
using System.Collections.Generic;

namespace Scripts.Hero.Awakening
{
    public class Tree // Awakening tree like a skill tree that 
    {
        public Dictionary<Node, (int, int)> Tree { get; }
        public List<Node> NodeList { get; }
        public int EvolutionState { get; private set; }

        public Tree(Dictionary<Node, (int, int)> tree, int evolutionState)
        {
            Tree = tree;
            EvolutionState = evolutionState;
            foreach (KeyValuePair<Node, (int, int)> node in Tree)
            {
                NodeList.Add(node.Key);
            }
        }

        public void Evolvle()
        {
            EvolutionState++;
        }

        public void BuyAll(Inventory inventory)
        {
            return;
        }
    }
}