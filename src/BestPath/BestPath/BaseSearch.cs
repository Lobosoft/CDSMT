using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPath
{
    public abstract class BaseSearch : IGraphSearcher
    {
        public abstract List<string> Search(Graph graph, string startName, string goalName);

        protected static List<string> ReconstructPath(Dictionary<Node, Node> cameFrom, Node current)
        {
            var path = new List<string>();
            while (current != null)
            {
                path.Insert(0, current.Name);
                cameFrom.TryGetValue(current, out current);
            }
            return path;
        }


    }
}
