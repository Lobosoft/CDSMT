using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPath
{
    public interface IGraphSearcher
    {
        List<string> Search(Graph graph, string startName, string goalName);
    }
}
