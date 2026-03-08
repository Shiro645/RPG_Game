using System.Xml;
using System.Xml.Serialization;

public class Tree
{
    private List<Node> tree;

    public Tree(List<Node> tree)
    {
        this.tree = tree;
    }
}