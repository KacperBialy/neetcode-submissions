/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if (node == null) 
            return null;

        var map = new Dictionary<Node, Node>();
        return Clone(node);

        Node Clone(Node node)
        {
            if (map.TryGetValue(node, out var cloneNode))
                return cloneNode;

            cloneNode = new Node(node.val);
            map[node] = cloneNode;
            foreach (var nb in node.neighbors)
            {
                cloneNode.neighbors
                    .Add(Clone(nb));
            }

            return cloneNode;
        }
    }
}
