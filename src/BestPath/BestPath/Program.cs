using BestPath;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace BestPath
{
    class Program
    {
        static void Main()
        {
            string json = File.ReadAllText("network.json");
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            var graph = JsonSerializer.Deserialize<Graph>(json, options);
            graph.InitializeNodeMap();
            
            var aStar = new AStar();
            var dijkstra = new Dijkstra();

            var aStarPath = aStar.Search(graph, "A", "G");
            Console.WriteLine("A* Path: " + string.Join(" -> ", aStarPath));

            var dijkstraPath = aStar.Search(graph, "A", "G");
            Console.WriteLine("Dijkstra Path: " + string.Join(" -> ", dijkstraPath));

            Console.ReadLine();
        }
    }

}