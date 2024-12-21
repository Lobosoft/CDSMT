using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPath
{
    public class Graph
    {
        public List<Node> Nodes { get; set; } = new();
        private Dictionary<string, Node> NodeMap;

        public void InitializeNodeMap()
        {
            NodeMap = new Dictionary<string, Node>();
            foreach (var node in Nodes)
            {
                NodeMap[node.Name] = node;
            }
        }

        public Node GetNode(string name)
        {
            return NodeMap.TryGetValue(name, out var node) ? node : null;
        }
    }
}
